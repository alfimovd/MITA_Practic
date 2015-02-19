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
                Wag();
            else
                _Bite();
        }

        public void Wag()
        {
            var s = string.Format("{0} виляет хвостом ", Name);
            Console.WriteLine(s);
        }
    }
}
