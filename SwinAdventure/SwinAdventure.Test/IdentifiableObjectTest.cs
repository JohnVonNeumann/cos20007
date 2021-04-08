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
            _iObject = new IdentifiableObject(idents);
        }

        [Test]
        public void TestAreYou()
        {
            Assert.True(_iObject.AreYou(id: "Hello"));
        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.False(_iObject.AreYou( id: "Doesn't exist"));
        }

        [Test]
        public void TestCaseSensitive()
        {
            Assert.True(_iObject.AreYou(id: "HELLO"));
            Assert.True(_iObject.AreYou(id: "hELLO"));
            Assert.True(_iObject.AreYou(id: "hello"));
        }
        
    }
}