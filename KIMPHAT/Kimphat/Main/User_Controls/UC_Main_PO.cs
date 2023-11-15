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
using Microsoft.Extensions.Configuration;

namespace Kimphat.Main.User_Controls
{
    public partial class UC_Main_PO : UserControl
    {
        private readonly IConfiguration _configuration;
        public UC_Main_PO()
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddUserSecrets<UC_Main_PO>().Build();
        }

        private void UC_Main_PO_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new(_configuration["DB:Con"]);
            MySqlCommand cmd = new(
                "SELECT id AS ID, created_date AS DATE, e_compagny AS COMPAGNIE, status AS STATUS FROM work", con);

            try
            {
                con.Open();
                MySqlDataAdapter sdr = new(cmd);
                DataTable dt = new();
                sdr.Fill(dt);
                DGV_UC_PO.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            con.Close();
        }

        private void PCB_UC_PO_Edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité 'AJOUTER' à venir");
        }

        private void PCB_UC_PO_Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité 'ÉDITER' à venir");
        }

        private void DGV_UC_PO_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_UC_PO.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) { return; }

            DGV_UC_PO.CurrentRow.Selected = true;
            string SelectedBT = DGV_UC_PO.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();

            MySqlConnection con = new(_configuration["DB:Con"]);

            try
            {
                con.Open();
                MySqlCommand cmd = new(
                    "SELECT " +
                    "work.requested_date, " +
                    "a.name AS a_name, " +
                    "a.address AS a_address, " +
                    "a.city AS a_city, " +
                    "a.province AS a_province, " +
                    "a.p_code AS a_p_code, " +
                    "b.name AS b_name, " +
                    "b.address AS b_address, " +
                    "b.city AS b_city, " +
                    "b.province AS b_province, " +
                    "b.p_code AS b_p_code, " +
                    "work.s_contact, " +
                    "work.s_number, " +
                    "work.s_email, " +
                    "work.e_compagny, " +
                    "work.e_contact, " +
                    "work.e_number, " +
                    "work.e_email, " +
                    "work.work, " +
                    "work.submission_price, " +
                    "work.additional_price, " +
                    "work.ho_followup, " +
                    "work.created_by, " +
                    "work.approved_by " +
                    "FROM work " +
                    "LEFT JOIN stores AS a on work.work_address = a.id " +
                    "LEFT JOIN stores AS b on work.billing_address = b.id " +
                    "WHERE work.id ='" + SelectedBT + "'",
                    con);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PNL_UC_PO_BT.Show();
                    string requested_date = string.Concat("Date de la demande : ", reader["requested_date"].ToString().AsSpan(0, length: reader["requested_date"].ToString().Length - 9));
                    string work_address = reader["a_name"].ToString() + Environment.NewLine + reader["a_address"].ToString() + ", " + reader["a_city"].ToString() + Environment.NewLine + reader["a_province"].ToString() + ", " + reader["a_p_code"].ToString();
                    string billing_address = reader["b_name"].ToString() + Environment.NewLine + reader["b_address"].ToString() + ", " + reader["b_city"].ToString() + Environment.NewLine + reader["b_province"].ToString() + ", " + reader["b_p_code"].ToString();
                    string s_contact = reader["s_contact"].ToString();
                    string s_number = reader["s_number"].ToString();
                    string s_email = reader["s_email"].ToString();
                    string e_compagny = reader["e_compagny"].ToString();
                    string e_contact = reader["e_contact"].ToString();
                    string e_number = reader["e_number"].ToString();
                    string e_email = reader["e_email"].ToString();
                    string work = reader["work"].ToString();
                    double submission = double.Parse(reader["submission_price"].ToString());
                    double additional = double.Parse(reader["additional_price"].ToString());
                    string ho_followup = reader["ho_followup"].ToString();
                    string created_by = reader["created_by"].ToString();
                    string approved_by = reader["approved_by"].ToString();

                    LBL_UC_PO_Request_Date.Text = requested_date;
                    LBL_UC_PO_Id.Text = SelectedBT;
                    LBL_UC_PO_Work_Address.Text = work_address;
                    LBL_UC_PO_Billing_Address.Text = billing_address;
                    LBL_UC_PO_S_Contact.Text = s_contact;
                    LBL_UC_PO_S_Number.Text = s_number;
                    LBL_UC_PO_S_Email.Text = s_email;
                    LBL_UC_PO_E_Compagny.Text = e_compagny;
                    LBL_UC_PO_E_Contact.Text = e_contact;
                    LBL_UC_PO_E_Number.Text = e_number;
                    LBL_UC_PO_E_Email.Text = e_email;
                    TXT_UC_PO_Work.Text = work;
                    LBL_UC_PO_Submission.Text = "$" + submission.ToString();
                    LBL_UC_PO_Additional.Text = "$" + additional.ToString();
                    TXT_UC_PO_Follow_Up.Text = ho_followup;
                    LBL_UC_PO_Created_By.Text = created_by;
                    LBL_UC_PO_Approved_By.Text = approved_by;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void TXT_Search_TextChanged(object sender, EventArgs e)
        {

            string Search = TXT_Search.Text;
            MySqlConnection con = new(_configuration["DB:Con"]);

            MySqlCommand cmd = new(
                "SELECT " +
                "id AS ID, " +
                "created_date AS DATE, " +
                "e_compagny AS COMPAGNIE, " +
                "status AS STATUS " +
                "FROM work " +
                "WHERE " +
                "id LIKE '%" + Search + "%' " +
                "OR status LIKE '%" + Search + "%'",
                con);

            try
            {
                con.Open();
                MySqlDataAdapter sdr = new(cmd);
                DataTable dt = new();
                sdr.Fill(dt);
                DGV_UC_PO.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            con.Close();
        }
    }
}
