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
        }

        private void BTN_F_Add_Work_Cancel_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            this.Hide();
        }

        private void CBB_F_Add_Work_Work_Address_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Work_Address_Name = CBB_F_Add_Work_Work_Address.Text;
            if (CBB_F_Add_Work_Work_Address.Text == string.Empty) { return; }

            MySqlConnection con = new(Database.Con);

            try
            {
                con.Open();
                MySqlCommand cmd = new(
                    "SELECT " +
                    "address, city, province, p_code " +
                    "FROM stores " +
                    "WHERE name = '" + Work_Address_Name + "'", con);

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
            if (CBB_F_Add_Work_Billing_Address.Text == string.Empty) { return; }

            MySqlConnection con = new(Database.Con);

            try
            {
                con.Open();
                MySqlCommand cmd = new(
                    "SELECT " +
                    "address, city, province, p_code " +
                    "FROM stores " +
                    "WHERE name = '" + Billing_Address_Name + "'", con);

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
            MessageBox.Show("Fonctionnalité à 'ENREGISTRER' venir", "Attention");
        }
    }
}
