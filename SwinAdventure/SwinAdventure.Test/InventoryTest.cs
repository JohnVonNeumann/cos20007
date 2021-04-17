using NUnit.Framework;

namespace SwinAdventure.Test
{
    public class InventoryTest
    {
        private Inventory _inventory;
        private Item _item;

        [SetUp]
        public void Setup()
        {
            _inventory = new Inventory();
            string[] idents = {"BFG"};
            _item = new Item(idents,
                "Big Friggin' Gun",
                "The biggest gun available in the game"
                );
        }

        [Test]
        public void TestFindItem()
        {
            _inventory.Put(_item);
            Assert.True(_inventory.HasItem("BFG"));
        }

        [Test]
        public void TestNoItemFind()
        {
            Assert.False(_inventory.HasItem("Nope.avi"));
        }

        [Test]
        public void TestFetchItem()
        {
            _inventory.Put(_item);
            Assert.AreEqual(_item, _inventory.Fetch("BFG"));
        }

        [Test]
        public void TestFetchNoItem()
        {
            Assert.AreEqual(null, _inventory.Fetch("fail"));
        }

        [Test]
        public void TestTakeItem()
        {
            _inventory.Put(_item);
            _inventory.Take("BFG");
            Assert.False(_inventory.HasItem("BFG"));
        }

        [Test]
        public void TestTakeNoItem()
        {
            Assert.AreEqual(null, _inventory.Take("fail"));
        }

        [Test]
        public void TestItemList()
        {
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

            _inventory.Put(weapon);
            _inventory.Put(armour);
            _inventory.Put(food);

            string expected = "Big Friggin Gun - Weapon\nIllidan's Plated Glory - Armour\nKiwifruit Pie - Food\n";

            Assert.AreEqual(expected, _inventory.ItemList);
        }
    }
}