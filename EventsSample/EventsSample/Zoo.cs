using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Timers;

namespace EventsSample
{
    class Zoo
    {
        private Timer _timer;
        private Emploee _emploee;
        private static Random _rand = new Random();

        public Zoo()
        {
            _emploee = new Emploee();
            Animals = new ObservableCollection<Animal>();
            Animals.CollectionChanged += Animal_CollectionChanged;

            _timer = new Timer(1000);
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();
        }

        private void Animal_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                var animal = (Animal) e.NewItems[0];
                MedicalComission(animal);
            }
        }

        public ObservableCollection<Animal> Animals { get; private set; }

        private void MedicalComission(Animal animal)
        {
            animal.Health = _rand.Next(100,500);
            animal.StarvingLevel = 0;
            animal.Starving += animal_Starving;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (var animal in Animals)
            {
                animal.StarvingLevel += 10;
            }
        }

        void animal_Starving(object sender, EventArgs e)
        {
            _emploee.Feed((Animal)sender);
        }
    }
}
