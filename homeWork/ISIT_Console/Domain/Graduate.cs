using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Graduate : IPerson, IDeveloper
    {
        public DateTime GraduationDate { get; set; }
        public Institute Institute { get; set; }

        public bool IsWantEnterDeveloper()
        {
            return true;
        }

        public bool IsWantLeaveDeveloper()
        {
            return false;
        }

        public int DevRating { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("Выпускник: {0} {1} ({3}, {2})", FirstName, LastName, Institute.Title, GraduationDate);
        }
    }
}
