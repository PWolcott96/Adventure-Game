using System;

/*Website to be used
Produced by Parker Wolcott
Last Updated Apr. 12 2018
http://programmingisfun.com/learn/c-sharp-adventure-game/

    Current Spot
    http://programmingisfun.com/learn/c-sharp-adventure-game/c_sharp_07_conditional_statements/
*/

namespace AdventureGame
{
    public static class Game {
        //Character name
        static string CharacterName = "John Doe";


        //Print out game title and overview
        public static void StartGame()
        {
            Console.WriteLine("Adventure Game!");
            Console.WriteLine("Welcome to your Adventure!");
            NameCharacter();
        }


        //Ask player for a name and save it
        static void NameCharacter()
        {
            Console.WriteLine("What would you like your character's name to be?");
            CharacterName = Console.ReadLine();

            Console.WriteLine("Great! Your character is now named " + CharacterName);
            Console.WriteLine("Welcome, " + CharacterName + ", and good luck!\n\n");
        }

        //original Dialog method
        public static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }


    class Item { }

    class Program
    {
        static void Main(string[] args)
        {
            Game.StartGame();
            Console.ReadKey();

            Console.Write("A stranger approaches. Clearing their throat to get your attention, they ask \n");
            Game.Dialog("Have you seen a strange creature around here? \nAbout three feet high, greenish, with fluffy hair? \n");
            Console.Write("How do you answer? 1) Yes, 2) No, 3) Repeat the question, 4) Keep walking\n");
            Console.ReadLine();
        }
    }
}