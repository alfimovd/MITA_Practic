using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public static class ConsoleHelper
    {
        public static void Message(object sender, MessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
