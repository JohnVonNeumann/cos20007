using NUnit.Framework;

namespace SwinAdventure.Test
{
    public class BagTest
    {
        private Bag _bag;
        private Bag _bagBag;
        private Item _weapon;
        private Item _armour;
        private Item _food;
        private Item _gem;

        [SetUp]
        public void Setup()
        {
            string[] idents = new[] {"bag", "backpack"};
            _bag = new Bag(idents, "Netherweave Bag", "A hand crafted elven bag.");

            string[] identsBagBag = new[] {"Frostweave Bag"};
            _bagBag = new Bag(identsBagBag, "Frostweave Bag", "A magical bag from the Blood Elves.");

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
            
            string[] identsGem = {"Gem", "Enhancement"};
            _gem = new Item(identsGem,
                "Eye of Azeroth",
                "Doubles stamina in battlegrounds"
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
            Assert.AreSame(null, _bag.Locate("fail"));
        }

        [Test]
        public void TestBagFullDescription()
        {
            _bag.Inventory.Put(_weapon);
            _bag.Inventory.Put(_armour);
            _bag.Inventory.Put(_food);

            Assert.AreEqual(
                $"In the Netherweave Bag you can see:\n\tBig Friggin Gun (Weapon)\n\tIllidan's Plated Glory (Armour)\n\tKiwifruit Pie (Food)\n",
                _bag.FullDescription);
        }
        
        [Test]
        public void TestBagInBag()
        {
            _bag.Inventory.Put(_bagBag);
            _bagBag.Inventory.Put(_gem);
            Assert.AreSame(_bagBag, _bag.Locate("Frostweave Bag"));
            Assert.AreSame(_gem, _bagBag.Locate("Gem"));
            Assert.AreSame(null, _bag.Locate("Gem"));
        }
    }
}