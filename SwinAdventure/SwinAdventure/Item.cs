using SwinAdventure.Abstract;

namespace SwinAdventure
{
    public class Item : GameObject
    {

        public Item(string[] idents, string name, string desc) : base(name, desc, idents)
        {
            
        }
    }
}