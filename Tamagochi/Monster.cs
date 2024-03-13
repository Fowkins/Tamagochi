using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    /// <summary>
    /// Класс Monster, хранящиий информацию о имени питомца, о состоянии его здоровья,
    /// о состоянии его уровня голода и об его уровня усталости
    /// </summary>
    class Monster
    {
        private string name;
        private int health;
        private int hunger;
        private int fatigue;
        private int happiness;

        /// <summary>
        /// Возвращает и задает имя питомца
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает уровень здоровья питомца
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает уровень голода питомца
        /// </summary>
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
                else if (value < 0)
                {
                    hunger = 0;
                }
                else
                {
                    hunger = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает уровень усталости питомца
        /// </summary>
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
                else if (value < 0)
                {
                    fatigue = 0;
                }
                else
                {
                    fatigue = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает уровень счастья питомца
        /// </summary>
        public int Happiness
        {
            get
            {
                return happiness;
            }
            set
            {
                if( value > 10)
                {
                    happiness = 10;
                }
                else if (value < 0)
                {
                    happiness = 0;
                }
                else
                {
                    happiness = value;
                }
            }
        }

        /// <summary>
        /// Конструктор класса Monster
        /// </summary>
        /// <param name="name">Имя питомца</param>
        public Monster(string name)
        {
            Name = name;
            Health = 10;
            Hunger = 0;
            Fatigue = 0;
            Happiness = 10;
        }

        /// <summary>
        /// Метод, рализующий кормление питомца
        /// </summary>
        public void Feed()
        {
            if (Hunger > 0)
            {
                Hunger--;
                Happiness++;
            }
            else
            {
                Health--;
                Happiness--;
            }
        }

        /// <summary>
        /// Метод, реализующий игру с питомцем
        /// </summary>
        public void Play()
        {
            Fatigue++;
            if (Fatigue == 10)
            {
                Health--;
                Hunger++;
                Happiness++;
            }

        }

        /// <summary>
        /// Метод, реализующий "укачивание"(сон) питомца
        /// </summary>
        public void Sleep()
        {
            Fatigue = 0;
            Health++;
            Hunger++;
            Happiness = Happiness + 2;
        }

        /// <summary>
        /// Метод, реализующий вывод статуса питомца
        /// </summary>
        public void Status()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Hunger: {Hunger}");
            Console.WriteLine($"Fatigue: {Fatigue}");
            Console.WriteLine($"Happiness: {Happiness}");
            Console.WriteLine();

        }

        /// <summary>
        /// Метод, позволяющий вылечить питомца при его заболевании
        /// </summary>
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
