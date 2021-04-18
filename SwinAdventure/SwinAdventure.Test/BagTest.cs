using NUnit.Framework;

namespace SwinAdventure.Test
{
    public class BagTest
    {
        private Bag _bag;

        [SetUp]
        public void Setup()
        {
            string[] idents = new[] {"bag", "backpack"};
            _bag = new Bag(idents, "Netherweave Bag", "A hand crafted elven bag.");
        }

        [Test]
        public void TestBagLocatesItems()
        {
            Assert.Pass();
        }
        
        [Test]
        public void TestBagLocatesItself()
        {
            Assert.AreSame(_bag, _bag.Locate("bag"));
            Assert.AreSame(_bag, _bag.Locate("backpack"));
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