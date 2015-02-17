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

            Console.WriteLine(Cat.Count);
            var cat = new Cat("Runa", new DateTime(2013, 8, 31));
            Console.WriteLine(Cat.Count);
            Console.WriteLine(Animal.Count);

            var cat2 = new Cat();
            Console.WriteLine(Cat.Count);
            Console.WriteLine(Animal.Count);

            var dog = new Dog();
            Console.WriteLine(Cat.Count);
            Console.WriteLine(Animal.Count);
            for (int i = 0; i < 10; i++)
            {
                cat.Pet();
                cat2.Pet();
                dog.Pet();
            }
            Console.ReadLine();
        }
    }
}
