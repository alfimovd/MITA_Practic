using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReflectionParser
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMaxTry();
            EnumTry();
        }

        static void MinMaxTry()
        {
            var intArr = new[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            int min, max;
            intArr.MinMax<int>(out min, out max);
        }

        // Warning для компилятора 
        [Obsolete("Not use this metod")]
        static void EnumTry()
        {
            var obj = new ObjectDescription();
            obj.State = ObjectState.Active;
            obj.State = ObjectState.Closed;
            //obj.State = ObjectState.Super;

            //obj.intState = 100000000000000;
            //obj.strState = "bla bla";

            switch (obj.State)
            {
                case ObjectState.Active:
                    break;
                case ObjectState.Closed:
                    break;
                case ObjectState.Removed:
                    break;
                case ObjectState.Hided:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string GetDisplayString(ObjectState state)
        {
            Type type = typeof(ObjectState);
            FieldInfo fieldInfo = type.GetField(state.ToString());
            object attr = fieldInfo.GetCustomAttributes(typeof(EnumDisplayStringAttribyte), false).FirstOrDefault();
            var dispAttr = (EnumDisplayStringAttribyte) attr;

            if (attr == null)
            {
                return state.ToString();
            }

            return dispAttr.DisplayString;

        }

    }
}
