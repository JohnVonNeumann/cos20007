using System;
using SwinAdventure.Abstract;

namespace SwinAdventure
{
    public class Player : GameObject
    {
        private Inventory _inventory;

        public Player(string name, string description) :
            base(name, description, new[] {"me", "inventory"})
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            return _inventory.Fetch(id);
        }

        public override string FullDescription
        {
            get
            {
                return $"You are carrying:\n" + _inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
    }
}