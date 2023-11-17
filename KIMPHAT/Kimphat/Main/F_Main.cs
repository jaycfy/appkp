using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kimphat
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private void LBL_F_Main_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LBL_F_Main_Category_Click(object sender, EventArgs e)
        {
            uC_Main_Category1.Show();

            uC_Main_Products1.Hide();
            uC_Main_Settings1.Hide();
            uC_Main_po1.Hide();
        }

        private void LBL_F_Main_Product_Click(object sender, EventArgs e)
        {
            uC_Main_Products1.Show();

            uC_Main_Category1.Hide();
            uC_Main_Settings1.Hide();
            uC_Main_po1.Hide();
        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            LBL_F_Main_Level.Text = User.UserRole;
            LBL_F_Main_Username.Text = User.UserName;
        }

        private void LBL_F_Main_Settings_Click(object sender, EventArgs e)
        {
            uC_Main_Settings1.Show();

            uC_Main_Category1.Hide();
            uC_Main_Products1.Hide();
            uC_Main_po1.Hide();
        }

        private void LBL_F_Main_Promo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité à 'SPÉCIAUX' venir", "Attention");
        }

        private void LBL_F_Main_Buyer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité à 'ACHATS' venir", "Attention");
        }

        private void LBL_F_Main_Family_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité 'FAMILLE' à venir", "Attention");
        }

        private void LBL_F_Main_PO_Click(object sender, EventArgs e)
        {
            if (User.UserLevel != "4")
            {
                MessageBox.Show("Erreur :" + Environment.NewLine + "Connectez-vous avec des autorisations necessaires", "Erreur");
                return;
            }
            uC_Main_po1.Show();

            uC_Main_Category1.Hide();
            uC_Main_Products1.Hide();
            uC_Main_Settings1.Hide();
        }
    }
}
