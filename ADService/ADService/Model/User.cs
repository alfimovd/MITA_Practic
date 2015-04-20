using System;
using System.ComponentModel.DataAnnotations;
using ADService.Model;
using Microsoft.Build.Framework;
using Mita.DataAccess;

namespace BookStore.DataAccess.Model
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
