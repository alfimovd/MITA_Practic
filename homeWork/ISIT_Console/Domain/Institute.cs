using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Institute
    {
        public event DeveloperLooserHandler RemoveLooserEvent;
        private static Random _rand = new Random();
        public Institute()
        {
            Manager = new EducationalControlManager
            {
                FirstName = "Повелитель",
                LastName = "Отдела"
            };
            Students = new List<Student>();
            Developers = new ObservableCollection<IDeveloper>();

            Developers.CollectionChanged += Manager.DevelopersChanged;
            RemoveLooserEvent += Manager.DevelopersRemoveLooserEvent;
            Manager.MessageEvent += ConsoleHelper.Message;
        }
        public string Title { get; set; }
        public EducationalControlManager Manager { get; set; }
        public ICollection<Student> Students { get; set; }
        public ObservableCollection<IDeveloper> Developers { get; set; }

        public void AddDeveloper(IDeveloper developer)
        {
            Developers.Add(developer);
        }

        public void RemoveDeveloper(IDeveloper developer)
        {
            Developers.Remove(developer);
        }

        public void PollStudentToDeveloper()
        {
            foreach (var student in Students)
            {
                if (student.IsWantEnterDeveloper())
                {
                    Manager.AcceptRequestEnter(student, this);
                }
            }
        }

        public void PollDeveloperToLeave()
        {
            foreach (var developer in Developers.ToList())
            {
                if (developer.IsWantLeaveDeveloper())
                {
                    Manager.AcceptRequestLeave(developer, this);
                }
            }
        }

        public void Session()
        {
            foreach (var developer in Developers)
            {
                developer.DevRating = _rand.Next(100);
            }
            PollDeveloperToLeave();
            AllocateLooser();
        }

        private void AllocateLooser()
        {
            var looser = Developers.OrderBy(o => o.DevRating).FirstOrDefault(); 
            if (RemoveLooserEvent != null) RemoveLooserEvent(looser, new EventArgs());
            Developers.Remove(looser);
        }
    }
}
