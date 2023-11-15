using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kimphat.Properties
{
    public static class Database
    {
        private static readonly string? IP = "173.176.2.62";
        private static readonly string? Port = "40444";
        private static readonly string? Uid = "kimphat";
        private static readonly string? Pwd = "F%a9d3G?5";
        private static readonly string? Db = "kp";
        public static readonly string Con = "server=" + IP + ";port=" + Port + ";uid=" + Uid + ";password=" + Pwd + ";database=" + Db;
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
