using System;
using System.Threading;

namespace ScoreManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerCount = 0;

            string name1 = "";
            string name2 = "";
            string name3 = "";

            int player1Score = 0;
            int player2Score = 0;
            int player3Score = 0;
            
            bool isWithin(double min, double max)
            {
                return playerCount >= min && playerCount <= max;
            }

            string dashes = "---------------------------------------------------------------";

            void PromptDirectory()
            {
                if (isWithin(1, 3))
                {
                    Console.WriteLine("Welcome to the main directory. Here is a list of commands.");
                    Console.WriteLine("/table           /exit           /directory\n/++point         /--point");
                }
            }
            
            string command = "";
            string nameInput = "";

            Console.WriteLine(dashes);
            Console.WriteLine("Welcome to the Scoreboard. Press enter.");
            Console.ReadKey();
            Console.WriteLine(dashes);
            Console.WriteLine("How many players are involved? Enter a number.| Max Capacity: 3");
            playerCount = Int32.Parse(Console.ReadLine());

            Console.WriteLine(dashes);
            Console.WriteLine("Enter the names of the players.");
            switch (playerCount)
            {
                case 1:
                    name1 = Console.ReadLine();
                    break;

                case 2:
                    name1 = Console.ReadLine();
                    Console.WriteLine("and");
                    name2 = Console.ReadLine();
                    break;

                case 3:
                    name1 = Console.ReadLine();
                    Console.WriteLine("and");
                    name2 = Console.ReadLine();
                    Console.WriteLine("and");
                    name3 = Console.ReadLine();
                    break;
                
                default:
                    Console.WriteLine(dashes);
                    Console.WriteLine("Input is invalid. Is your integer out of bounds?");
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine(dashes);
            PromptDirectory();

            while (1 == 1)
            {
                command = Console.ReadLine();

                switch (command)
                {
                    case "/directory":
                        PromptDirectory();
                        break;

                    case "/table":
                        Console.WriteLine(dashes);
                        if (playerCount == 1)
                        {
                            Console.WriteLine(name1 + ": " + player1Score);
                        }

                        else if (playerCount == 2)
                        {
                            Console.WriteLine(name1 + ": " + player1Score);
                            Console.WriteLine(name2 + ": " + player2Score);
                        }
                        else
                        {
                            Console.WriteLine(name1 + ": " + player1Score);
                            Console.WriteLine(name2 + ": " + player2Score);
                            Console.WriteLine(name3 + ": " + player3Score);
                        }

                        break;
                    
                    case "/++point":
                        Console.WriteLine(dashes);
                        Console.WriteLine("Increase whose score?");
                        nameInput = Console.ReadLine();
                        Console.WriteLine(dashes);
                        
                        if (nameInput == name1)
                        {
                            player1Score++;
                            Console.WriteLine("Point has been added to " + name1 + '.');
                        }
                        else if (nameInput == name2)
                        {
                            player2Score++;
                            Console.WriteLine("Point has been added to " + name2 + '.');
                        }
                        else if (nameInput == name3)
                        {
                            player3Score++;
                            Console.WriteLine("Point has been added to " + name3 + '.');
                        }
                        else
                        {
                            Console.WriteLine("That player name cannot be found.");
                        }

                        break;

                    case "/--point":
                        Console.WriteLine(dashes);
                        Console.WriteLine("Subtract whose score?");
                        nameInput = Console.ReadLine();

                        if (nameInput == name1)
                        {
                            player1Score--;
                            Console.WriteLine("Taken point away from " + name1 + '.');
                        }
                        else if (nameInput == name2)
                        {
                            player2Score--;
                            Console.WriteLine("Taken point away from " + name2 + '.');
                        }
                        else if (nameInput == name3)
                        {
                            player3Score--;
                            Console.WriteLine("Taken point away from " + name3 + '.');
                        }
                        else
                        {
                            Console.WriteLine("That player name cannot be found.");
                        }

                        break;
                    
                    case "/exit":
                        Console.WriteLine("Terminating application...");
                        for (int i = 1; i < 4; i++)
                        {
                            Thread.Sleep(1000);

                            switch (i)
                            {
                                default:
                                    Console.WriteLine(i + "...");
                                    break;

                                case 3:
                                    Console.WriteLine(i);
                                    break;
                            }
                        }

                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine(dashes);
                        Console.WriteLine("Command path is invalid. Locate commands using /directory.");
                        break;
                }
            }
        }
    }
}