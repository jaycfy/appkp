using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Kimphat.Properties;

namespace Kimphat
{
    public partial class UC_Main_Products : UserControl
    {
        public UC_Main_Products()
        {
            InitializeComponent();
        }

        private void UC_Main_Products_A_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new(Database.Con);
            MySqlCommand cmd = new(
                "SELECT " +
                    "   items.attribut AS ATTRIBUT, " +
                    "   items.upc AS UPC, " +
                    "   items.kp_code AS CODE_KP, " +
                    "   items.brand AS MARQUE, " +
                    "   items.description AS DESCRIPTION, " +
                    "   items.mesure AS MESURE, " +
                    "   items.unit AS UNITÉ, " +
                    "   families.name AS FAMILLE, " +
                    "   users.username AS ACHETEUR " +
                    "FROM items " +
                    "LEFT JOIN users on items.user_id = users.id " +
                    "LEFT JOIN families on items.family_id = families.id " +
                    "WHERE items.user_id = '" + User.UserID + "' ",
                    con);

            try
            {
                con.Open();
                MySqlDataAdapter sdr = new(cmd);
                DataTable dt = new();
                sdr.Fill(dt);
                DGV_UC_Products.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
            }
            con.Close();
        }

        public void LoadImage(string url, string type)
        {
            try
            {
                // Download image from URL
                WebClient webClient = new();
                byte[] data = webClient.DownloadData(url);

                // Create a MemoryStream from the downloaded data
                using MemoryStream memoryStream = new(data);

                // Create an Image from the MemoryStream
                System.Drawing.Image image = System.Drawing.Image.FromStream(memoryStream);

                if (type == "image")
                {
                    PCB_UC_Product_Image.Image = image;
                    return;
                }

                if (type == "upc")
                {
                    PCB_UC_Product_UPC.Image = image;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de l'image :" + Environment.NewLine + ex.Message, "Erreur");
            }
        }

        private void TXT_Search_TextChanged(object sender, EventArgs e)
        {
            UC_Search_With_Filter();
        }

        private void UC_Search_With_Filter()
        {
            string Search = TXT_Search.Text;
            MySqlConnection con = new(Database.Con);

            if (CKB_UC_Products_See_Mine.Checked == true)
            {
                MySqlCommand cmd = new(
                        "SELECT " +
                            "   items.attribut AS ATTRIBUT, " +
                            "   items.upc AS UPC, " +
                            "   items.kp_code AS CODE_KP, " +
                            "   items.brand AS MARQUE, " +
                            "   items.description AS DESCRIPTION, " +
                            "   items.mesure AS MESURE, " +
                            "   items.unit AS UNITÉ, " +
                            "   families.name AS FAMILLE, " +
                            "   users.username AS ACHETEUR " +
                            "FROM items " +
                            "LEFT JOIN users on items.user_id = users.id " +
                            "LEFT JOIN families on items.family_id = families.id " +
                            "WHERE " +
                            "user_id = '" + User.UserID + "' " +
                            "AND " +
                            "(items.upc LIKE '" + Search + "%' " +
                            "OR " +
                            "kp_code LIKE '" + Search + "%' " +
                            "OR " +
                            "items.brand LIKE '%" + Search + "%' " +
                            "OR " +
                            "description LIKE '%" + Search + "%' " +
                            "OR " +
                            "family_id = '" + Search + "' )",
                            con);

                try
                {
                    con.Open();
                    MySqlDataAdapter sdr = new(cmd);
                    DataTable dt = new();
                    sdr.Fill(dt);
                    DGV_UC_Products.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
                }
                con.Close();
            }
            else
            {
                MySqlCommand cmd = new(
                "SELECT " +
                    "   items.attribut AS ATTRIBUT, " +
                    "   items.upc AS UPC, " +
                    "   items.kp_code AS CODE_KP, " +
                    "   items.brand AS MARQUE, " +
                    "   items.description AS DESCRIPTION, " +
                    "   items.mesure AS MESURE, " +
                    "   items.unit AS UNITÉ, " +
                    "   families.name AS FAMILLE, " +
                    "   users.username AS ACHETEUR " +
                    "FROM items " +
                    "LEFT JOIN users on items.user_id = users.id " +
                    "LEFT JOIN families on items.family_id = families.id " +
                    "WHERE " +
                    "items.upc LIKE '" + Search + "%' " +
                    "OR " +
                    "kp_code LIKE '" + Search + "%' " +
                    "OR " +
                    "items.brand LIKE '%" + Search + "%' " +
                    "OR " +
                    "description LIKE '%" + Search + "%' " +
                    "OR " +
                    "family_id = '" + Search + "' " +
                    "OR " +
                    "users.username = '" + Search + "'",
                    con);

                try
                {
                    con.Open();
                    MySqlDataAdapter sdr = new(cmd);
                    DataTable dt = new();
                    sdr.Fill(dt);
                    DGV_UC_Products.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
                }
                con.Close();
            }
        }

        private void CKB_UC_Products_See_Mine_CheckedChanged(object sender, EventArgs e)
        {
            if (CKB_UC_Products_See_Mine.Checked == true)
            {
                if (TXT_Search.Text == null)
                {
                    MySqlConnection con = new(Database.Con);
                    MySqlCommand cmd = new(
                        "SELECT " +
                            "   items.attribut AS ATTRIBUT, " +
                            "   items.upc AS UPC, " +
                            "   items.kp_code AS CODE_KP, " +
                            "   items.brand AS MARQUE, " +
                            "   items.description AS DESCRIPTION, " +
                            "   items.mesure AS MESURE, " +
                            "   items.unit AS UNITÉ, " +
                            "   families.name AS FAMILLE, " +
                            "   users.username AS ACHETEUR " +
                            "FROM items " +
                            "LEFT JOIN users on items.user_id = users.id " +
                            "LEFT JOIN families on items.family_id = families.id " +
                            "WHERE items.user_id = '" + User.UserID + "' ",
                            con);

                    try
                    {
                        con.Open();
                        MySqlDataAdapter sdr = new(cmd);
                        DataTable dt = new();
                        sdr.Fill(dt);
                        DGV_UC_Products.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
                    }
                    con.Close();
                }
                else
                {
                    string Search = TXT_Search.Text;
                    MySqlConnection con = new(Database.Con);
                    MySqlCommand cmd = new(
                        "SELECT " +
                            "   items.attribut AS ATTRIBUT, " +
                            "   items.upc AS UPC, " +
                            "   items.kp_code AS CODE_KP, " +
                            "   items.brand AS MARQUE, " +
                            "   items.description AS DESCRIPTION, " +
                            "   items.mesure AS MESURE, " +
                            "   items.unit AS UNITÉ, " +
                            "   families.name AS FAMILLE, " +
                            "   users.username AS ACHETEUR " +
                            "FROM items " +
                            "LEFT JOIN users on items.user_id = users.id " +
                            "LEFT JOIN families on items.family_id = families.id " +
                            "WHERE " +
                            "user_id = '" + User.UserID + "' " +
                            "AND " +
                            "(items.upc LIKE '" + Search + "%' " +
                            "OR " +
                            "kp_code LIKE '" + Search + "%' " +
                            "OR " +
                            "items.brand LIKE '%" + Search + "%' " +
                            "OR " +
                            "description LIKE '%" + Search + "%' " +
                            "OR " +
                            "family_id = '" + Search + "' )",
                            con);

                    try
                    {
                        con.Open();
                        MySqlDataAdapter sdr = new(cmd);
                        DataTable dt = new();
                        sdr.Fill(dt);
                        DGV_UC_Products.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
                    }
                    con.Close();
                }
            }
            else
            {
                UC_Search_With_Filter();
            }
        }

        private void UC_Main_Product_Selected(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_UC_Products.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) { return; }

            DGV_UC_Products.CurrentRow.Selected = true;
            string SelectedProduct = DGV_UC_Products.Rows[e.RowIndex].Cells["upc"].FormattedValue.ToString();

            MySqlConnection con = new(Database.Con);

            try
            {
                con.Open();
                MySqlCommand cmd = new(
                    "SELECT " +
                    "items.kp_code, " +
                    "items.brand, " +
                    "items.description, " +
                    "items.cs_qty, " +
                    "items.mesure, " +
                    "items.unit, " +
                    "items.attribut, " +
                    "items.balance, " +
                    "items.taxes, " +
                    "items.deposit, " +
                    "items.image_url, " +
                    "items.status_vsl, " +
                    "items.status_jarry, " +
                    "items.status_goyer, " +
                    "items.status_brossard, " +
                    "items.last_date_vsl, " +
                    "items.last_date_jarry, " +
                    "items.last_date_goyer, " +
                    "items.last_date_brossard, " +
                    "items.last_price_vsl, " +
                    "items.last_price_jarry, " +
                    "items.last_price_goyer, " +
                    "items.last_price_brossard, " +
                    "categories.name AS category, " +
                    "families.name AS familly, " +
                    "users.username AS user " +
                    "FROM items " +
                    "LEFT JOIN categories on items.category_id = categories.id " +
                    "LEFT JOIN families on items.family_id = families.id " +
                    "LEFT JOIN users on items.user_id = users.id " +
                    "WHERE items.upc ='" + SelectedProduct + "'",
                    con);


                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PNL_UC_Products.Show();
                    string upc = SelectedProduct[1..];
                    string kp_code = reader["kp_code"].ToString();
                    string brand = reader["brand"].ToString();
                    string description = reader["description"].ToString();
                    int cs_qty = Convert.ToInt16(reader["cs_qty"].ToString());
                    string mesure = reader["mesure"].ToString();
                    string unit = reader["unit"].ToString();
                    string attribut = reader["attribut"].ToString();
                    int balance = Convert.ToInt16(reader["balance"].ToString());
                    int taxes = Convert.ToInt16(reader["taxes"].ToString());
                    int deposit = Convert.ToInt16(reader["deposit"].ToString());
                    string image_url = reader["image_url"].ToString();
                    int status_vsl = Convert.ToInt16(reader["status_vsl"].ToString());
                    int status_jarry = Convert.ToInt16(reader["status_jarry"].ToString());
                    int status_goyer = Convert.ToInt16(reader["status_goyer"].ToString());
                    int status_brossard = Convert.ToInt16(reader["status_brossard"].ToString());
                    string last_date_vsl = reader["last_date_vsl"].ToString();
                    string last_date_jarry = reader["last_date_jarry"].ToString();
                    string last_date_goyer = reader["last_date_goyer"].ToString();
                    string last_date_brossard = reader["last_date_brossard"].ToString();
                    string last_price_vsl = reader["last_price_vsl"].ToString();
                    string last_price_jarry = reader["last_price_jarry"].ToString();
                    string last_price_goyer = reader["last_price_goyer"].ToString();
                    string last_price_brossard = reader["last_price_brossard"].ToString();
                    string category = reader["category"].ToString();
                    string familly = reader["familly"].ToString();
                    string user = reader["user"].ToString();

                    PCB_UC_Product_Image.Image = null;
                    if (image_url != "")
                    {
                        LoadImage(url: image_url, type: "image");
                    }
                    string buildedURL = "https://barcode.tec-it.com/barcode.ashx?data=" + upc + "&code=EAN13&translate-esc=true";
                    LoadImage(buildedURL, "upc");

                    LBL_UC_Main_Product_Attribut.Text = attribut;
                    LBL_UC_Main_Product_KPCode.Text = kp_code + " (Sujet à changement)";
                    LBL_UC_Main_Product_Brand.Text = brand;
                    LBL_UC_Main_Product_Desc.Text = description;
                    LBL_UC_Main_Product_Format.Text = mesure + " " + unit;
                    LBL_UC_Main_Product_Case.Text = cs_qty + " x " + mesure + " " + unit;
                    LBL_UC_Main_Product_User.Text = user;
                    LBL_UC_Main_Product_Category.Text = category;
                    LBL_UC_Main_Product_Family.Text = familly;

                    CKB_UC_Main_Product_Balance.Checked = false;
                    if (balance == 1) { CKB_UC_Main_Product_Balance.Checked = true; }
                    CKB_UC_Main_Product_Taxes.Checked = false;
                    if (taxes == 1) { CKB_UC_Main_Product_Taxes.Checked = true; }
                    CKB_UC_Main_Product_Deposit.Checked = false;
                    if (deposit == 1) { CKB_UC_Main_Product_Deposit.Checked = true; }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage du produit sélectionné :" + Environment.NewLine + ex.Message, "Erreur");
            }
        }
    }
}
