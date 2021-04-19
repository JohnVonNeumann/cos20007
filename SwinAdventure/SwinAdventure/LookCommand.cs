using System;
using System.Linq;
using SwinAdventure.Abstract;

namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand() : base(ids: new string[]{"look"})
        {
        }

        public override string Execute(Player p, string[] text)
        {
            if (!new[] {3, 5}.Contains(text.Length))
            {
                return "I don't know how to look like that";
            }

            if (text[0] != "look")
            {
                return "Error in look input";
            }

            if (text[1] != "at")
            {
                return "What do you want to look at?";
            }

            if (text.Length == 5)
            {
                if (text[3] != "in")
                {
                    return "What do you want to look in?";
                }
            }

            if (text.Length == 3)
            {
                string itemToFind = text[2];
                return LookAtIn(itemToFind, p as IHaveInventory);
            }

            if (text.Length == 5)
            {
                string itemToFind = text[2];
                string placeToLookIn = text[4];
                IHaveInventory container = FetchContainer(p, placeToLookIn);
                return LookAtIn(itemToFind, container);
            }

            return "Success";
        }

        public IHaveInventory FetchContainer(Player p, string containerId)
        {
            if (p.AreYou(containerId))
            {
                return p;
            }

            return p.Locate(containerId) as IHaveInventory;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
            {
                return container.Locate(thingId).FullDescription;
            }

            return $"I can't find the {thingId}";
        }
        
    }

    public interface IHaveInventory
    {
        public GameObject Locate(string id);

        public string Name
        {
            get;
        }
    }
    
}