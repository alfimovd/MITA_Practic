using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mita.DataAccess;

namespace ADService.Model
{
    public class Transport : DomainObject
    {
        public string VIN { get; set; }
        public string BodyNumber { get; set; }
        public string EngimeNumber { get; set; }
        public string GearBox { get; set; }
        public int MileAge { get; set; }

        public Client Client { get; set; }
        public int ClientId { get; set; }

        public TransportModel Model { get; set; }
        public int ModelId { get; set; }
    }
}
