using System;

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############################");
            Console.WriteLine("#                          #");
            Console.WriteLine("#  Welcome to Tamagotchi!  #");
            Console.WriteLine("#                          #");
            Console.WriteLine("############################");
            Console.WriteLine("You've just adopted a virtual pet!");
            Console.Write("\n     ########\n ####        ##\n#       ##    ##  \n#              ##\n#              ##\n##########     ##\n    ##           ##\n    ##             ####\n      ########         ##\n             #           ##\n             #             ##\n              ##            ##\n           ##      #  ##      ##\n           ##   ####  ##        ####\n           #####    ##        #     ##\n                    ##        #       ##\n                    ##        #####   ##\n                  ############     #####     \n                                  \n");
            Console.WriteLine("Take care of your pet by feeding, playing, and letting it sleep.");
            Console.WriteLine("But be careful, neglecting your pet's needs can lead to sickness!");
            Console.Write("Enter pet name: ");
            string petName = Console.ReadLine();
            Monster monster = new Monster(petName);
            bool gameOver = false;

            while (!gameOver)
            {
                Console.Clear();
                monster.Status();
                bool validChoice = false;

                while (!validChoice)
                {
                    Console.WriteLine("Choose an action:");
                    Console.WriteLine("1. Feed");
                    Console.WriteLine("2. Play");
                    Console.WriteLine("3. Sleep");
                    Console.WriteLine("4. Quit");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();
                    Console.Write("\n");
                    switch (choice)
                    {
                        case "1":
                            monster.Feed();
                            validChoice = true;
                            break;
                        case "2":
                            monster.Play();
                            validChoice = true;
                            break;
                        case "3":
                            monster.Sleep();
                            validChoice = true;
                            break;
                        case "4":
                            gameOver = true; 
                            validChoice = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            Console.Write("\n");
                            break;
                    }
                }

                if(monster.Health <= 0)
                {
                    bool validResponse = false;
                    while (!validResponse)
                    {
                        Console.WriteLine("Your pet is sick!.");
                        Console.Write("Do you want to cure him?(Y/N): ");
                        string ch = Console.ReadLine();
                        Console.Write("\n");
                        switch (ch)
                        {
                            case "Y" or "y":
                                monster.Cure();
                                validResponse = true;
                                break;
                            case "N" or "n":
                                gameOver = true;
                                validResponse = true;
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                Console.Write("\n");
                                break;
                        }
                    }
 
                }

                if (gameOver)
                {
                    Console.WriteLine("Game over!");
                }
            }
        }
    }
}
