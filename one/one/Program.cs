using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalLib;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Количество багов в проекте: ");
            //string countStr =  Console.ReadLine();
            //int count = int.Parse(countStr);

            //if (count > 1 && count < 25)
            //{
            //    for (int i = 0; i < count; i++)
            //    {
            //        string s = "Было {0} багов, один исправили, осталось {1} багов"; 
            //        Console.WriteLine(s, count-i, count-i-1);
            //    }
            //}
            //else if (count <= 1)
            //{
            //    Console.WriteLine("Плохо тестируете");
            //}
            //else
            //{
            //    Console.WriteLine("Проект обречен");
            //}
            //Console.ReadLine();

            var cat = new Cat("Runa", new DateTime(2013, 8, 31));
            var cat2 = (Cat)(cat.Clone());
            var cat3 = cat;
            var dog = new Dog();

            Console.WriteLine(cat.Equals(cat2));
            Console.WriteLine(cat.Equals(cat3));
            Console.WriteLine(cat.ToString());

            Console.ReadLine();
        }
    }
}
