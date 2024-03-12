﻿using System;

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tamagotchi!");
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

                switch(choice)
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
                        break;
                }

                if(monster.Health <= 0)
                {
                    Console.WriteLine("Your pet is sick!.");
                    Console.Write("Do you want to cure him?(Y/N): ");
                    Console.Write("\n");
                    string ch = Console.ReadLine();
                    switch (ch)
                    {
                        case "Y":
                            monster.Cure();
                            break;
                        case "N":
                            gameOver = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }
        }
    }
}