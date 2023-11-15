using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kimphat
{
    internal class Functions
    {
        public static bool EntryIsCorrect(string TXT_Input)
        {
            if (TXT_Input == String.Empty)
            {
                return false;
            }
            return true;
        }
    }
}
