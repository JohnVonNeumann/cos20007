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
            foreach (var t in _items)
            {
                if (t.FirstId == id)
                {
                    return true;
                }
            }

            return false;
        }

        public void Put(Item item)
        {
            _items.Add(item);
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