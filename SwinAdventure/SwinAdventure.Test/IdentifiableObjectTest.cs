using NUnit.Framework;
using SwinAdventure.Abstract;

namespace SwinAdventure.Test
{
    public class IdentifiableObjectTests
    {
        private IdentifiableObject _iObject;
        private string[] idents = new []{"Hello", "World"};

        [SetUp]
        public void Setup()
        {
            // string[] idents;
            // idents = new[] { "Hello", "World" };
            // _iObject = new IdentifiableObject(idents);
        }

        [Test]
        public void TestAreYou()
        {
            _iObject = new IdentifiableObject(idents);
            Assert.True(_iObject.AreYou("Hello"));
            Assert.False(_iObject.AreYou("Meme"));
        }
    }
}