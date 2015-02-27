using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositorySample
{
    class Program
    {
        static IRepository<User> repository = new MemoryRepository<User>();
        static void Main(string[] args)
        {
            repository.Add(new User { Email = "ul@mail.ru", Name = "user1" });
            repository.Add(new User { Email = "ul2@mail.ru", Name = "user2" });
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            User user = repository.GetAll()
                .FirstOrDefault(u => u.Name == name);
            if (user != null)
            {
                Console.WriteLine("Welcome: {0}", user.Name);
            }
            else
            {
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                user = new User
                {
                    Name = name,
                    Email = email,
                    Registration = DateTime.Now
                };
                repository.Add(user);
                Console.WriteLine("New user, id = {0}", user.id);
            }

            user = repository.Find(user.id);
            repository.Remove(user);

            foreach (User ul in repository.GetAll())
            {
                Console.WriteLine("{0} {1} {2}", ul.id, ul.Name, ul.Email);
            }
            Console.ReadLine();
        }
    }
}
