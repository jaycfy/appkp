namespace Kimphat
{
    partial class F_Forgot_Pwd_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Forgot_Pwd_Info));
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            BTN_F_Forgot_OK = new Button();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BackgroundImage = Properties.Resources.KP_Logo;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(0, 9);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 65);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(227, 15, 44);
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(555, 14);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(0, 14);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(555, 84);
            panel4.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Gotham", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(531, 133);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            // 
            // BTN_F_Forgot_OK
            // 
            BTN_F_Forgot_OK.Font = new Font("Gotham", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_F_Forgot_OK.Location = new Point(463, 254);
            BTN_F_Forgot_OK.Name = "BTN_F_Forgot_OK";
            BTN_F_Forgot_OK.Size = new Size(80, 30);
            BTN_F_Forgot_OK.TabIndex = 0;
            BTN_F_Forgot_OK.Text = "OK";
            BTN_F_Forgot_OK.UseVisualStyleBackColor = true;
            BTN_F_Forgot_OK.Click += BTN_F_Forgot_OK_Click;
            // 
            // F_Forgot_Pwd_Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(555, 296);
            ControlBox = false;
            Controls.Add(BTN_F_Forgot_OK);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "F_Forgot_Pwd_Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KIM PHAT - Info mot de passe oublié";
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Button BTN_F_Forgot_OK;
    }
}