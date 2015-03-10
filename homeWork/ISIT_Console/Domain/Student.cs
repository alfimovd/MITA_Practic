using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Student : IPerson, IDeveloper
    {
        public string Specialty { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void ApplyDeveloper(Institute institute)
        {
            throw new NotImplementedException();
        }

        public bool AnswerQuestion(string question)
        {
            throw new NotImplementedException();
        }

        public void LeaveDeveloper(Institute institute)
        {
            throw new NotImplementedException();
        }

        public int DevRating { get; set; }
    }
}
