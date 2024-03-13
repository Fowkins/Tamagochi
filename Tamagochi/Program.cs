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
                monster.Status();
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Sleep");
                Console.WriteLine("4. Quit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                Console.Write("\n");
                bool fl = false;

                switch (choice)
                {
                    case "1":
                        monster.Feed();
                        break;
                    case "2":
                        monster.Play();
                        break;
                    case "3":
                        monster.Sleep();
                        break;
                    case "4":
                        gameOver = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        Console.Write("\n");
                        break;
                }

                if(monster.Health <= 0)
                {
                    while (!fl)
                    {
                        Console.WriteLine("Your pet is sick!.");
                        Console.Write("Do you want to cure him?(Y/N): ");
                        string ch = Console.ReadLine();
                        Console.Write("\n");
                        switch (ch)
                        {
                            case "Y" or "y":
                                monster.Cure();
                                fl = true;
                                break;
                            case "N" or "n":
                                gameOver = true;
                                fl = true;
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
