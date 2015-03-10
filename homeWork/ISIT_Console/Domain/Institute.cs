using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Institute
    {
        public EducationalControlManager Manager { get; set; }
        public ICollection<Student> Students { get; private set; }
        public ICollection<IDeveloper> Developers { get; private set; }

        public void Session()
        {
            
        }
    }
}
