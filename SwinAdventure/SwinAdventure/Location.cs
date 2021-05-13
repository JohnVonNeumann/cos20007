using SwinAdventure.Abstract;

namespace SwinAdventure
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _items;
        private bool _playerInLocation;
        
        public Location(string name, string description, string[] ids) :
            base(name, description, ids)
        {
            _items = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _items.Fetch(id);
        }

        public Inventory Items
        {
            get
            {
                return _items;
            }
        }
    }
}