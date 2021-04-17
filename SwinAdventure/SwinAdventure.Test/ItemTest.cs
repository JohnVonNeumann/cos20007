using NUnit.Framework;
using SwinAdventure.Abstract;

namespace SwinAdventure.Test
{
    public class ItemTests
    {
        private ItemObject _itemObject;
        private string[] idents = new []{"Frostmourne", "Sword of the Lich King"};

        [SetUp]
        public void Setup()
        {
            _itemObject = new ItemObject(idents, "Frostmourne", "Frostmourne was the fearsome, rune-inscribed two-handed longsword of the Lich King.");
        }

        [Test]
        public void TestItemIsIdentifiable()
        {
            Assert.True(_itemObject.AreYou(id: "Frostmourne"));
        }
        
    }
}
