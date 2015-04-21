using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mita.DataAccess;

namespace ADService.DataAccess.DataAccess.Model
{
    public class Transport : DomainObject
    {
        public string VIN { get; set; }
        public string BodyNumber { get; set; }
        public string EngimeNumber { get; set; }
        public string GearBox { get; set; }
        public int MileAge { get; set; }
        //владелец 
        public Client Client { get; set; }
        public int ClientId { get; set; }
        //модель
        public TransportModel Model { get; set; }
        public int ModelId { get; set; }
        // многие ко многим 
        public virtual ICollection<Component> Components { get; set; }

        public Transport()
        {
            Components = new List<Component>();
        }
    }
}
