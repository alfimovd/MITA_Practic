using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSampel
{
    class Db : DbContext
    {
        static Db()
        {
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<Db, Migrations.Configuration>());   
        }

        public IDbSet<Item> Items { get; set; }
        public IDbSet<ChildItem> ChildItems { get; set; } 
    }
}
