using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Graduate : IPerson, IDeveloper
    {
        public DateTime GraduationDate { get; set; }
        public string FirstName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string LastName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

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
