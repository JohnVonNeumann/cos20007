using System;
using SwinAdventure.Abstract;

namespace SwinAdventure
{
    public class Bag : Item
    {
        private Inventory _inventory;
        
        public Bag(string[] ids, string name, string description) :
            base(ids, name, description)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }

        public string FullDescription
        {
            get
            {
                return "FullDescription";
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