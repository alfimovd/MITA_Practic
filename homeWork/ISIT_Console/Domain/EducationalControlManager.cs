using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Domain
{
    public class EducationalControlManager : IPerson
    {
        public event MessageHandler MessageEvent;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void AcceptRequestEnter(IDeveloper student, Institute institute)
        {
            institute.AddDeveloper(student);
        }

        public void AcceptRequestLeave(IDeveloper student, Institute institute)
        {
            institute.RemoveDeveloper(student);
        }

        public string Notify(IDeveloper student, string notify)
        {
            var result = String.Format("{0} сообщает: {1} - {2}", this, student, notify);
            if (MessageEvent != null) 
                MessageEvent(this, new MessageEventArgs { Message = result });
            return result;
        }



        public void DevelopersChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Notify((IDeveloper) e.NewItems[0], "Зачислен на курсы повышения квалификации");
            }
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Notify((IDeveloper) e.OldItems[0], "Отчислен с курсов повышения квалификации");
            }
        }

        public void DevelopersRemoveLooserEvent(object sender, EventArgs e)
        {
            Notify((IDeveloper) sender, " Неуспевает по дополнительной специальности");
        }

        public override string ToString()
        {
            return String.Format("Менеджер, {0} {1}", FirstName, LastName);
        }
    }
}
