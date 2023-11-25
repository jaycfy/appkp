using Kimphat.Main.User_Controls;
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
            public static int? Id { get; set; }
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
                LBL_UC_PO_Created_By.Text = User.UserName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
            }
            con.Close();

            LBL_F_Add_Work_Id.Text = "BT-" + NewWork.Id.ToString();
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
            con.Close();
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
            con.Close();
        }

        private void BTN_F_Add_Work_Save_Click(object sender, EventArgs e)
        {
            string id = LBL_F_Add_Work_Id.Text;

            DialogResult userChoice = MessageBox.Show(
                "Voulez vous créer le bon de travail " + id + " ?",
                "Confirmation : " + id, 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (userChoice != DialogResult.Yes)
            {
                MessageBox.Show("Annulé :" + Environment.NewLine + "Aucune action effectuée", "Annulation");
                return;
            }

            MySqlConnection con = new(Database.Con);
            con.Open();
            try
            {
                
                MySqlCommand cmd1 = new(
                    "SELECT id FROM work " +
                    "WHERE id = '" + id + "'", con);
                MySqlDataReader reader;
                reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Erreur :" + Environment.NewLine + "Il y a déjà un bon de travail associé avec cet ID. Veuillez ouvrir un nouveau formulaire.", "Erreur");
                    return;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
            }
            
            string requested_date = DTP_F_Add_Work_Request_Date.Value.ToString("yyyy-MM-dd");
            string work_address = CBB_F_Add_Work_Work_Address.Text[..Math.Min(CBB_F_Add_Work_Work_Address.Text.Length, 6)];
            string billing_address = CBB_F_Add_Work_Billing_Address.Text[..Math.Min(CBB_F_Add_Work_Billing_Address.Text.Length, 6)];
            string s_contact = TXT_F_Add_Work_S_Contact.Text;
            string s_number = TXT_F_Add_Work_S_Number.Text;
            string s_email = TXT_F_Add_Work_S_Email.Text;
            string e_compagny = TXT_F_Add_Work_E_Company.Text;
            string e_contact = TXT_F_Add_Work_E_Contact.Text;
            string e_number = TXT_F_Add_Work_E_Number.Text;
            string e_email = TXT_F_Add_Work_E_Email.Text;
            string work = TXT_F_Add_Work_Work.Text;
            string submission = TXT_F_Add_Work_Submission.Text;
            string additional = TXT_F_Add_Work_Additional.Text;
            string reason = TXT_F_Add_Work_Reason.Text;
            string ho_followup = TXT_F_Add_Work_Follow_Up.Text;
            string created_by = LBL_UC_PO_Created_By.Text;
            string approved_by = TXT_F_Add_Work_Approuved_By.Text;

            if (
                Functions.EntryIsCorrect(work_address) == false ||
                Functions.EntryIsCorrect(billing_address) == false ||
                Functions.EntryIsCorrect(s_contact) == false ||
                Functions.EntryIsCorrect(s_number) == false ||
                Functions.EntryIsCorrect(s_email) == false ||
                Functions.EntryIsCorrect(e_compagny) == false ||
                Functions.EntryIsCorrect(e_contact) == false ||
                Functions.EntryIsCorrect(e_number) == false ||
                Functions.EntryIsCorrect(work) == false ||
                Functions.EntryIsCorrect(additional) == false ||
                Functions.EntryIsCorrect(submission.ToString()) == false)
            {
                MessageBox.Show("Erreur :" + Environment.NewLine + "Un ou plusieurs champs obligatoires ne sont pas remplis", "Erreur");
                return;
            }
            

            try
            {
                int nextID = (int)(NewWork.Id + 1);

                MySqlCommand cmd2 = new(
                    "INSERT INTO work(" +
                    "id, " +
                    "requested_date, " +
                    "work_address, " +
                    "billing_address, " +
                    "s_contact, " +
                    "s_number, " +
                    "s_email, " +
                    "e_compagny, " +
                    "e_contact, " +
                    "e_number, " +
                    "e_email, " +
                    "work, " +
                    "submission_price, " +
                    "additional_price, " +
                    "additional_reason, " +
                    "ho_followup, " +
                    "created_by, " +
                    "approved_by) " +
                    "VALUES('" +
                    id + "','" +
                    requested_date + "','" +
                    work_address + "','" +
                    billing_address + "','" +
                    s_contact + "','" +
                    s_number + "','" +
                    s_email + "','" +
                    e_compagny + "','" +
                    e_contact + "','" +
                    e_number + "','" +
                    e_email + "','" +
                    work + "','" +
                    submission + "','" +
                    additional + "','" +
                    reason + "','" +
                    ho_followup + "','" +
                    created_by + "','" +
                    approved_by + "'); " +
                    "UPDATE ids SET ids = '" + nextID.ToString() + "' WHERE name = 'work';", con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Le bon de travail a été créé avec succès.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message, "Erreur");
            }
            con.Close();
        }
    }
}
