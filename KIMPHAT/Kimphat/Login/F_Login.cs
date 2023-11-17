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
using Kimphat.Properties;

namespace Kimphat
{
    public partial class F_Login : Form
    {
        private void Update_F_Login_Bar(string text, bool errorcode)
        {
            if (errorcode == false)
            {
                LBL_F_Login_Status.ForeColor = Color.DimGray;
            }
            else
            {
                LBL_F_Login_Status.ForeColor = Color.Red;
                text = "Erreur : " + text;
            }
            LBL_F_Login_Status.Text = text;
        }



        public F_Login()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            string inputUsername = TXT_Username.Text;
            string inputPassword = TXT_Password.Text;

            //---
            Update_F_Login_Bar("Vérification en cours", false);

            if (Functions.EntryIsCorrect(inputUsername) == false)
            {
                //---
                Update_F_Login_Bar("Veuillez entrer un utilisateur", true);
                TXT_Username.BackColor = Color.LightCoral;
                TXT_Password.BackColor = Color.LightCoral;
                TXT_Password.Text = "";
                TXT_Username.Focus();
                return;
            }
            else TXT_Username.BackColor = Color.White;

            if (Functions.EntryIsCorrect(inputPassword) == false)
            {
                //---
                Update_F_Login_Bar("Veuillez entrer un mot de passe", true);
                TXT_Password.BackColor = Color.LightCoral;
                TXT_Password.Focus();
                return;
            }
            else TXT_Password.BackColor = Color.White;

            //---
            Update_F_Login_Bar("Connection à la base de données", false);

            MySqlConnection con = new(Database.Con);

            try
            {
                con.Open();
                MySqlCommand cmd = new(
                    "SELECT level.name, users.id, users.username, users.password, users.level, users.store_id " +
                    "FROM users left join level on users.level=level.level " +
                    "WHERE users.username ='" + inputUsername + "';",
                    con);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["password"].ToString() != inputPassword)
                    {
                        //---
                        Update_F_Login_Bar("Mot de passe incorrect", true);
                        TXT_Password.BackColor = Color.LightCoral;
                        TXT_Password.Focus();
                        TXT_Password.Text = "";
                        return;
                    }

                    TXT_Password.BackColor = Color.White;

                    User.UserID = reader["id"].ToString();
                    User.UserName = reader["username"].ToString();
                    User.UserLevel = reader["level"].ToString();
                    User.UserAttribut = reader["store_id"].ToString();
                    User.UserRole = reader["name"].ToString();

                    F_Main f_Main = new();
                    f_Main.Show();

                    this.Hide();
                }
                else
                {
                    //---
                    Update_F_Login_Bar("Utilisateur incorrect", true);
                    TXT_Username.BackColor = Color.LightCoral;
                    TXT_Username.Focus();
                    TXT_Password.Text = "";
                    return;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                //---
                Update_F_Login_Bar(ex.Message, true);
                MessageBox.Show("Erreur :" + Environment.NewLine + ex.Message);
            }
            con.Close();
        }

        private void TXT_loginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)

            {
                BTN_Login_Click(sender, e);
            }
        }

        private void TXT_loginUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)

            {
                TXT_Password.Focus();
            }
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new(Database.Con);
            try
            {
                con.Open();
                Update_F_Login_Bar("Ready", false);
                LBL_F_Login_Status.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                LBL_F_Login_Status.ForeColor = Color.Red;
                Update_F_Login_Bar("Database is offline", true);
            }
            con.Close();
        }

        private void F_Login_Forgot(object sender, EventArgs e)
        {
            F_Forgot_Pwd_Info f_forgot_Pwd_Info = new();
            f_forgot_Pwd_Info.Show();
        }
    }
}
