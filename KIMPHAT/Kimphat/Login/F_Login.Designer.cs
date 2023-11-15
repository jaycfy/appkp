namespace Kimphat
{
    partial class F_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            TXT_Username = new TextBox();
            TXT_Password = new TextBox();
            LBL_Username = new Label();
            label1 = new Label();
            label2 = new Label();
            BTN_Login = new Button();
            statusStrip1 = new StatusStrip();
            strip = new ToolStripStatusLabel();
            LBL_F_Login_Status = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Location = new Point(-9, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 20);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BackgroundImage = Properties.Resources.KP_Logo;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(-8, 14);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 65);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(227, 15, 44);
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(-8, -1);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 6);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(-8, 5);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(353, 84);
            panel4.TabIndex = 2;
            // 
            // TXT_Username
            // 
            TXT_Username.BackColor = Color.White;
            TXT_Username.Cursor = Cursors.IBeam;
            TXT_Username.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TXT_Username.ForeColor = Color.FromArgb(40, 40, 40);
            TXT_Username.Location = new Point(40, 155);
            TXT_Username.Name = "TXT_Username";
            TXT_Username.Size = new Size(249, 24);
            TXT_Username.TabIndex = 1;
            TXT_Username.KeyPress += TXT_loginUsername_KeyPress;
            // 
            // TXT_Password
            // 
            TXT_Password.BackColor = Color.White;
            TXT_Password.Cursor = Cursors.IBeam;
            TXT_Password.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TXT_Password.ForeColor = Color.FromArgb(40, 40, 40);
            TXT_Password.Location = new Point(40, 234);
            TXT_Password.Name = "TXT_Password";
            TXT_Password.PasswordChar = '*';
            TXT_Password.Size = new Size(249, 24);
            TXT_Password.TabIndex = 2;
            TXT_Password.KeyPress += TXT_loginPassword_KeyPress;
            // 
            // LBL_Username
            // 
            LBL_Username.AutoSize = true;
            LBL_Username.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Username.Location = new Point(40, 133);
            LBL_Username.Name = "LBL_Username";
            LBL_Username.Size = new Size(86, 18);
            LBL_Username.TabIndex = 5;
            LBL_Username.Text = "Utilisateur";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 212);
            label1.Name = "label1";
            label1.Size = new Size(113, 18);
            label1.TabIndex = 6;
            label1.Text = "Mot de passe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Gotham", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 265);
            label2.Name = "label2";
            label2.Size = new Size(122, 12);
            label2.TabIndex = 4;
            label2.Text = "Mot de passe oublié ?";
            label2.Click += F_Login_Forgot;
            // 
            // BTN_Login
            // 
            BTN_Login.Font = new Font("Gotham", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_Login.Location = new Point(40, 333);
            BTN_Login.Name = "BTN_Login";
            BTN_Login.Size = new Size(147, 46);
            BTN_Login.TabIndex = 3;
            BTN_Login.Text = "Se connecter";
            BTN_Login.UseVisualStyleBackColor = true;
            BTN_Login.Click += BTN_Login_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.Items.AddRange(new ToolStripItem[] { strip, LBL_F_Login_Status });
            statusStrip1.Location = new Point(0, 406);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(336, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // strip
            // 
            strip.Font = new Font("Gotham", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            strip.Name = "strip";
            strip.Size = new Size(62, 17);
            strip.Text = "Console :";
            // 
            // LBL_F_Login_Status
            // 
            LBL_F_Login_Status.Font = new Font("Gotham", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_F_Login_Status.Name = "LBL_F_Login_Status";
            LBL_F_Login_Status.Size = new Size(0, 17);
            // 
            // F_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(336, 428);
            Controls.Add(statusStrip1);
            Controls.Add(BTN_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LBL_Username);
            Controls.Add(TXT_Password);
            Controls.Add(TXT_Username);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            ForeColor = Color.FromArgb(40, 40, 40);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "F_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KIM PHAT - Log In";
            Load += F_Login_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox TXT_Username;
        private TextBox TXT_Password;
        private Label LBL_Username;
        private Label label1;
        private Label label2;
        private Button BTN_Login;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel strip;
        private ToolStripStatusLabel LBL_F_Login_Status;
    }
}