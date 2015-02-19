using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLib
{
    public class Cat : Animal, ICloneable
    {
        public static int Count = 0;

        public Cat()
            : this("noname", DateTime.Now)
        {

        }

        public override string ToString()
        {
            return Name;
        }

        public Cat(string name, DateTime bd)
        {
            Name = name;
            _birthday = bd;
            Count++;
        }

        /// <summary>
        /// Мяукнуть.
        /// Закрытый метод.
        /// </summary>
        private void Nya()
        {
            Console.WriteLine(Name + " мяукает");
        }

        static Random _rnd = new Random();
        public override void Pet()
        {
            if (_rnd.Next(0, 10) < 5)
            {
                Nya();
            }
            else
            {
                Bite();
            }
        }

        public object Clone()
        {
            var cat = new Cat();
            cat._birthday = this._birthday;
            cat.Name = this.Name;
            cat.FavouriteToy = this.FavouriteToy;

            return cat;
        }
    }
}
