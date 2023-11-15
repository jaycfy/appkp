namespace Kimphat
{
    partial class UC_Main_Products
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DGV_UC_Products = new DataGridView();
            label1 = new Label();
            CKB_UC_Products_See_Mine = new CheckBox();
            TXT_Search = new TextBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            PNL_UC_Products = new Panel();
            LBL_UC_Main_Product_Category = new Label();
            label16 = new Label();
            LBL_UC_Main_Product_Family = new Label();
            label14 = new Label();
            label2 = new Label();
            label12 = new Label();
            LBL_UC_Main_Product_User = new Label();
            label13 = new Label();
            CKB_UC_Main_Product_Deposit = new CheckBox();
            CKB_UC_Main_Product_Balance = new CheckBox();
            CKB_UC_Main_Product_Taxes = new CheckBox();
            label11 = new Label();
            LBL_UC_Main_Product_Attribut = new Label();
            LBL_UC_Main_Product_Case = new Label();
            label10 = new Label();
            LBL_UC_Main_Product_Format = new Label();
            label8 = new Label();
            LBL_UC_Main_Product_Desc = new Label();
            label9 = new Label();
            LBL_UC_Main_Product_Brand = new Label();
            label7 = new Label();
            label6 = new Label();
            LBL_UC_Main_Product_KPCode = new Label();
            label5 = new Label();
            label4 = new Label();
            PCB_UC_Product_UPC = new PictureBox();
            PCB_UC_Product_Image = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DGV_UC_Products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PNL_UC_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_Product_UPC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_Product_Image).BeginInit();
            SuspendLayout();
            // 
            // DGV_UC_Products
            // 
            DGV_UC_Products.AllowUserToAddRows = false;
            DGV_UC_Products.AllowUserToDeleteRows = false;
            DGV_UC_Products.AllowUserToOrderColumns = true;
            DGV_UC_Products.AllowUserToResizeRows = false;
            DGV_UC_Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_UC_Products.BackgroundColor = Color.White;
            DGV_UC_Products.BorderStyle = BorderStyle.None;
            DGV_UC_Products.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_UC_Products.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_UC_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_UC_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGV_UC_Products.DefaultCellStyle = dataGridViewCellStyle2;
            DGV_UC_Products.GridColor = Color.White;
            DGV_UC_Products.Location = new Point(23, 65);
            DGV_UC_Products.MultiSelect = false;
            DGV_UC_Products.Name = "DGV_UC_Products";
            DGV_UC_Products.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Gotham", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGV_UC_Products.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGV_UC_Products.RowHeadersVisible = false;
            DGV_UC_Products.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DGV_UC_Products.RowTemplate.Height = 25;
            DGV_UC_Products.RowTemplate.ReadOnly = true;
            DGV_UC_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_UC_Products.Size = new Size(1587, 522);
            DGV_UC_Products.TabIndex = 1;
            DGV_UC_Products.CellContentClick += UC_Main_Product_Selected;
            DGV_UC_Products.CellContentDoubleClick += UC_Main_Product_Selected;
            // 
            // label1
            // 
            label1.Font = new Font("Gotham", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(227, 15, 44);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(266, 37);
            label1.TabIndex = 4;
            label1.Text = "Produits";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CKB_UC_Products_See_Mine
            // 
            CKB_UC_Products_See_Mine.AutoSize = true;
            CKB_UC_Products_See_Mine.Checked = true;
            CKB_UC_Products_See_Mine.CheckState = CheckState.Checked;
            CKB_UC_Products_See_Mine.Font = new Font("Gotham", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CKB_UC_Products_See_Mine.ForeColor = Color.FromArgb(40, 40, 40);
            CKB_UC_Products_See_Mine.Location = new Point(128, 34);
            CKB_UC_Products_See_Mine.Name = "CKB_UC_Products_See_Mine";
            CKB_UC_Products_See_Mine.Size = new Size(129, 21);
            CKB_UC_Products_See_Mine.TabIndex = 5;
            CKB_UC_Products_See_Mine.Text = "Voir les miens";
            CKB_UC_Products_See_Mine.UseVisualStyleBackColor = true;
            CKB_UC_Products_See_Mine.CheckedChanged += CKB_UC_Products_See_Mine_CheckedChanged;
            // 
            // TXT_Search
            // 
            TXT_Search.BackColor = Color.White;
            TXT_Search.Cursor = Cursors.IBeam;
            TXT_Search.Font = new Font("Gotham", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TXT_Search.ForeColor = Color.FromArgb(40, 40, 40);
            TXT_Search.Location = new Point(1136, 33);
            TXT_Search.Name = "TXT_Search";
            TXT_Search.Size = new Size(474, 26);
            TXT_Search.TabIndex = 6;
            TXT_Search.TextChanged += TXT_Search_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow;
            pictureBox1.Location = new Point(1100, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(227, 15, 44);
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(23, 590);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1587, 3);
            panel3.TabIndex = 33;
            // 
            // PNL_UC_Products
            // 
            PNL_UC_Products.Controls.Add(LBL_UC_Main_Product_Category);
            PNL_UC_Products.Controls.Add(label16);
            PNL_UC_Products.Controls.Add(LBL_UC_Main_Product_Family);
            PNL_UC_Products.Controls.Add(label14);
            PNL_UC_Products.Controls.Add(label2);
            PNL_UC_Products.Controls.Add(label12);
            PNL_UC_Products.Controls.Add(LBL_UC_Main_Product_User);
            PNL_UC_Products.Controls.Add(label13);
            PNL_UC_Products.Controls.Add(CKB_UC_Main_Product_Deposit);
            PNL_UC_Products.Controls.Add(CKB_UC_Main_Product_Balance);
            PNL_UC_Products.Controls.Add(CKB_UC_Main_Product_Taxes);
            PNL_UC_Products.Controls.Add(label11);
            PNL_UC_Products.Controls.Add(LBL_UC_Main_Product_Attribut);
            PNL_UC_Products.Controls.Add(LBL_UC_Main_Product_Case);
            PNL_UC_Products.Controls.Add(label10);
            PNL_UC_Products.Controls.Add(LBL_UC_Main_Product_Format);
            PNL_UC_Products.Controls.Add(label8);
            PNL_UC_Products.Controls.Add(LBL_UC_Main_Product_Desc);
            PNL_UC_Products.Controls.Add(label9);
            PNL_UC_Products.Controls.Add(LBL_UC_Main_Product_Brand);
            PNL_UC_Products.Controls.Add(label7);
            PNL_UC_Products.Controls.Add(label6);
            PNL_UC_Products.Controls.Add(LBL_UC_Main_Product_KPCode);
            PNL_UC_Products.Controls.Add(label5);
            PNL_UC_Products.Controls.Add(label4);
            PNL_UC_Products.Controls.Add(PCB_UC_Product_UPC);
            PNL_UC_Products.Controls.Add(PCB_UC_Product_Image);
            PNL_UC_Products.Location = new Point(0, 596);
            PNL_UC_Products.Name = "PNL_UC_Products";
            PNL_UC_Products.Size = new Size(1634, 438);
            PNL_UC_Products.TabIndex = 34;
            PNL_UC_Products.Visible = false;
            // 
            // LBL_UC_Main_Product_Category
            // 
            LBL_UC_Main_Product_Category.BackColor = Color.White;
            LBL_UC_Main_Product_Category.Cursor = Cursors.IBeam;
            LBL_UC_Main_Product_Category.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_UC_Main_Product_Category.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_Main_Product_Category.Location = new Point(583, 283);
            LBL_UC_Main_Product_Category.Name = "LBL_UC_Main_Product_Category";
            LBL_UC_Main_Product_Category.Size = new Size(612, 23);
            LBL_UC_Main_Product_Category.TabIndex = 64;
            LBL_UC_Main_Product_Category.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(40, 40, 40);
            label16.Location = new Point(477, 283);
            label16.Name = "label16";
            label16.Size = new Size(110, 23);
            label16.TabIndex = 63;
            label16.Text = "Catégorie :";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_Main_Product_Family
            // 
            LBL_UC_Main_Product_Family.BackColor = Color.White;
            LBL_UC_Main_Product_Family.Cursor = Cursors.IBeam;
            LBL_UC_Main_Product_Family.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_UC_Main_Product_Family.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_Main_Product_Family.Location = new Point(583, 306);
            LBL_UC_Main_Product_Family.Name = "LBL_UC_Main_Product_Family";
            LBL_UC_Main_Product_Family.Size = new Size(612, 23);
            LBL_UC_Main_Product_Family.TabIndex = 62;
            LBL_UC_Main_Product_Family.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(40, 40, 40);
            label14.Location = new Point(477, 306);
            label14.Name = "label14";
            label14.Size = new Size(110, 23);
            label14.TabIndex = 61;
            label14.Text = "Famille :";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(1258, 17);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 60;
            label2.Text = "Promo";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(40, 40, 40);
            label12.Location = new Point(477, 372);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 59;
            label12.Text = "EAN13 :";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_Main_Product_User
            // 
            LBL_UC_Main_Product_User.BackColor = Color.White;
            LBL_UC_Main_Product_User.Cursor = Cursors.IBeam;
            LBL_UC_Main_Product_User.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_UC_Main_Product_User.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_Main_Product_User.Location = new Point(583, 237);
            LBL_UC_Main_Product_User.Name = "LBL_UC_Main_Product_User";
            LBL_UC_Main_Product_User.Size = new Size(612, 23);
            LBL_UC_Main_Product_User.TabIndex = 58;
            LBL_UC_Main_Product_User.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(40, 40, 40);
            label13.Location = new Point(477, 237);
            label13.Name = "label13";
            label13.Size = new Size(110, 23);
            label13.TabIndex = 57;
            label13.Text = "Acheteur :";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CKB_UC_Main_Product_Deposit
            // 
            CKB_UC_Main_Product_Deposit.AutoCheck = false;
            CKB_UC_Main_Product_Deposit.AutoSize = true;
            CKB_UC_Main_Product_Deposit.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CKB_UC_Main_Product_Deposit.ForeColor = Color.FromArgb(40, 40, 40);
            CKB_UC_Main_Product_Deposit.Location = new Point(1119, 398);
            CKB_UC_Main_Product_Deposit.Name = "CKB_UC_Main_Product_Deposit";
            CKB_UC_Main_Product_Deposit.Size = new Size(76, 22);
            CKB_UC_Main_Product_Deposit.TabIndex = 56;
            CKB_UC_Main_Product_Deposit.Text = "Dépôt";
            CKB_UC_Main_Product_Deposit.UseVisualStyleBackColor = true;
            // 
            // CKB_UC_Main_Product_Balance
            // 
            CKB_UC_Main_Product_Balance.AutoCheck = false;
            CKB_UC_Main_Product_Balance.AutoSize = true;
            CKB_UC_Main_Product_Balance.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CKB_UC_Main_Product_Balance.ForeColor = Color.FromArgb(40, 40, 40);
            CKB_UC_Main_Product_Balance.Location = new Point(946, 398);
            CKB_UC_Main_Product_Balance.Name = "CKB_UC_Main_Product_Balance";
            CKB_UC_Main_Product_Balance.Size = new Size(89, 22);
            CKB_UC_Main_Product_Balance.TabIndex = 55;
            CKB_UC_Main_Product_Balance.Text = "Balance";
            CKB_UC_Main_Product_Balance.UseVisualStyleBackColor = true;
            // 
            // CKB_UC_Main_Product_Taxes
            // 
            CKB_UC_Main_Product_Taxes.AutoCheck = false;
            CKB_UC_Main_Product_Taxes.AutoSize = true;
            CKB_UC_Main_Product_Taxes.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CKB_UC_Main_Product_Taxes.ForeColor = Color.FromArgb(40, 40, 40);
            CKB_UC_Main_Product_Taxes.Location = new Point(1041, 398);
            CKB_UC_Main_Product_Taxes.Name = "CKB_UC_Main_Product_Taxes";
            CKB_UC_Main_Product_Taxes.Size = new Size(72, 22);
            CKB_UC_Main_Product_Taxes.TabIndex = 54;
            CKB_UC_Main_Product_Taxes.Text = "Taxes";
            CKB_UC_Main_Product_Taxes.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(40, 40, 40);
            label11.Location = new Point(477, 53);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 53;
            label11.Text = "Attribut :";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_Main_Product_Attribut
            // 
            LBL_UC_Main_Product_Attribut.BackColor = Color.White;
            LBL_UC_Main_Product_Attribut.Cursor = Cursors.IBeam;
            LBL_UC_Main_Product_Attribut.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_UC_Main_Product_Attribut.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_Main_Product_Attribut.Location = new Point(583, 53);
            LBL_UC_Main_Product_Attribut.Name = "LBL_UC_Main_Product_Attribut";
            LBL_UC_Main_Product_Attribut.Size = new Size(612, 23);
            LBL_UC_Main_Product_Attribut.TabIndex = 52;
            LBL_UC_Main_Product_Attribut.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_Main_Product_Case
            // 
            LBL_UC_Main_Product_Case.BackColor = Color.White;
            LBL_UC_Main_Product_Case.Cursor = Cursors.IBeam;
            LBL_UC_Main_Product_Case.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_UC_Main_Product_Case.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_Main_Product_Case.Location = new Point(583, 191);
            LBL_UC_Main_Product_Case.Name = "LBL_UC_Main_Product_Case";
            LBL_UC_Main_Product_Case.Size = new Size(612, 23);
            LBL_UC_Main_Product_Case.TabIndex = 51;
            LBL_UC_Main_Product_Case.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(40, 40, 40);
            label10.Location = new Point(477, 191);
            label10.Name = "label10";
            label10.Size = new Size(110, 23);
            label10.TabIndex = 50;
            label10.Text = "Caisse :";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_Main_Product_Format
            // 
            LBL_UC_Main_Product_Format.BackColor = Color.White;
            LBL_UC_Main_Product_Format.Cursor = Cursors.IBeam;
            LBL_UC_Main_Product_Format.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_UC_Main_Product_Format.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_Main_Product_Format.Location = new Point(583, 168);
            LBL_UC_Main_Product_Format.Name = "LBL_UC_Main_Product_Format";
            LBL_UC_Main_Product_Format.Size = new Size(612, 23);
            LBL_UC_Main_Product_Format.TabIndex = 49;
            LBL_UC_Main_Product_Format.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(40, 40, 40);
            label8.Location = new Point(477, 168);
            label8.Name = "label8";
            label8.Size = new Size(110, 23);
            label8.TabIndex = 48;
            label8.Text = "Format :";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_Main_Product_Desc
            // 
            LBL_UC_Main_Product_Desc.BackColor = Color.White;
            LBL_UC_Main_Product_Desc.Cursor = Cursors.IBeam;
            LBL_UC_Main_Product_Desc.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_UC_Main_Product_Desc.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_Main_Product_Desc.Location = new Point(583, 122);
            LBL_UC_Main_Product_Desc.Name = "LBL_UC_Main_Product_Desc";
            LBL_UC_Main_Product_Desc.Size = new Size(612, 23);
            LBL_UC_Main_Product_Desc.TabIndex = 47;
            LBL_UC_Main_Product_Desc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(40, 40, 40);
            label9.Location = new Point(477, 76);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 46;
            label9.Text = "Code KP :";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_Main_Product_Brand
            // 
            LBL_UC_Main_Product_Brand.BackColor = Color.White;
            LBL_UC_Main_Product_Brand.Cursor = Cursors.IBeam;
            LBL_UC_Main_Product_Brand.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_UC_Main_Product_Brand.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_Main_Product_Brand.Location = new Point(583, 99);
            LBL_UC_Main_Product_Brand.Name = "LBL_UC_Main_Product_Brand";
            LBL_UC_Main_Product_Brand.Size = new Size(612, 23);
            LBL_UC_Main_Product_Brand.TabIndex = 45;
            LBL_UC_Main_Product_Brand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(40, 40, 40);
            label7.Location = new Point(477, 122);
            label7.Name = "label7";
            label7.Size = new Size(110, 23);
            label7.TabIndex = 44;
            label7.Text = "Description :";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(40, 40, 40);
            label6.Location = new Point(477, 99);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 43;
            label6.Text = "Marque :";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBL_UC_Main_Product_KPCode
            // 
            LBL_UC_Main_Product_KPCode.BackColor = Color.White;
            LBL_UC_Main_Product_KPCode.Cursor = Cursors.IBeam;
            LBL_UC_Main_Product_KPCode.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_UC_Main_Product_KPCode.ForeColor = Color.FromArgb(40, 40, 40);
            LBL_UC_Main_Product_KPCode.Location = new Point(583, 76);
            LBL_UC_Main_Product_KPCode.Name = "LBL_UC_Main_Product_KPCode";
            LBL_UC_Main_Product_KPCode.Size = new Size(612, 23);
            LBL_UC_Main_Product_KPCode.TabIndex = 42;
            LBL_UC_Main_Product_KPCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(477, 17);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 41;
            label5.Text = "Produit";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gotham", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.Location = new Point(23, 17);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 40;
            label4.Text = "Image";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PCB_UC_Product_UPC
            // 
            PCB_UC_Product_UPC.BackColor = Color.Transparent;
            PCB_UC_Product_UPC.Location = new Point(583, 349);
            PCB_UC_Product_UPC.Name = "PCB_UC_Product_UPC";
            PCB_UC_Product_UPC.Size = new Size(196, 71);
            PCB_UC_Product_UPC.SizeMode = PictureBoxSizeMode.Zoom;
            PCB_UC_Product_UPC.TabIndex = 39;
            PCB_UC_Product_UPC.TabStop = false;
            // 
            // PCB_UC_Product_Image
            // 
            PCB_UC_Product_Image.BackColor = Color.Transparent;
            PCB_UC_Product_Image.Location = new Point(23, 53);
            PCB_UC_Product_Image.Name = "PCB_UC_Product_Image";
            PCB_UC_Product_Image.Size = new Size(386, 367);
            PCB_UC_Product_Image.SizeMode = PictureBoxSizeMode.Zoom;
            PCB_UC_Product_Image.TabIndex = 38;
            PCB_UC_Product_Image.TabStop = false;
            // 
            // UC_Main_Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(PNL_UC_Products);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(TXT_Search);
            Controls.Add(CKB_UC_Products_See_Mine);
            Controls.Add(label1);
            Controls.Add(DGV_UC_Products);
            Name = "UC_Main_Products";
            Size = new Size(1634, 1037);
            Load += UC_Main_Products_A_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_UC_Products).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PNL_UC_Products.ResumeLayout(false);
            PNL_UC_Products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_Product_UPC).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_Product_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_UC_Products;
        private Label label1;
        private CheckBox CKB_UC_Products_See_Mine;
        private TextBox TXT_Search;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel PNL_UC_Products;
        private Label LBL_UC_Main_Product_Category;
        private Label label16;
        private Label LBL_UC_Main_Product_Family;
        private Label label14;
        private Label label2;
        private Label label12;
        private Label LBL_UC_Main_Product_User;
        private Label label13;
        private CheckBox CKB_UC_Main_Product_Deposit;
        private CheckBox CKB_UC_Main_Product_Balance;
        private CheckBox CKB_UC_Main_Product_Taxes;
        private Label label11;
        private Label LBL_UC_Main_Product_Attribut;
        private Label LBL_UC_Main_Product_Case;
        private Label label10;
        private Label LBL_UC_Main_Product_Format;
        private Label label8;
        private Label LBL_UC_Main_Product_Desc;
        private Label label9;
        private Label LBL_UC_Main_Product_Brand;
        private Label label7;
        private Label label6;
        private Label LBL_UC_Main_Product_KPCode;
        private Label label5;
        private Label label4;
        private PictureBox PCB_UC_Product_UPC;
        private PictureBox PCB_UC_Product_Image;
    }
}
