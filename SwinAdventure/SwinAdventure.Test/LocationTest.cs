using NUnit.Framework;

namespace SwinAdventure.Test
{
    public class LocationTest
    {
        private Location _location;
        private Item _weapon;
        private Item _armour;
        private Item _food;

        [SetUp]
        public void Setup()
        {
            string[] identsLocation = {"North"};
            _location = new Location("North Location", "The direction of North", identsLocation);

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

            _location.Items.Put(_weapon);
            _location.Items.Put(_armour);
            _location.Items.Put(_food);
        }

        [Test]
        public void TestLocationIsIdentifiable()
        {
            Assert.True(_location.AreYou("North"));
        }
        
        [Test]
        public void TestLocationLocatesItems()
        {
            Assert.AreSame(_weapon, _location.Locate("Weapon"));
            Assert.AreSame(_armour, _location.Locate("Armour"));
            Assert.AreSame(_food, _location.Locate("Food"));
        }

        [Test]
        public void TestLocationLocatesItself()
        {
            Assert.AreSame(_location, _location.Locate("North"));
        }

        [Test]
        public void TestLocationLocatesNothing()
        {
            Assert.AreEqual(null, _location.Locate("West"));
        }

        [Test]
        public void TestLocationFullDescription()
        {
            Assert.AreEqual(
                "The direction of North",
                _location.FullDescription);
        }

        [Test]
        public void TestLocationName()
        {
            Assert.AreEqual("North Location", _location.Name);
        }
    }
}