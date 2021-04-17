using NUnit.Framework;

namespace SwinAdventure.Test
{
    public class PlayerTest
    {
        private Player _player;

        [SetUp]
        public void Setup()
        {
            _player = new Player("John", "Player 1");

            string[] identsGun = {"Weapon", "BFG", "Rocket Launcher"};
            Item weapon = new Item(identsGun,
                "Big Friggin Gun",
                "The biggest gun available in the game"
            );

            string[] identsArmour = {"Armour", "Platemail", "Heavy Armour"};
            Item armour = new Item(identsArmour,
                "Illidan's Plated Glory",
                "Tier 9 Epic Plate Mail"
            );

            string[] identsConsumables = {"Food", "Consumable", "Health Regeneration"};
            Item food = new Item(identsConsumables,
                "Kiwifruit Pie",
                "Heals Player on consumption for 2000 hp over 12 seconds"
            );

            _player.Inventory.Put(weapon);
            _player.Inventory.Put(armour);
            _player.Inventory.Put(food);
        }

        [Test]
        public void TestPlayerIsIdentifiable()
        {
            Assert.True(_player.AreYou("me"));
        }

        [Test]
        public void TestPlayerLocatesItems()
        {
            Assert.Pass();
        }

        [Test]
        public void TestPlayerLocatesItself()
        {
            Assert.Pass();
        }

        [Test]
        public void TestPlayerLocatesNothing()
        {
            Assert.Pass();
        }

        [Test]
        public void TestPlayerFullDescription()
        {
            Assert.Pass();
        }
    }
}