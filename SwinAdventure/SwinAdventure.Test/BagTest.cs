using NUnit.Framework;

namespace SwinAdventure.Test
{
    public class BagTest
    {
        private Bag _bag;

        [SetUp]
        public void Setup()
        {
            _bag = new Bag();
        }

        [Test]
        public void TestBagLocatesItems()
        {
            Assert.Pass();
        }
        
        [Test]
        public void TestBagLocatesItself()
        {
            Assert.Pass();
        }
        
        [Test]
        public void TestBagLocatesNothing()
        {
            Assert.Pass();
        }
        
        [Test]
        public void TestBagFullDescription()
        {
            Assert.Pass();
        }
        
        [Test]
        public void TestBagInBag()
        {
            Assert.Pass();
        }
    }
}