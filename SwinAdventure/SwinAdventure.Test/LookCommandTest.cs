using NUnit.Framework;

namespace SwinAdventure.Test
{
    public class LookCommandTest
    {
        private LookCommand _lookCommand;
        private Player _player;
        private Bag _bag;
        private Item _weapon;
        private Item _armour;
        private Item _food;
        private Item _gem;

        [SetUp]
        public void Setup()
        {
            _lookCommand = new LookCommand();
            _player = new Player("Varg", "The Enflamer");
            _bag = new Bag(
                new []{"bag"}, 
                "Netherweave Bag", 
                "A hand crafted elven bag."
                );
            
            string[] identsGun = {"Weapon", "BFG", "Rocket Launcher"};
            _weapon = new Item(identsGun,
                "Big Friggin Gun",
                "The biggest gun available in the game"
            );

            string[] identsArmour = {"Armour", "Platemail", "Heavy Armour"};
            _armour = new Item(identsArmour,
                "Illidan's Plated Glory",
                "Tier 9 Epic Plate Mail"
            );

            string[] identsConsumables = {"Food", "Consumable", "Health Regeneration"};
            _food = new Item(identsConsumables,
                "Kiwifruit Pie",
                "Heals Player on consumption for 2000 hp over 12 seconds"
            );

            _gem = new Item(
                new string[] {"gem"},
                "Eye of Azeroth",
                "Enables smiting of Alliance scum regardless of PvP status."
            );
        }

        [Test]
        public void TestLookAtMe()
        {
            _player.Inventory.Put(_weapon);
            _player.Inventory.Put(_armour);
            _player.Inventory.Put(_food);
            string[] input = new[] {"look", "at", "inventory"};
            Assert.AreEqual(
                "You are Varg The Enflamer\nYou are carrying:\n\tBig Friggin Gun (Weapon)\n\tIllidan's Plated Glory (Armour)\n\tKiwifruit Pie (Food)\n",
                _lookCommand.Execute(_player, input));
        }

        [Test]
        public void TestLookAtGem()
        {
            _player.Inventory.Put(_gem);
            string[] input = new[] {"look", "at", "gem"};
            Assert.AreEqual(
                "Enables smiting of Alliance scum regardless of PvP status.",
                _lookCommand.Execute(_player, input));
        }

        [Test]
        public void TestLookAtUnk()
        {
            string[] input = new[] {"look", "at", "gem"};
            Assert.AreEqual(
                "I can't find the gem",
                _lookCommand.Execute(_player, input));
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            _player.Inventory.Put(_gem);
            string[] input = new[] {"look", "at", "gem", "in", "inventory"};
            Assert.AreEqual(
                "Enables smiting of Alliance scum regardless of PvP status.",
                _lookCommand.Execute(_player, input));
        }

        [Test]
        public void TestLookAtGemInBag()
        {
            _bag.Inventory.Put(_gem);
            _player.Inventory.Put(_bag);
            string[] input = new[] {"look", "at", "gem", "in", "bag"};
            Assert.AreEqual(
                "Enables smiting of Alliance scum regardless of PvP status.",
                _lookCommand.Execute(_player, input));
        }

        [Test]
        public void TestLookAtGemInNoBag()
        {
            string[] input = new[] {"look", "at", "gem", "in", "bag"};
            Assert.AreEqual(
                "I cannot find the bag\n",
                _lookCommand.Execute(_player, input));
        }

        [Test]
        public void TestLookAtNoGemInBag()
        {
            _player.Inventory.Put(_bag);
            string[] input = new[] {"look", "at", "gem", "in", "bag"};
            Assert.AreEqual(
                "I can't find the gem",
                _lookCommand.Execute(_player, input));
        }

        [Test]
        public void TestInvalidLook()
        {
            Assert.AreEqual(
                "I don't know how to look like that\n",
                _lookCommand.Execute(_player, new[] {"look"}),
                "Length must be 3 or 5, not 1.");

            Assert.AreEqual(
                "I don't know how to look like that\n",
                _lookCommand.Execute(_player, new[] {"look", "around"}),
                "Length must be 3 or 5, not 2.");

            Assert.AreEqual(
                "I don't know how to look like that\n",
                _lookCommand.Execute(_player, new[] {"look", "around", "at", "fails"}),
                "Length must be 3 or 5, not 4.");

            Assert.AreEqual(
                "Error in look input\n",
                _lookCommand.Execute(_player, new[] {"jump", "around", "hall", "still", "fails"}),
                "First word must be 'look'.");

            Assert.AreEqual(
                "Error in look input\n",
                _lookCommand.Execute(_player, new[] {"jump", "around", "hall"}),
                "First word must be 'look'.");

            Assert.AreEqual(
                "What do you want to look at?\n",
                _lookCommand.Execute(_player, new[] {"look", "around", "hall"}),
                "Second word must be 'at'.");

            Assert.AreEqual(
                "What do you want to look in?\n",
                _lookCommand.Execute(_player, new[] {"look", "at", "sword", "towards", "bag"}),
                "4th word must be 'in'.");
        }
    }
}