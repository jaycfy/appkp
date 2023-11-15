namespace Kimphat
{
    partial class UC_Main_Settings
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            BTN_UC_Admin_ChangePassword = new Button();
            label1 = new Label();
            BTN_UC_Admin_CreateUser = new Button();
            SuspendLayout();
            // 
            // BTN_UC_Admin_ChangePassword
            // 
            BTN_UC_Admin_ChangePassword.Font = new Font("Gotham", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_UC_Admin_ChangePassword.Location = new Point(23, 65);
            BTN_UC_Admin_ChangePassword.Name = "BTN_UC_Admin_ChangePassword";
            BTN_UC_Admin_ChangePassword.Size = new Size(246, 46);
            BTN_UC_Admin_ChangePassword.TabIndex = 4;
            BTN_UC_Admin_ChangePassword.Text = "Modifier mon mot de passe";
            BTN_UC_Admin_ChangePassword.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Gotham", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(227, 15, 44);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(266, 37);
            label1.TabIndex = 5;
            label1.Text = "Utilisateurs";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BTN_UC_Admin_CreateUser
            // 
            BTN_UC_Admin_CreateUser.Font = new Font("Gotham", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_UC_Admin_CreateUser.Location = new Point(23, 117);
            BTN_UC_Admin_CreateUser.Name = "BTN_UC_Admin_CreateUser";
            BTN_UC_Admin_CreateUser.Size = new Size(246, 46);
            BTN_UC_Admin_CreateUser.TabIndex = 6;
            BTN_UC_Admin_CreateUser.Text = "Créer un utilisateur";
            BTN_UC_Admin_CreateUser.UseVisualStyleBackColor = true;
            // 
            // UC_Main_Administration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(BTN_UC_Admin_CreateUser);
            Controls.Add(label1);
            Controls.Add(BTN_UC_Admin_ChangePassword);
            Name = "UC_Main_Administration";
            Size = new Size(1634, 1037);
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_UC_Admin_ChangePassword;
        private Label label1;
        private Button BTN_UC_Admin_CreateUser;
    }
}
