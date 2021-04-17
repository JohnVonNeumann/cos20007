using System;
using SwinAdventure.Abstract;

namespace SwinAdventure
{
    public class Bag
    {
        private Inventory _inventory;
        
        public Bag(string[] ids, string name, string description)
        {
            throw new NotImplementedException();
        }

        public GameObject Locate(string id)
        {
            throw new NotImplementedException();
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