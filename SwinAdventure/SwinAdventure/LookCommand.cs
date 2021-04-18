using System;
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
            if (text.Length != (3 | 5))
            {
                return "I don't know how to look like that";
            }

            return "Success";
        }

        public IHaveInventory FetchContainer(Player p, string containerId)
        {
            throw new NotImplementedException();
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            throw new NotImplementedException();
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