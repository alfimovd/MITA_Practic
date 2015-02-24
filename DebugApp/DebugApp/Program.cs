using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = str.ToInt();
            var rand = new Random();
            var dateList = new List<DateTime>();

            for (int i = 0; i < count; i++)
            {
                var r = rand.Next();
                dateList.Add(DateTime.Now.AddMinutes(r));
            }

        }
    }
}
