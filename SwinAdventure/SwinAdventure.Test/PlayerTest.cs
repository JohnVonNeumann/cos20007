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