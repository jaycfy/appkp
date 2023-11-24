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
                List<string> Work_Address = [];
                List<string> Billing_Address = [];
                con.Open();
                MySqlCommand cmd = new(
                    "SELECT id, name FROM stores", con);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Work_Address.Add(reader.GetString("id") + " - " + reader.GetString("name"));
                    Billing_Address.Add(reader.GetString("id") + " - " + reader.GetString("name"));
                }

                CBB_F_Add_Work_Work_Address.DataSource = Work_Address;
                CBB_F_Add_Work_Work_Address.Text = string.Empty;
                LBL_F_Add_Work_Work_Address.Text = string.Empty;
                CBB_F_Add_Work_Billing_Address.DataSource = Billing_Address;
                CBB_F_Add_Work_Billing_Address.Text = string.Empty;
                LBL_F_Add_Work_Billing_Address.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
            }


            LBL_F_Add_Work_Id.Text = NewWork.Id;
            DTP_F_Add_Work_Request_Date.Value = DateTime.Now;
        }

        private void BTN_F_Add_Work_Cancel_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            this.Hide();
        }

        private void CBB_F_Add_Work_Work_Address_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Work_Address_Name = CBB_F_Add_Work_Work_Address.Text;
            string Work_Address_Id = Work_Address_Name[..Math.Min(Work_Address_Name.Length, 6)];
            if (CBB_F_Add_Work_Work_Address.Text == string.Empty) { return; }

            MySqlConnection con = new(Database.Con);

            try
            {
                con.Open();
                MySqlCommand cmd = new(
                    "SELECT " +
                    "name, address, city, province, p_code " +
                    "FROM stores " +
                    "WHERE id = '" + Work_Address_Id + "'", con);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string work_address = reader["address"].ToString() + ", " + reader["city"].ToString() + Environment.NewLine + reader["province"].ToString() + ", " + reader["p_code"].ToString();
                    LBL_F_Add_Work_Work_Address.Text = work_address;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
            }
        }

        private void CBB_F_Add_Work_Billing_Address_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Billing_Address_Name = CBB_F_Add_Work_Billing_Address.Text;
            string Billing_Address_Id = Billing_Address_Name[..Math.Min(Billing_Address_Name.Length, 6)];
            
            if (CBB_F_Add_Work_Billing_Address.Text == string.Empty) { return; }

            MySqlConnection con = new(Database.Con);

            try
            {
                con.Open();
                MySqlCommand cmd = new(
                    "SELECT " +
                    "name, address, city, province, p_code " +
                    "FROM stores " +
                    "WHERE id = '" + Billing_Address_Id + "'", con);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string billing_address = reader["address"].ToString() + ", " + reader["city"].ToString() + Environment.NewLine + reader["province"].ToString() + ", " + reader["p_code"].ToString();
                    LBL_F_Add_Work_Billing_Address.Text = billing_address;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
            }
        }

        private void BTN_F_Add_Work_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité 'ENREGISTRER' à venir", "Attention");
        }
    }
}
