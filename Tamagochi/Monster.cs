using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Monster
    {
        private string name;
        private int health;
        private int hunger;
        private int fatigue;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if(value > 10)
                {
                    health = 10;
                }
                else
                {
                    health = value;
                }
            }
        }

        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                if(value > 10)
                {
                    hunger = 10;
                }
                else
                {
                    hunger = value;
                }
            }
        }

        public int Fatigue
        {
            get
            {
                return fatigue;
            }
            set
            {
                if (value > 10)
                {
                    fatigue = 10;
                }
                else
                {
                    fatigue = value;
                }
            }
        }
        public Monster(string name)
        {
            Name = name;
            Health = 10;
            Hunger = 0;
            Fatigue = 0;
        }

        public void Feed()
        {
            if (Hunger > 0)
            {
                Hunger--;
            }
            else
            {
                Health--;
            }
        }

        public void Play()
        {
            Fatigue++;
            if (Fatigue == 10)
            {
                Health--;
                Hunger++;
            }

        }

        public void Sleep()
        {
            Fatigue = 0;
            Health++;
            Hunger++;
        }

        public void Status()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Hunger: {Hunger}");
            Console.WriteLine($"Fatigue: {Fatigue}");
            Console.WriteLine();

        }
        public void Cure()
        {
            if (Health <= 0)
            {
                Health = 5;
            }
            else 
            {
                Health--;
            }
        }

    }
}
