using System;

namespace SwinAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Swin Adventure!");
            Console.Write("Enter your player name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your player description: ");
            string description = Console.ReadLine();
            Player player = new Player(name, description);
            string[] identsGun = {"Weapon", "BFG", "Rocket Launcher"};

            Item weapon = new Item(identsGun,
                "Big Friggin Gun",
                "The biggest gun available in the game"
            );

            string[] identsArmour = {"Armour", "Platemail", "Heavy Armour"};
            Item armour = new Item(identsArmour,
                "Illidan's Plated Glory",
                "Tier 9 Epic Plate Mail"
            );

            player.Inventory.Put(weapon);
            player.Inventory.Put(armour);

            string[] identsBag = new[] {"bag", "backpack"};
            Bag bag = new Bag(identsBag, "Netherweave Bag", "A hand crafted elven bag.");

            player.Inventory.Put(bag);

            string[] identsConsumables = {"Food", "Consumable", "Health Regeneration"};
            Item food = new Item(identsConsumables,
                "Kiwifruit Pie",
                "Heals Player on consumption for 2000 hp over 12 seconds"
            );

            bag.Inventory.Put(food);

            Console.WriteLine("Type 'quit' to exit.");
            string[] choiceList = new[] {""};
            while (choiceList[0] != "quit")
            {
                LookCommand look = new LookCommand();
                Console.Write("Command - > ");
                string choice = Console.ReadLine();
                choiceList = choice.Split(" ");
                Console.Write(look.Execute(player, choiceList));
            }
        }
    }
}