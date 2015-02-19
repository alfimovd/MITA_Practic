using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalLib
{
    public abstract class Animal
    {
        public Animal() 
        {
            Count++;
        }

        static public int Count = 0;

        static protected Random _rand = new Random();

        protected DateTime _birthday = DateTime.Now;

        public string Name { get; protected set; }

        public double Age 
        {
            get
            {
                return (DateTime.Now - _birthday).TotalDays;
            }
        }
        public Toy FavoriteToy { get; set; }

        public abstract void Pet();

        protected void _Bite()
        {
            Console.WriteLine( Name + " кусает");
        }

        public virtual void WhatYouSay()
        {
            Console.WriteLine("...");
        }
    }
}
