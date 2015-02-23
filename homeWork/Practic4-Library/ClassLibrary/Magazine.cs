using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Magazine : ILibraryItem
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public string GetPrint()
        {
            return String.Format("{0} - {1} ({2})", Code, Name, Number);
        }
    }
}
