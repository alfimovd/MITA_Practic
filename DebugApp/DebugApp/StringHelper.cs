using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebugApp
{
    public static class StringHelper
    {
        // мы расширяем клас string методом ToInt
        public static int ToInt(this string str)
        {
            try
            {
                var i = int.Parse(str);
                return i;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
