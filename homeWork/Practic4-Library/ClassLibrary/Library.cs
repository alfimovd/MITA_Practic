using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Library
    {
        public Library()
        {
            Readers = new List<Reader>();
            LibraryItems = new List<ILibraryItem>();
            ReadingItems = new Dictionary<Reader, List<ILibraryItem>>();
        }
        public List<Reader> Readers { get; set; }
        public List<ILibraryItem> LibraryItems { get; set; }
        public Dictionary<Reader, List<ILibraryItem>> ReadingItems { get; set; }

        public Reader FindReader(string name)
        {
            return Readers.FirstOrDefault(r => r.Name == name);
        }

        public Reader RegReader(string name)
        {
            var reader = new Reader(name);
            Readers.Add(reader);
            ReadingItems.Add(reader, new List<ILibraryItem>());
            return reader;
        }

        public List<ILibraryItem> GetAllItems()
        {
            return LibraryItems;
        }


        public List<ILibraryItem> GetReadingItems(Reader reader)
        {
            return ReadingItems.FirstOrDefault(i => i.Key == reader).Value;
        }

        public void TakeItem(string itemCode, Reader reader)
        {
            var item = LibraryItems.FirstOrDefault(i => i.Code == itemCode);
            LibraryItems.Remove(item);
            ReadingItems[reader].Add(item);
        }

        public void RecieveItem(string itemCode, Reader reader)
        {
            var item = ReadingItems[reader].FirstOrDefault(i => i.Code == itemCode);
            LibraryItems.Add(item);
            GetReadingItems(reader).Remove(item);
        }

        public void PrintLibItems(List<ILibraryItem> toPrint)
        {
            if (toPrint != null)
            {
                foreach (var print in toPrint)
                {
                    Console.WriteLine(print.GetPrint());
                }
            }
            else
            {
                Console.WriteLine("Элементов нет");
            }
        }


    }
}
