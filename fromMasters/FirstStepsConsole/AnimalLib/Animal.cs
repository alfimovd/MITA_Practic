using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLib
{
    public abstract class Animal : Object
    {
        public static int Count = 0;

        public Animal()
        {
            Count++;
        }

        protected DateTime _birthday = DateTime.Now;
        public string Name { get; protected set; }
        public Toy FavouriteToy { get; set; }

        /// <summary>
        /// Возраст кошки в минутах.
        /// Вычисляемое поле.
        /// </summary>
        public double Age
        {
            get
            {
                return (DateTime.Now - _birthday).TotalMinutes;
            }
        }

        /// <summary>
        /// Укусить.
        /// Закрытый метод.
        /// </summary>
        protected void Bite()
        {
            Console.WriteLine(Name + " кусает");
        }

        /// <summary>
        /// Погладить.
        /// Публичный метод. 
        /// </summary>
        public abstract void Pet();

        public virtual string WhatYouSay()
        {
            return "...";
        }
    }
}
