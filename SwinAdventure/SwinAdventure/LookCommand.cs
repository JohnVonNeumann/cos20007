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
            throw new NotImplementedException();
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