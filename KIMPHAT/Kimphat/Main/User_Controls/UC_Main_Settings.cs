using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace Kimphat
{
    public partial class UC_Main_Settings : UserControl
    {
        private readonly IConfiguration _configuration;
        public UC_Main_Settings()
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddUserSecrets<UC_Main_Settings>().Build();
        }
    }
}
