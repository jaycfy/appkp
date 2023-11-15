using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using Microsoft.Extensions.Configuration;

namespace Kimphat
{
    public partial class UC_Main_Category : UserControl
    {
        private readonly IConfiguration _configuration;
        public UC_Main_Category() 
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddUserSecrets<UC_Main_Category>().Build();
        } 

        private void UC_Main_Category_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new(_configuration["DB:Con"]);
            MySqlCommand cmd = new(
                "SELECT * FROM categories", con);

            try
            {
                con.Open();
                MySqlDataAdapter sdr = new(cmd);
                DataTable dt = new();
                sdr.Fill(dt);
                DGV_UC_Category_C.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            con.Close();
        }

        private void UC_Main_Category_Selected(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_UC_Category_C.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) { return; }

            DGV_UC_Category_C.CurrentRow.Selected = true;
            string SelectedCategory = DGV_UC_Category_C.Rows[e.RowIndex]
                                                       .Cells["id"].FormattedValue
                                                       .ToString();

            MySqlConnection con = new(_configuration["DB:Con"]);
            
            try
            {
                con.Open();
                MySqlCommand cmd = new(
                    "SELECT " +
                    "   items.upc, " +
                    "   items.kp_code, " +
                    "   items.brand, " +
                    "   items.description, " +
                    "   items.mesure, " +
                    "   items.unit, " +
                    "   items.cs_qty, " +
                    "   families.name, " +
                    "   users.username " +
                    "FROM items " +
                    "LEFT JOIN users on items.user_id = users.id " +
                    "LEFT JOIN families on items.family_id = families.id " +
                    "WHERE items.category_id ='" + SelectedCategory + "'",
                    con);
                MySqlDataAdapter sdr = new(cmd);
                DataTable dt = new();
                sdr.Fill(dt);
                DGV_UC_Category_P.DataSource = dt;

                F_Main f_main = new();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            con.Close();
        }
    }
}
