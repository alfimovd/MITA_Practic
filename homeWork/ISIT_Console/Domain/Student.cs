using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Student : IPerson, IDeveloper
    {
        private static Random _rand = new Random();

        public string Specialty { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsWantEnterDeveloper()
        {
            return _rand.Next(100) <= 80; // вероятность 80%
        }

        public bool IsWantLeaveDeveloper()
        {
            return _rand.Next(100) <= 20; // вероятность 20%
        }

        public int DevRating { get; set; }

        public override string ToString()
        {
            return String.Format("Студент, {0} {1} ({2})",FirstName, LastName, Specialty);
        }
    }
}
