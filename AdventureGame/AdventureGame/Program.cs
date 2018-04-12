using System;

///Website to be used
///http://programmingisfun.com/learn/c-sharp-adventure-game/c_sharp_04_input/
///

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string CharacterName = "John Doe";
            Console.WriteLine("Adventure Game!");
            Console.WriteLine("Welcome to your Adventure!");
            Console.WriteLine("What would you like your character's name to be?");
            CharacterName = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("Great! Your character is now named " + CharacterName);
            Console.ReadLine();
        }
    }
}