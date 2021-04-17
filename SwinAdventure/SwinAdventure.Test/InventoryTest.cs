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
            Assert.Pass();
        }

        [Test]
        public void TestNoItemFind()
        {
            Assert.Pass();
        }

        [Test]
        public void TestFetchItem()
        {
            Assert.Pass();
        }

        [Test]
        public void TestTakeItem()
        {
            Assert.Pass();
        }

        [Test]
        public void TestItemList()
        {
            Assert.Pass();
        }
    }
}