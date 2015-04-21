using System;
using System.ComponentModel.DataAnnotations;
using ADService.DataAccess.Model;
using Mita.DataAccess;

namespace ADService.DataAccess.Model
{
    public class User : DomainObject
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime LastLoginTime { get; set; }

        [Required]
        public Manager Manager { get; set; }

        public Role Role { get; set; }
    }
}
