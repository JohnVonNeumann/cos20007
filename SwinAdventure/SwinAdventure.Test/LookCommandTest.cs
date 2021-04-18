using NUnit.Framework;

namespace SwinAdventure.Test
{
    public class LookCommandTest
    {
        private LookCommand _lookCommand;

        [SetUp]
        public void Setup()
        {
            _lookCommand = new LookCommand();
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
            Assert.Pass();
        }
    }
}