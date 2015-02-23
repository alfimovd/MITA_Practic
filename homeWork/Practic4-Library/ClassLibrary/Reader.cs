using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Reader : IPrintable
    {
        public Reader(string name)
        {
            Name = name;
            RegistrationDate = DateTime.Now;
        }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; private set; }

        public string GetPrint()
        {
            return String.Format("{0} - {1}", Name, RegistrationDate.ToString());
        }
    }
}
