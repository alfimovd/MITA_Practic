using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using ADService.DataAccess;
using ADService.DataAccess.Model;

namespace ADService.RecreateDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check DB exists...");
            if (Database.Exists("ADServiceDb"))
            {
                Console.WriteLine("DB exists. Deleting...");
                Database.Delete("ADServiceDb");
            }
            else
            {
                Console.WriteLine("DB does not exist. Skip deleting.");
            }

            using (var db = new Db())
            {
                Console.WriteLine("Creating DB..");
                // Наполнение
                var transports = db.Transports.ToArray();
                db.SaveChanges();
                Console.WriteLine("Done");
                Console.ReadLine();
            }
        }
    }
}
