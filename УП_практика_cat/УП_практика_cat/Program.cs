using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_практика_cat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проверяем на правильный ввод
            try
            {
                Console.WriteLine("Дайте коту имя");
                //Создаем кота и пользователь задает ему имя
                Cat murzik = new Cat(Convert.ToString(Console.ReadLine()), 5);
                Console.WriteLine("Присвойте Барсику вес");
                //Создаем кота и пользователь задает ему вес
                Cat barsik = new Cat("Барсик", Convert.ToDouble(Console.ReadLine()));
                //Смотрим информацию о котах
                barsik.Meow();
                barsik.CatInf();
                murzik.Meow();
                murzik.CatInf();
                Console.WriteLine("Поменяйте имя Барсика");
                //Меняем имя второму коту
                barsik.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine($"Измените вес {murzik.Name}у");
                //Меняем вес первому коту
                murzik.Ves = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Невернный ввод");
            }
            Console.ReadKey();
        }
    }
}
