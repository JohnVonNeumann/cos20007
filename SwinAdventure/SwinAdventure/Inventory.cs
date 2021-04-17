using System;
using System.Collections.Generic;

namespace SwinAdventure
{
    public class Inventory
    {
        private List<Item> _items = new List<Item>();
        
        public Inventory(){}

        public bool HasItem(string id)
        {
            throw new NotImplementedException();
        }

        public void Put(Item item)
        {
            throw new NotImplementedException();
        }

        public Item Take(string id)
        {
            throw new NotImplementedException();
        }

        public Item Fetch(string id)
        {
            throw new NotImplementedException();
        }

        public string ItemList
        {
            get
            {
                return "Item List";
            }
        }
        
    }
}