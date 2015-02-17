using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalLib
{
    public class Dog : Animal
    {
        public override void Pet()
        {
            if (_rand.Next(0, 10) < 8)
                _Wag();
            else
                _Bite();
        }

        protected void _Wag()
        {
            var s = string.Format("{0} виляет хвостом ", Name);
            Console.WriteLine(s);
        }
    }
}
