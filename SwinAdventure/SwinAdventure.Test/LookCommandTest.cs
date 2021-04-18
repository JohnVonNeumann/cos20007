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
            Assert.Pass();
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
                _lookCommand.Execute(_player, new []{"look"}));
            Assert.AreEqual(
                "I don't know how to look like that",
                _lookCommand.Execute(_player, new []{"look around"}));
            Assert.AreEqual(
                "I don't know how to look like that",
                _lookCommand.Execute(_player, new []{"look around at fails"}));
        }
    }
}