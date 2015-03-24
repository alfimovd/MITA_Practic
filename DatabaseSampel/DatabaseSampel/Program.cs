using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSampel
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Db();
            var item = db.Items.FirstOrDefault();

            if (item == null)
            {
                item = new Item
                {
                    Name = "Item "+ DateTime.Now
                };
                db.Items.Add(item);
            }

            var child = new ChildItem
            {
                Name = "Child " + DateTime.Now,
                parent = item
            };
            db.ChildItems.Add(child);
            db.SaveChanges();
            Console.WriteLine("{0} - {1}", item.Id, item.Name);

            var latest = db.ChildItems.Include(ci => ci.parent).Where(ci => ci.Id > 2).ToArray();

            foreach (var it in latest)
            {
                Console.WriteLine("{0} - {1}", it.Id, it.Name);
            }
            Console.ReadLine();
        }
    }
}
