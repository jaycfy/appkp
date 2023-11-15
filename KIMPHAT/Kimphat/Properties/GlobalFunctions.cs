using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kimphat.Properties
{
    public static class Database
    {
        public static string Con = "server=173.176.2.62;port=40444;uid=kimphat;password=F%a9d3G?5;database=kp";
    }
    internal class Functions
    {
        public static bool EntryIsCorrect(string TXT_Input)
        {
            if (TXT_Input == string.Empty)
            {
                return false;
            }
            return true;
        }
    }
}
