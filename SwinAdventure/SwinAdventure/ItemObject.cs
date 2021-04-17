using SwinAdventure.Abstract;

namespace SwinAdventure
{
    public class ItemObject : GameObject
    {

        public ItemObject(string[] idents, string name, string desc) : base(name, desc, idents)
        {
            
        }
    }
}