using System;
namespace AdventureGame {
    class Program {
        static void Main() {
            string CharacterName = "John Doe";
            Console.WriteLine("Welcome to Adventure Game");
            Console.WriteLine("What would you like your character's name to be?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Your character is now named " + CharacterName + "!");
            Console.ReadKey();
        }
    }
}
