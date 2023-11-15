using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kimphat
{
    public static class Database
    {
        private static readonly string IP = "173.176.2.62";
        private static readonly string Port = "40444";
        private static readonly string Username = "kimphat";
        private static readonly string Password = "F%a9d3G?5";
        private static readonly string Db = "kp";
        private static readonly string v = "server=" + IP + ";port=" + Port + ";uid=" + Username + ";password=" + Password + ";database=" + Db;
        public static string con = v;
    }
}
