namespace Kimphat.Main.User_Controls
{
    partial class UC_Main_PO
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label1 = new Label();
            DGV_UC_PO = new DataGridView();
            PNL_UC_PO_BT = new Panel();
            LBL_UC_PO_Created_By = new Label();
            LBL_UC_PO_Approved_By = new Label();
            label27 = new Label();
            label28 = new Label();
            LBL_UC_PO_Additional = new Label();
            LBL_UC_PO_Submission = new Label();
            label25 = new Label();
            label26 = new Label();
            panel7 = new Panel();
            TXT_UC_PO_Follow_Up = new TextBox();
            label24 = new Label();
            panel6 = new Panel();
            TXT_UC_PO_Work = new TextBox();
            label21 = new Label();
            LBL_UC_PO_E_Email = new Label();
            LBL_UC_PO_E_Number = new Label();
            LBL_UC_PO_E_Contact = new Label();
            LBL_UC_PO_E_Compagny = new Label();
            LBL_UC_PO_S_Email = new Label();
            LBL_UC_PO_S_Number = new Label();
            label20 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            LBL_UC_PO_S_Contact = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            LBL_UC_PO_Billing_Address = new Label();
            LBL_UC_PO_Work_Address = new Label();
            panel5 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            LBL_UC_PO_Request_Date = new Label();
            label2 = new Label();
            panel2 = new Panel();
            LBL_UC_PO_Id = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            TXT_Search = new TextBox();
            pictureBox2 = new PictureBox();
            PCB_UC_PO_Add = new PictureBox();
            PCB_UC_PO_Edit = new PictureBox();
            PCB_UC_PO_Print = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DGV_UC_PO).BeginInit();
            PNL_UC_PO_BT.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_PO_Add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_PO_Edit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_PO_Print).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Gotham", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(227, 15, 44);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(266, 37);
            label1.TabIndex = 5;
            label1.Text = "BONS DE TRAVAIL";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DGV_UC_PO
            // 
            DGV_UC_PO.AllowUserToAddRows = false;
            DGV_UC_PO.AllowUserToDeleteRows = false;
            DGV_UC_PO.AllowUserToOrderColumns = true;
            DGV_UC_PO.AllowUserToResizeRows = false;
            DGV_UC_PO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_UC_PO.BackgroundColor = Color.White;
            DGV_UC_PO.BorderStyle = BorderStyle.None;
            DGV_UC_PO.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_UC_PO.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Gotham", 12F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DGV_UC_PO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DGV_UC_PO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Gotham", 12F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            DGV_UC_PO.DefaultCellStyle = dataGridViewCellStyle8;
            DGV_UC_PO.GridColor = Color.White;
            DGV_UC_PO.Location = new Point(23, 65);
            DGV_UC_PO.MultiSelect = false;
            DGV_UC_PO.Name = "DGV_UC_PO";
            DGV_UC_PO.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Gotham", 9.749999F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DGV_UC_PO.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DGV_UC_PO.RowHeadersVisible = false;
            DGV_UC_PO.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DGV_UC_PO.RowTemplate.ReadOnly = true;
            DGV_UC_PO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_UC_PO.Size = new Size(721, 913);
            DGV_UC_PO.TabIndex = 4;
            DGV_UC_PO.CellContentDoubleClick += DGV_UC_PO_CellContentDoubleClick;
            // 
            // PNL_UC_PO_BT
            // 
            PNL_UC_PO_BT.BorderStyle = BorderStyle.FixedSingle;
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_Created_By);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_Approved_By);
            PNL_UC_PO_BT.Controls.Add(label27);
            PNL_UC_PO_BT.Controls.Add(label28);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_Additional);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_Submission);
            PNL_UC_PO_BT.Controls.Add(label25);
            PNL_UC_PO_BT.Controls.Add(label26);
            PNL_UC_PO_BT.Controls.Add(panel7);
            PNL_UC_PO_BT.Controls.Add(panel6);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_E_Email);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_E_Number);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_E_Contact);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_E_Compagny);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_S_Email);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_S_Number);
            PNL_UC_PO_BT.Controls.Add(label20);
            PNL_UC_PO_BT.Controls.Add(label16);
            PNL_UC_PO_BT.Controls.Add(label17);
            PNL_UC_PO_BT.Controls.Add(label18);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_S_Contact);
            PNL_UC_PO_BT.Controls.Add(label9);
            PNL_UC_PO_BT.Controls.Add(label8);
            PNL_UC_PO_BT.Controls.Add(label7);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_Billing_Address);
            PNL_UC_PO_BT.Controls.Add(LBL_UC_PO_Work_Address);
            PNL_UC_PO_BT.Controls.Add(panel5);
            PNL_UC_PO_BT.Controls.Add(panel1);
            PNL_UC_PO_BT.Controls.Add(label3);
            PNL_UC_PO_BT.Controls.Add(label5);
            PNL_UC_PO_BT.Controls.Add(panel4);
            PNL_UC_PO_BT.Controls.Add(panel3);
            PNL_UC_PO_BT.Location = new Point(851, 25);
            PNL_UC_PO_BT.Name = "PNL_UC_PO_BT";
            PNL_UC_PO_BT.Size = new Size(764, 989);
            PNL_UC_PO_BT.TabIndex = 6;
            PNL_UC_PO_BT.Visible = false;
            // 
            // LBL_UC_PO_Created_By
            // 
            LBL_UC_PO_Created_By.BackColor = Color.Transparent;
            LBL_UC_PO_Created_By.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_Created_By.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_Created_By.Location = new Point(182, 901);
            LBL_UC_PO_Created_By.Name = "LBL_UC_PO_Created_By";
            LBL_UC_PO_Created_By.Size = new Size(554, 35);
            LBL_UC_PO_Created_By.TabIndex = 49;
            LBL_UC_PO_Created_By.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_PO_Approved_By
            // 
            LBL_UC_PO_Approved_By.BackColor = Color.Transparent;
            LBL_UC_PO_Approved_By.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_Approved_By.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_Approved_By.Location = new Point(182, 936);
            LBL_UC_PO_Approved_By.Name = "LBL_UC_PO_Approved_By";
            LBL_UC_PO_Approved_By.Size = new Size(554, 35);
            LBL_UC_PO_Approved_By.TabIndex = 48;
            LBL_UC_PO_Approved_By.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label27.ForeColor = Color.FromArgb(40, 40, 40);
            label27.Location = new Point(26, 936);
            label27.Name = "label27";
            label27.Size = new Size(150, 35);
            label27.TabIndex = 47;
            label27.Text = "Approbation de :";
            label27.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            label28.BackColor = Color.Transparent;
            label28.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label28.ForeColor = Color.FromArgb(40, 40, 40);
            label28.Location = new Point(26, 901);
            label28.Name = "label28";
            label28.Size = new Size(150, 35);
            label28.TabIndex = 46;
            label28.Text = "Initiation de :";
            label28.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_PO_Additional
            // 
            LBL_UC_PO_Additional.BackColor = Color.Transparent;
            LBL_UC_PO_Additional.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_Additional.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_Additional.Location = new Point(232, 639);
            LBL_UC_PO_Additional.Name = "LBL_UC_PO_Additional";
            LBL_UC_PO_Additional.Size = new Size(504, 23);
            LBL_UC_PO_Additional.TabIndex = 45;
            LBL_UC_PO_Additional.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_PO_Submission
            // 
            LBL_UC_PO_Submission.BackColor = Color.Transparent;
            LBL_UC_PO_Submission.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_Submission.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_Submission.Location = new Point(232, 616);
            LBL_UC_PO_Submission.Name = "LBL_UC_PO_Submission";
            LBL_UC_PO_Submission.Size = new Size(504, 23);
            LBL_UC_PO_Submission.TabIndex = 44;
            LBL_UC_PO_Submission.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label25.ForeColor = Color.FromArgb(40, 40, 40);
            label25.Location = new Point(26, 639);
            label25.Name = "label25";
            label25.Size = new Size(207, 23);
            label25.TabIndex = 43;
            label25.Text = "Coûts supplémentaires :";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label26.ForeColor = Color.FromArgb(40, 40, 40);
            label26.Location = new Point(26, 616);
            label26.Name = "label26";
            label26.Size = new Size(207, 23);
            label26.TabIndex = 42;
            label26.Text = "Soumission :";
            label26.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TXT_UC_PO_Follow_Up);
            panel7.Controls.Add(label24);
            panel7.Location = new Point(27, 685);
            panel7.Name = "panel7";
            panel7.Size = new Size(710, 198);
            panel7.TabIndex = 41;
            // 
            // TXT_UC_PO_Follow_Up
            // 
            TXT_UC_PO_Follow_Up.BackColor = Color.White;
            TXT_UC_PO_Follow_Up.BorderStyle = BorderStyle.None;
            TXT_UC_PO_Follow_Up.Cursor = Cursors.IBeam;
            TXT_UC_PO_Follow_Up.Dock = DockStyle.Fill;
            TXT_UC_PO_Follow_Up.Font = new Font("Gotham", 11.25F);
            TXT_UC_PO_Follow_Up.Location = new Point(0, 23);
            TXT_UC_PO_Follow_Up.Multiline = true;
            TXT_UC_PO_Follow_Up.Name = "TXT_UC_PO_Follow_Up";
            TXT_UC_PO_Follow_Up.ReadOnly = true;
            TXT_UC_PO_Follow_Up.Size = new Size(708, 173);
            TXT_UC_PO_Follow_Up.TabIndex = 42;
            // 
            // label24
            // 
            label24.BackColor = Color.FromArgb(50, 50, 50);
            label24.Dock = DockStyle.Top;
            label24.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label24.ForeColor = Color.White;
            label24.Location = new Point(0, 0);
            label24.Name = "label24";
            label24.Size = new Size(708, 23);
            label24.TabIndex = 40;
            label24.Text = "Suivis du bureau Kim Phat :";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(TXT_UC_PO_Work);
            panel6.Controls.Add(label21);
            panel6.Location = new Point(26, 411);
            panel6.Name = "panel6";
            panel6.Size = new Size(710, 198);
            panel6.TabIndex = 39;
            // 
            // TXT_UC_PO_Work
            // 
            TXT_UC_PO_Work.BackColor = Color.White;
            TXT_UC_PO_Work.BorderStyle = BorderStyle.None;
            TXT_UC_PO_Work.Cursor = Cursors.IBeam;
            TXT_UC_PO_Work.Dock = DockStyle.Fill;
            TXT_UC_PO_Work.Font = new Font("Gotham", 11.25F);
            TXT_UC_PO_Work.Location = new Point(0, 23);
            TXT_UC_PO_Work.Multiline = true;
            TXT_UC_PO_Work.Name = "TXT_UC_PO_Work";
            TXT_UC_PO_Work.ReadOnly = true;
            TXT_UC_PO_Work.Size = new Size(708, 173);
            TXT_UC_PO_Work.TabIndex = 41;
            // 
            // label21
            // 
            label21.BackColor = Color.FromArgb(50, 50, 50);
            label21.Dock = DockStyle.Top;
            label21.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label21.ForeColor = Color.White;
            label21.Location = new Point(0, 0);
            label21.Name = "label21";
            label21.Size = new Size(708, 23);
            label21.TabIndex = 40;
            label21.Text = "Détails des travaux demandés :";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBL_UC_PO_E_Email
            // 
            LBL_UC_PO_E_Email.BackColor = Color.Transparent;
            LBL_UC_PO_E_Email.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_E_Email.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_E_Email.Location = new Point(232, 385);
            LBL_UC_PO_E_Email.Name = "LBL_UC_PO_E_Email";
            LBL_UC_PO_E_Email.Size = new Size(504, 23);
            LBL_UC_PO_E_Email.TabIndex = 38;
            LBL_UC_PO_E_Email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_PO_E_Number
            // 
            LBL_UC_PO_E_Number.BackColor = Color.Transparent;
            LBL_UC_PO_E_Number.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_E_Number.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_E_Number.Location = new Point(232, 362);
            LBL_UC_PO_E_Number.Name = "LBL_UC_PO_E_Number";
            LBL_UC_PO_E_Number.Size = new Size(504, 23);
            LBL_UC_PO_E_Number.TabIndex = 37;
            LBL_UC_PO_E_Number.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_PO_E_Contact
            // 
            LBL_UC_PO_E_Contact.BackColor = Color.Transparent;
            LBL_UC_PO_E_Contact.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_E_Contact.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_E_Contact.Location = new Point(232, 339);
            LBL_UC_PO_E_Contact.Name = "LBL_UC_PO_E_Contact";
            LBL_UC_PO_E_Contact.Size = new Size(504, 23);
            LBL_UC_PO_E_Contact.TabIndex = 36;
            LBL_UC_PO_E_Contact.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_PO_E_Compagny
            // 
            LBL_UC_PO_E_Compagny.BackColor = Color.Transparent;
            LBL_UC_PO_E_Compagny.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_E_Compagny.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_E_Compagny.Location = new Point(232, 316);
            LBL_UC_PO_E_Compagny.Name = "LBL_UC_PO_E_Compagny";
            LBL_UC_PO_E_Compagny.Size = new Size(504, 23);
            LBL_UC_PO_E_Compagny.TabIndex = 35;
            LBL_UC_PO_E_Compagny.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_PO_S_Email
            // 
            LBL_UC_PO_S_Email.BackColor = Color.Transparent;
            LBL_UC_PO_S_Email.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_S_Email.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_S_Email.Location = new Point(232, 272);
            LBL_UC_PO_S_Email.Name = "LBL_UC_PO_S_Email";
            LBL_UC_PO_S_Email.Size = new Size(504, 23);
            LBL_UC_PO_S_Email.TabIndex = 34;
            LBL_UC_PO_S_Email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_PO_S_Number
            // 
            LBL_UC_PO_S_Number.BackColor = Color.Transparent;
            LBL_UC_PO_S_Number.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_S_Number.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_S_Number.Location = new Point(232, 249);
            LBL_UC_PO_S_Number.Name = "LBL_UC_PO_S_Number";
            LBL_UC_PO_S_Number.Size = new Size(504, 23);
            LBL_UC_PO_S_Number.TabIndex = 33;
            LBL_UC_PO_S_Number.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label20.ForeColor = Color.FromArgb(40, 40, 40);
            label20.Location = new Point(26, 316);
            label20.Name = "label20";
            label20.Size = new Size(200, 23);
            label20.TabIndex = 32;
            label20.Text = "Compagnie :";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(40, 40, 40);
            label16.Location = new Point(26, 385);
            label16.Name = "label16";
            label16.Size = new Size(200, 23);
            label16.TabIndex = 28;
            label16.Text = "Courriel :";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(40, 40, 40);
            label17.Location = new Point(26, 362);
            label17.Name = "label17";
            label17.Size = new Size(200, 23);
            label17.TabIndex = 27;
            label17.Text = "Numéro de téléphone :";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(40, 40, 40);
            label18.Location = new Point(26, 339);
            label18.Name = "label18";
            label18.Size = new Size(200, 23);
            label18.TabIndex = 26;
            label18.Text = "Contact :";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_PO_S_Contact
            // 
            LBL_UC_PO_S_Contact.BackColor = Color.Transparent;
            LBL_UC_PO_S_Contact.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_S_Contact.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_S_Contact.Location = new Point(232, 226);
            LBL_UC_PO_S_Contact.Name = "LBL_UC_PO_S_Contact";
            LBL_UC_PO_S_Contact.Size = new Size(504, 23);
            LBL_UC_PO_S_Contact.TabIndex = 23;
            LBL_UC_PO_S_Contact.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(40, 40, 40);
            label9.Location = new Point(26, 272);
            label9.Name = "label9";
            label9.Size = new Size(200, 23);
            label9.TabIndex = 22;
            label9.Text = "Courriel :";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(40, 40, 40);
            label8.Location = new Point(26, 249);
            label8.Name = "label8";
            label8.Size = new Size(200, 23);
            label8.TabIndex = 21;
            label8.Text = "Numéro de téléphone :";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(40, 40, 40);
            label7.Location = new Point(26, 226);
            label7.Name = "label7";
            label7.Size = new Size(200, 23);
            label7.TabIndex = 20;
            label7.Text = "Contact en magasin :";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_PO_Billing_Address
            // 
            LBL_UC_PO_Billing_Address.BackColor = Color.Transparent;
            LBL_UC_PO_Billing_Address.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_Billing_Address.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_Billing_Address.Location = new Point(384, 126);
            LBL_UC_PO_Billing_Address.Name = "LBL_UC_PO_Billing_Address";
            LBL_UC_PO_Billing_Address.Size = new Size(352, 100);
            LBL_UC_PO_Billing_Address.TabIndex = 19;
            LBL_UC_PO_Billing_Address.Text = "Addresse";
            // 
            // LBL_UC_PO_Work_Address
            // 
            LBL_UC_PO_Work_Address.BackColor = Color.Transparent;
            LBL_UC_PO_Work_Address.Font = new Font("Gotham", 11.25F);
            LBL_UC_PO_Work_Address.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_PO_Work_Address.Location = new Point(26, 126);
            LBL_UC_PO_Work_Address.Name = "LBL_UC_PO_Work_Address";
            LBL_UC_PO_Work_Address.Size = new Size(352, 100);
            LBL_UC_PO_Work_Address.TabIndex = 18;
            LBL_UC_PO_Work_Address.Text = "Addresse";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(742, 88);
            panel5.Name = "panel5";
            panel5.Size = new Size(20, 899);
            panel5.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(20, 899);
            panel1.TabIndex = 16;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.Location = new Point(384, 90);
            label3.Name = "label3";
            label3.Size = new Size(352, 36);
            label3.TabIndex = 15;
            label3.Text = "Travaux facturés à";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(26, 90);
            label5.Name = "label5";
            label5.Size = new Size(352, 36);
            label5.TabIndex = 14;
            label5.Text = "Travaux effectués à";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(LBL_UC_PO_Request_Date);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(LBL_UC_PO_Id);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 4);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(762, 84);
            panel4.TabIndex = 5;
            // 
            // LBL_UC_PO_Request_Date
            // 
            LBL_UC_PO_Request_Date.BackColor = Color.Transparent;
            LBL_UC_PO_Request_Date.Dock = DockStyle.Bottom;
            LBL_UC_PO_Request_Date.Font = new Font("Gotham", 12F);
            LBL_UC_PO_Request_Date.ForeColor = Color.White;
            LBL_UC_PO_Request_Date.ImageAlign = ContentAlignment.TopCenter;
            LBL_UC_PO_Request_Date.Location = new Point(176, 49);
            LBL_UC_PO_Request_Date.Name = "LBL_UC_PO_Request_Date";
            LBL_UC_PO_Request_Date.Size = new Size(410, 35);
            LBL_UC_PO_Request_Date.TabIndex = 13;
            LBL_UC_PO_Request_Date.Text = "Date de la demande :";
            LBL_UC_PO_Request_Date.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Gotham", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.BottomLeft;
            label2.Location = new Point(176, 0);
            label2.Name = "label2";
            label2.Size = new Size(410, 45);
            label2.TabIndex = 11;
            label2.Text = "BON DE TRAVAIL";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BackgroundImage = Properties.Resources.KP_Logo;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 84);
            panel2.TabIndex = 3;
            // 
            // LBL_UC_PO_Id
            // 
            LBL_UC_PO_Id.Dock = DockStyle.Right;
            LBL_UC_PO_Id.Font = new Font("Gotham", 15.75F, FontStyle.Bold);
            LBL_UC_PO_Id.ForeColor = Color.White;
            LBL_UC_PO_Id.Location = new Point(586, 0);
            LBL_UC_PO_Id.Name = "LBL_UC_PO_Id";
            LBL_UC_PO_Id.Size = new Size(176, 84);
            LBL_UC_PO_Id.TabIndex = 12;
            LBL_UC_PO_Id.Text = "BT-";
            LBL_UC_PO_Id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(227, 15, 44);
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(762, 4);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow;
            pictureBox1.Location = new Point(396, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // TXT_Search
            // 
            TXT_Search.BackColor = Color.White;
            TXT_Search.Cursor = Cursors.IBeam;
            TXT_Search.Font = new Font("Gotham", 13F);
            TXT_Search.ForeColor = Color.FromArgb(40, 40, 40);
            TXT_Search.Location = new Point(432, 32);
            TXT_Search.Name = "TXT_Search";
            TXT_Search.Size = new Size(312, 26);
            TXT_Search.TabIndex = 9;
            TXT_Search.TextChanged += TXT_Search_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arrow;
            pictureBox2.Location = new Point(782, 529);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // PCB_UC_PO_Add
            // 
            PCB_UC_PO_Add.Cursor = Cursors.Hand;
            PCB_UC_PO_Add.Image = Properties.Resources.Edit;
            PCB_UC_PO_Add.Location = new Point(678, 983);
            PCB_UC_PO_Add.Name = "PCB_UC_PO_Add";
            PCB_UC_PO_Add.Size = new Size(30, 30);
            PCB_UC_PO_Add.SizeMode = PictureBoxSizeMode.Zoom;
            PCB_UC_PO_Add.TabIndex = 11;
            PCB_UC_PO_Add.TabStop = false;
            PCB_UC_PO_Add.Click += PCB_UC_PO_Add_Click;
            // 
            // PCB_UC_PO_Edit
            // 
            PCB_UC_PO_Edit.Cursor = Cursors.Hand;
            PCB_UC_PO_Edit.Image = Properties.Resources.Add1;
            PCB_UC_PO_Edit.Location = new Point(642, 983);
            PCB_UC_PO_Edit.Name = "PCB_UC_PO_Edit";
            PCB_UC_PO_Edit.Size = new Size(30, 30);
            PCB_UC_PO_Edit.SizeMode = PictureBoxSizeMode.Zoom;
            PCB_UC_PO_Edit.TabIndex = 12;
            PCB_UC_PO_Edit.TabStop = false;
            PCB_UC_PO_Edit.Click += PCB_UC_PO_Edit_Click;
            // 
            // PCB_UC_PO_Print
            // 
            PCB_UC_PO_Print.Cursor = Cursors.Hand;
            PCB_UC_PO_Print.Image = Properties.Resources.Print3;
            PCB_UC_PO_Print.Location = new Point(714, 983);
            PCB_UC_PO_Print.Name = "PCB_UC_PO_Print";
            PCB_UC_PO_Print.Size = new Size(30, 30);
            PCB_UC_PO_Print.SizeMode = PictureBoxSizeMode.Zoom;
            PCB_UC_PO_Print.TabIndex = 13;
            PCB_UC_PO_Print.TabStop = false;
            PCB_UC_PO_Print.Click += PCB_UC_PO_Print_Click;
            // 
            // UC_Main_PO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(PCB_UC_PO_Print);
            Controls.Add(PCB_UC_PO_Edit);
            Controls.Add(PCB_UC_PO_Add);
            Controls.Add(pictureBox2);
            Controls.Add(TXT_Search);
            Controls.Add(pictureBox1);
            Controls.Add(PNL_UC_PO_BT);
            Controls.Add(label1);
            Controls.Add(DGV_UC_PO);
            Name = "UC_Main_PO";
            Size = new Size(1634, 1037);
            Load += UC_Main_PO_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_UC_PO).EndInit();
            PNL_UC_PO_BT.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_PO_Add).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_PO_Edit).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_PO_Print).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGV_UC_PO;
        private Panel PNL_UC_PO_BT;
        private PictureBox pictureBox1;
        private TextBox TXT_Search;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label LBL_UC_PO_Id;
        private PictureBox PCB_UC_PO_Add;
        private PictureBox PCB_UC_PO_Edit;
        private Label LBL_UC_PO_Request_Date;
        private Panel panel1;
        private Label label3;
        private Label label5;
        private Panel panel5;
        private Label LBL_UC_PO_Billing_Address;
        private Label LBL_UC_PO_Work_Address;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label LBL_UC_PO_E_Email;
        private Label LBL_UC_PO_E_Number;
        private Label LBL_UC_PO_E_Contact;
        private Label LBL_UC_PO_E_Compagny;
        private Label LBL_UC_PO_S_Email;
        private Label LBL_UC_PO_S_Number;
        private Label label20;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label LBL_UC_PO_S_Contact;
        private Panel panel6;
        private Label label21;
        private Panel panel7;
        private Label label24;
        private TextBox TXT_UC_PO_Follow_Up;
        private TextBox TXT_UC_PO_Work;
        private Label LBL_UC_PO_Additional;
        private Label LBL_UC_PO_Submission;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label LBL_UC_PO_Created_By;
        private Label LBL_UC_PO_Approved_By;
        private PictureBox PCB_UC_PO_Print;
    }
}
