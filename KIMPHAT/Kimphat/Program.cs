using Kimphat.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kimphat
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new F_Login());
        }
    }

    public static class User
    {
        public static string? UserLevel { get; set; }
        public static string? UserName { get; set; }
        public static string? UserAttribut { get; set; }
        public static string? UserID { get; set; }
        public static string? UserRole { get; set; }
    }
}