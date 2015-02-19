using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalLib
{
    public class Cat : Animal, ICloneable
    {
        static public int Count = 0;

        public Cat() : this("noname", DateTime.Now) { }

        public Cat(string name, DateTime date)
        {
            Name = name;
            _birthday = date;
            Count++;
        }

        public override void Pet()
        {
            int i = _rand.Next(10);
            if (i < 8)
                _Bite();
            else
                _Say();
        } 

        private void _Say() 
        {
            Console.WriteLine( Name + " мяукает");
        }


        public object Clone()
        {
            var cat = new Cat();
            cat._birthday = this._birthday;
            cat.Name = this.Name;
            cat.FavoriteToy = this.FavoriteToy;

            return cat;
        }

        public override string ToString()
        {
            return Name;
        } 
    }
}
