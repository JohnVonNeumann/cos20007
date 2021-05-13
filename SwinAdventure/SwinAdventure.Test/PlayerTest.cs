using NUnit.Framework;

namespace SwinAdventure.Test
{
    public class PlayerTest
    {
        private Player _player;
        private Item _weapon;
        private Item _armour;
        private Item _food;

        [SetUp]
        public void Setup()
        {
            _player = new Player("John", "Player 1");

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

            _player.Inventory.Put(_weapon);
            _player.Inventory.Put(_armour);
            _player.Inventory.Put(_food);
        }

        [Test]
        public void TestPlayerIsIdentifiable()
        {
            Assert.True(_player.AreYou("me"));
            Assert.True(_player.AreYou("inventory"));
        }

        [Test]
        public void TestPlayerLocatesItems()
        {
            Assert.AreSame(_weapon, _player.Locate("Weapon"));
            Assert.AreSame(_armour, _player.Locate("Armour"));
            Assert.AreSame(_food, _player.Locate("Food"));
        }

        [Test]
        public void TestPlayerLocatesItself()
        {
            Assert.AreSame(_player, _player.Locate("me"));
        }

        [Test]
        public void TestPlayerLocatesNothing()
        {
            Assert.AreEqual(null, _player.Locate("fail"));
        }

        [Test]
        public void TestPlayerFullDescription()
        {
            Assert.AreEqual(
                "You are John Player 1\nYou are carrying:\n\tBig Friggin Gun (Weapon)\n\tIllidan's Plated Glory (Armour)\n\tKiwifruit Pie (Food)\n",
                _player.FullDescription);
        }

        [Test]
        public void TestPlayerName()
        {
            Assert.AreEqual("John", _player.Name);
        }
    }
}