using SwinAdventure.Abstract;

namespace SwinAdventure
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _location;
        private bool _playerInLocation;
        
        public Location(string name, string description, string[] ids) :
            base(name, description, ids)
        {
            _location = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _location.Fetch(id);
            
        }
    }
}