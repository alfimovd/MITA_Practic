using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsSample
{
    public class Animal
    {
        public string Name { get; set; }
        public int Health { get; set; }
        private int _starvinglevel;
        public int StarvingLevel {
            get
            {
                return _starvinglevel;
            }
            set
            {
                _starvinglevel = value;
                if (_starvinglevel >= Health)
                {
                    if (Starving != null) Starving(this, new EventArgs());
                }
            }
        }

        public event AnimalStarvingEventHandler Starving;
    }
}
