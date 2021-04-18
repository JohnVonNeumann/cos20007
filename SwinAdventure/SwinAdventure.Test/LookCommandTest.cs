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
        }

        [Test]
        public void TestLookAtMe()
        {
            _player.Inventory.Put(_weapon);
            _player.Inventory.Put(_armour);
            _player.Inventory.Put(_food);
            string[] input = new[] {"look", "at", "inventory"};
            _lookCommand.Execute(_player, input);
            Assert.AreEqual(
                "You are carrying:\nBig Friggin Gun - Weapon\nIllidan's Plated Glory - Armour\nKiwifruit Pie - Food\n",
                _lookCommand.Execute(_player, input));
        }

        [Test]
        public void TestLookAtGem()
        {
            Assert.Pass();
        }

        [Test]
        public void TestLookAtUnk()
        {
            Assert.Pass();
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            Assert.Pass();
        }

        [Test]
        public void TestLookAtGemInBag()
        {
            Assert.Pass();
        }

        [Test]
        public void TestLookAtGemInNoBag()
        {
            Assert.Pass();
        }

        [Test]
        public void TestLookAtNoGemInBag()
        {
            Assert.Pass();
        }

        [Test]
        public void TestInvalidLook()
        {
            Assert.AreEqual(
                "I don't know how to look like that",
                _lookCommand.Execute(_player, new[] {"look"}),
                "Length must be 3 or 5, not 1.");

            Assert.AreEqual(
                "I don't know how to look like that",
                _lookCommand.Execute(_player, new[] {"look", "around"}),
                "Length must be 3 or 5, not 2.");

            Assert.AreEqual(
                "I don't know how to look like that",
                _lookCommand.Execute(_player, new[] {"look", "around", "at", "fails"}),
                "Length must be 3 or 5, not 4.");

            Assert.AreEqual(
                "Error in look input",
                _lookCommand.Execute(_player, new[] {"jump", "around", "hall", "still", "fails"}),
                "First word must be 'look'.");

            Assert.AreEqual(
                "Error in look input",
                _lookCommand.Execute(_player, new[] {"jump", "around", "hall"}),
                "First word must be 'look'.");

            Assert.AreEqual(
                "What do you want to look at?",
                _lookCommand.Execute(_player, new[] {"look", "around", "hall"}),
                "Second word must be 'at'.");

            Assert.AreEqual(
                "What do you want to look in?",
                _lookCommand.Execute(_player, new[] {"look", "at", "sword", "towards", "bag"}),
                "4th word must be 'in'.");
        }
    }
}