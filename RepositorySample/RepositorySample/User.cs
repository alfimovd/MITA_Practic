using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositorySample
{
    class User : IDomainObject
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Registration { get; set; }
    }
}
