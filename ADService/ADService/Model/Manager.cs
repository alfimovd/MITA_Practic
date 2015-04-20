﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DataAccess.Model;
using Mita.DataAccess;

namespace ADService.Model
{
    public class Manager : FullNamedDomainObject
    {
        public User User { get; set; }

    }
}