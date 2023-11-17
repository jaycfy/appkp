using Kimphat.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kimphat.Main
{
    public partial class F_Add_Work : Form
    {
        public static class NewWork
        {
            public static string? Id { get; set; }
        }
        public F_Add_Work()
        {
            InitializeComponent();
        }

        private void F_Add_Work_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new(Database.Con);
            try
            {
                List<string> Work_Address = new();
                List<string> Billing_Address = new();
                con.Open();
                MySqlCommand cmd = new(
                    "SELECT name FROM stores", con);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Work_Address.Add(reader.GetString("name"));
                    Billing_Address.Add(reader.GetString("name"));
                }

                CBB_F_Add_Work_Work_Address.DataSource = Work_Address;
                CBB_F_Add_Work_Work_Address.Text = string.Empty;
                CBB_F_Add_Work_Billing_Address.DataSource = Billing_Address;
                CBB_F_Add_Work_Billing_Address.Text= string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
            }

            
            LBL_F_Add_Work_Id.Text = NewWork.Id;
        }

        private void BTN_F_Add_Work_Cancel_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            this.Hide();
        }
    }
}
