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

        static int Scenarios = 3;
        //Character name
        static string CharacterName;


        static string[] PartOne = {

            #region Choice 1
            "You're strolling down your left path that you chose. You hear screaming coming from the distance off to the direction of the path on the right. You're extremely happy you chose the left path",
            "You're casually walking down your path and are suddenly ambushed by a group of bandits hiding behind the tree. They cut you to pieces and you die.",
            #endregion Choice 1

            #region Choice 2
            "You've chosen to help the child out by walking her the way you came. She gives out some kind of signal and you're suddenly surrounded by bandits waiting for her to bring their next victum. You've reached the end of your journey",
            "You choose to leave the girl behind and hope she can find her way back",
            #endregion Choise 2

            "After you leave the girl, you continue along your path and encounter an old building that looks abandon",
        };

        static string[] PartTwo = {

        };

        static string[] PartThree = {

        };


        //Print out game title and overview
        public static void StartGame()
        {
            GameTitle();
            NameCharacter();
            Choice();
            EndGame();

        }

        public static void EndGame()

        {
            Console.WriteLine("End of story text here.....");
            Console.WriteLine("Congratulations " + CharacterName + "!");
            Console.ReadLine();
            

        }

        static void Choice()
        {
            for (int section = 1; section <= Scenarios; section++)
            {
                string input = "";
                
                switch (section)
                {
                    case 1:
                        Console.WriteLine("You're walking down a forest path and come to a fork in the road. You have a decision to make. " + CharacterName + ", which path will you choose? Left or Right?");
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("Enter Your Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "left")
                        {
                            Console.WriteLine(PartOne[0]);
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine(PartOne[1]);
                            Console.ReadLine();
                            return;
                        }

                        Console.WriteLine("You reach the end of your path and are approched by a young child who tells you that she's lost her way." + CharacterName + ", Do you choose to help her or hope she finds her way? Help or Leave?");
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("Enter Your Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "help")
                        {
                            Console.WriteLine(PartOne[2]);
                            Console.ReadLine();
                            return;
                        }

                        else
                        {
                            Console.WriteLine(PartOne[3]);
                            Console.ReadLine();

                        }

                        Console.WriteLine(PartOne[4]);

                        break;



                    case 2:
                        Console.WriteLine(PartTwo[0]);
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("Enter Your Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[1]);
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine(PartTwo[2]);
                            Console.ReadLine();
                        }

                        Console.WriteLine(PartTwo[3]);

                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[4]);
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine(PartTwo[5]);
                            Console.ReadLine();

                        }

                        Console.WriteLine(PartTwo[6]);

                        break;



                    case 3:
                        Console.WriteLine(PartThree[0]);
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("Enter Your Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[1]);
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine(PartThree[2]);
                            Console.ReadLine();
                        }

                        Console.WriteLine(PartThree[3]);

                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[4]);
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine(PartThree[5]);
                            Console.ReadLine();

                        }

                        Console.WriteLine(PartThree[6]);

                        break;

                    default:
                        break;

                }
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void NameCharacter()

        {

            Console.WriteLine("What is your Characters name for this adventure? ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your name: ");
            CharacterName = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("Your name is confirmed to be " + CharacterName + ". Good luck!\n\n");
        }

        static void GameTitle()
        {
            string Title = @"ADVENTURE GAME";
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Title);
            Console.ResetColor();
            Console.WriteLine("Press enter to start");
            Console.ReadKey();
            Console.Clear();
        }
    }


    class Item { }

    class Program
    {
        static void Main(string[] args)
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
}