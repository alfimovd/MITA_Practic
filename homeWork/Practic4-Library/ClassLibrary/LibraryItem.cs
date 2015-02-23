using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public interface ILibraryItem : IPrintable
    {
        string Code { get; set; }
        string Name { get; set; }
    }
}
