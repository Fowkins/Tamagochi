﻿using System;
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
                else
                {
                    fatigue = value;
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
        }

        /// <summary>
        /// Метод, рализующий кормление питомца
        /// </summary>
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
