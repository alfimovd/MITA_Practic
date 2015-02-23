using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary;

namespace Practic4_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            library.LibraryItems = new List<ILibraryItem>()
            {
                new Book()
                {
                    Name = "Понедельник начинается в субботу",
                    Author = "А. Б. Стругацкие",
                    Code = "271"
                },
                new Book()
                {
                    Name = "C# 4.0. Полное руководство",
                    Author = "Герберт Шилдт",
                    Code = "845"
                },
                new Book()
                {
                    Name = "Паттерны программирования",
                    Author = "«Банда четырёх»: Эрих Гамма, Ричард Хелм, Ральф Джонсон, Джон Влиссидс",
                    Code = "255"
                },
                new Magazine()
                {
                    Name = "Top Gear",
                    Number = 1,
                    Code = "791"
                },
                new Magazine()
                {
                    Name = "Top Gear",
                    Number = 2,
                    Code = "511"
                }
            };
           
            library.RegReader("Dima");
            library.RegReader("Uliana");

            Console.WriteLine("Введите ваше имя: ");
            var name = Console.ReadLine();
            var reader = library.FindReader(name);
            if (reader==null)
                reader = library.RegReader(name);
            Boolean exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Элементы в библиотеке: ===");
                library.PrintLibItems( library.LibraryItems );
                Console.WriteLine("=== Элементы в на руках: ===");
                library.PrintLibItems( library.GetReadingItems(reader) );
                Console.WriteLine("=== Введите код книги или exit: ");
                var code = Console.ReadLine();
                if (code == "exit")
                {
                    exit = true;
                }
                else
                {
                    if (!library.ReadingItems[reader].Any(r => r.Code == code))
                    {
                        library.TakeItem(code, reader);
                    }
                    else
                    {
                        library.RecieveItem(code, reader);
                    }
                } 
            }
        }
    }
}
