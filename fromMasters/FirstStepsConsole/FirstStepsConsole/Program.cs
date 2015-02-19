using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalLib;

namespace FirstStepsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //new DateTime();


            //Console.WriteLine("How many bugs?");
            //string countStr = Console.ReadLine();

            //int count = int.Parse(countStr);

            //if (count >= 1 && count <= 25)
            //{
            //    for (int i = 0; i < count; i++)
            //    {
            //        var s = string.Format("Было в проекте {0} багов, один исправили, осталось {1} багов", count - i, count - i - 1);
            //        Console.WriteLine(s);
            //    }
            //}
            //else if (count < 1)
            //{
            //    Console.WriteLine("Bad testing");
            //}
            //else
            //{
            //    Console.WriteLine("Project is failed");
            //}


            //Console.WriteLine(Cat.Count);
            //Console.WriteLine(Animal.Count);
            //var cat = new Cat();
            //Console.WriteLine(Animal.Count);
            //Console.WriteLine(Cat.Count);

            //var cat1 = new Cat("Cat", new DateTime(1999, 1, 1));
            //Console.WriteLine(Animal.Count);
            //Console.WriteLine(Cat.Count);

            //var dog = new Dog();
            //Console.WriteLine(Animal.Count);
            //Console.WriteLine(Cat.Count);

            //for (int i = 0; i < 10; i++)
            //{
            //    cat1.Pet();
            //}

            //Console.WriteLine(cat.WhatYouSay());
            //Console.WriteLine(dog.WhatYouSay());







            var firstCat = new Cat("Catterpiller", DateTime.Now);
            var secondCat = (Cat)(firstCat.Clone());
            var thirdCat = firstCat;
            
            Console.WriteLine(firstCat.ToString());
            secondCat.FavouriteToy = new Toy() { Name = "Toy2" };

            Console.ReadLine();

        }
    }
}
