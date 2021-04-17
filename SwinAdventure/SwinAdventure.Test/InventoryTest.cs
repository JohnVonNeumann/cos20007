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
            string[] idents = new[] {"BFG"};
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
        public void TestTakeItem()
        {
            _inventory.Put(_item);
            _inventory.Take("BFG");
            Assert.False(_inventory.HasItem("BFG"));
        }

        [Test]
        public void TestItemList()
        {
            Assert.Pass();
        }
    }
}