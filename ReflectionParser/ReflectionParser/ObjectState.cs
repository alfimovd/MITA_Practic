using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionParser
{
    public enum ObjectState
    {
        [EnumDisplayStringAttribyte(DisplayString = "Active")]
        Active,
        [EnumDisplayStringAttribyte(DisplayString = "Closed")]
        Closed,
        [EnumDisplayStringAttribyte(DisplayString = "Removed")]
        Removed,
        [EnumDisplayStringAttribyte(DisplayString = "Hided")]
        Hided
    }
}
