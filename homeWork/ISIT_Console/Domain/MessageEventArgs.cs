using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
