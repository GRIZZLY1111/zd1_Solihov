using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_практика_cat
{
    class Cat
    {
        private string name;
        private double ves;
        //Сохраняем и читаем в приватную переменную
        public double Ves { get { return ves; }
            set
            {
                bool OnlyDigit = true;
                if (value > 0)
                {
                }
                else
                {
                    OnlyDigit = false;
                }
                if (OnlyDigit)
                {
                    ves = value;
                }
                else
                {
                    Console.WriteLine($"Неправильно введен вес");
                }
            }
        }
        //Сохраняем и читаем в приватную переменную
        public string Name { get { return name; }
            set
            {
                bool OnlyLetters = true;

                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        //Присваеваем значения коту
        public Cat(string CatName, double CatVes)
        {
            Name = CatName;
            Ves = CatVes;
        }
        //Информируем какой кот мяукает
        public void Meow()
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
        }
        //Даём полную информацию о коте
        public void CatInf()
        {
            Console.WriteLine($"Кота зовут {name}, а весит он {ves} киллограмм");
        }
    }
}
