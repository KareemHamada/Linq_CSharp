using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class StringHelper
    {
        public static string ChageFirstLetterCase(this string str)
        {
            if (str.Length == 0)
                return str;

            char[] strChar = str.ToCharArray();
            strChar[0] = char.IsUpper(strChar[0]) ? char.ToLower(strChar[0]) : char.ToUpper(strChar[0]);

            return new string(strChar);
        }
    }
}
