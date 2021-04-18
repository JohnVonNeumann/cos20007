using NUnit.Framework;

namespace SwinAdventure.Test
{
    public class BagTest
    {
        private Bag _bag;
        private Item _weapon;
        private Item _armour;
        private Item _food;

        [SetUp]
        public void Setup()
        {
            string[] idents = new[] {"bag", "backpack"};
            _bag = new Bag(idents, "Netherweave Bag", "A hand crafted elven bag.");
            string[] identsGun = {"Weapon", "BFG", "Rocket Launcher"};
            _weapon = new Item(identsGun,
                "Big Friggin Gun",
                "The biggest gun available in the game"
            );

            string[] identsArmour = {"Armour", "Platemail", "Heavy Armour"};
            _armour = new Item(identsArmour,
                "Illidan's Plated Glory",
                "Tier 9 Epic Plate Mail"
            );

            string[] identsConsumables = {"Food", "Consumable", "Health Regeneration"};
            _food = new Item(identsConsumables,
                "Kiwifruit Pie",
                "Heals Player on consumption for 2000 hp over 12 seconds"
            );

        }

        [Test]
        public void TestBagLocatesItems()
        {
            _bag.Inventory.Put(_weapon);
            _bag.Inventory.Put(_armour);
            _bag.Inventory.Put(_food);

            Assert.AreSame(_weapon, _bag.Locate("weapon"));
            Assert.AreSame(_armour, _bag.Locate("armour"));
            Assert.AreSame(_food, _bag.Locate("food"));
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