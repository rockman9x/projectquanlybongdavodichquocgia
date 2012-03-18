namespace Presentations
{
    partial class QuanLyDoiBong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDoiBong));
            this.tabDoiBong = new System.Windows.Forms.TabControl();
            this.tabDB = new System.Windows.Forms.TabPage();
            this.lbChiTietDSCT = new System.Windows.Forms.Label();
            this.lbChiTietDSDB = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSân = new System.Windows.Forms.TabPage();
            this.dataGridView1_san = new System.Windows.Forms.DataGridView();
            this.lbsucchua = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbtensan = new System.Windows.Forms.Label();
            this.tbsucchua = new System.Windows.Forms.TextBox();
            this.lbmasan = new System.Windows.Forms.Label();
            this.tbtensan = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.tbmasan = new System.Windows.Forms.TextBox();
            this.btrefesh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btxoasan = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.tabBHL = new System.Windows.Forms.TabPage();
            this.BHL_MaDB_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2_BHL = new System.Windows.Forms.DataGridView();
            this.cbbMaDB_BHL = new System.Windows.Forms.ComboBox();
            this.cbbchucvuhlv = new System.Windows.Forms.ComboBox();
            this.btchucvu = new System.Windows.Forms.Label();
            this.bthoten = new System.Windows.Forms.Label();
            this.btmadoibong = new System.Windows.Forms.Label();
            this.btmabanhuanluyen = new System.Windows.Forms.Label();
            this.tbhoten = new System.Windows.Forms.TextBox();
            this.tbmabhl = new System.Windows.Forms.TextBox();
            this.btthembhl = new System.Windows.Forms.Button();
            this.btxoabhl = new System.Windows.Forms.Button();
            this.btcapnhatbhl = new System.Windows.Forms.Button();
            this.btrefeshbhl = new System.Windows.Forms.Button();
            this.sANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBongDaDataSet1 = new Presentations.Data.QuanLyBongDaDataSet();
            this.bHLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sANTableAdapter1 = new Presentations.Data.QuanLyBongDaDataSetTableAdapters.SANTableAdapter();
            this.bHLTableAdapter = new Presentations.Data.QuanLyBongDaDataSetTableAdapters.BHLTableAdapter();
            this.sANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bHLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kETQUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDoiBong.SuspendLayout();
            this.tabDB.SuspendLayout();
            this.tabSân.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_san)).BeginInit();
            this.tabBHL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BHL_MaDB_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_BHL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBongDaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kETQUABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDoiBong
            // 
            this.tabDoiBong.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabDoiBong.Controls.Add(this.tabDB);
            this.tabDoiBong.Controls.Add(this.tabSân);
            this.tabDoiBong.Controls.Add(this.tabBHL);
            this.tabDoiBong.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabDoiBong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDoiBong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDoiBong.Location = new System.Drawing.Point(0, 0);
            this.tabDoiBong.Name = "tabDoiBong";
            this.tabDoiBong.SelectedIndex = 0;
            this.tabDoiBong.Size = new System.Drawing.Size(654, 468);
            this.tabDoiBong.TabIndex = 0;
            this.tabDoiBong.Tag = "";
            this.tabDoiBong.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabDoiBong_Selected);
            // 
            // tabDB
            // 
            this.tabDB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabDB.Controls.Add(this.lbChiTietDSCT);
            this.tabDB.Controls.Add(this.lbChiTietDSDB);
            this.tabDB.Controls.Add(this.richTextBox2);
            this.tabDB.Controls.Add(this.richTextBox1);
            this.tabDB.Controls.Add(this.label2);
            this.tabDB.Controls.Add(this.label1);
            this.tabDB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDB.ForeColor = System.Drawing.Color.Green;
            this.tabDB.Location = new System.Drawing.Point(4, 33);
            this.tabDB.Name = "tabDB";
            this.tabDB.Padding = new System.Windows.Forms.Padding(3);
            this.tabDB.Size = new System.Drawing.Size(646, 431);
            this.tabDB.TabIndex = 0;
            this.tabDB.Text = "Đội Bóng";
            // 
            // lbChiTietDSCT
            // 
            this.lbChiTietDSCT.AutoSize = true;
            this.lbChiTietDSCT.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietDSCT.Location = new System.Drawing.Point(15, 267);
            this.lbChiTietDSCT.Name = "lbChiTietDSCT";
            this.lbChiTietDSCT.Size = new System.Drawing.Size(83, 22);
            this.lbChiTietDSCT.TabIndex = 2;
            this.lbChiTietDSCT.Text = "Chi tiết...";
            this.lbChiTietDSCT.MouseLeave += new System.EventHandler(this.lbChiTietDSDB_MouseLeave);
            this.lbChiTietDSCT.Click += new System.EventHandler(this.lbChiTietDSCT_Click_1);
            this.lbChiTietDSCT.MouseEnter += new System.EventHandler(this.lbChiTietDSDB_MouseEnter);
            // 
            // lbChiTietDSDB
            // 
            this.lbChiTietDSDB.AutoSize = true;
            this.lbChiTietDSDB.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietDSDB.Location = new System.Drawing.Point(15, 105);
            this.lbChiTietDSDB.Name = "lbChiTietDSDB";
            this.lbChiTietDSDB.Size = new System.Drawing.Size(83, 22);
            this.lbChiTietDSDB.TabIndex = 2;
            this.lbChiTietDSDB.Text = "Chi tiết...";
            this.lbChiTietDSDB.MouseLeave += new System.EventHandler(this.lbChiTietDSDB_MouseLeave);
            this.lbChiTietDSDB.Click += new System.EventHandler(this.lbChiTietDSDB_Click_1);
            this.lbChiTietDSDB.MouseEnter += new System.EventHandler(this.lbChiTietDSDB_MouseEnter);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(18, 220);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(498, 97);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Danh sách cầu thủ liệt kê các cầu thủ trong đội. Trong danh sách, bạn có thể thêm" +
                ", xoá hay cập nhật thêm thông tin về cầu thủ.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(18, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(603, 118);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = ">>Danh sách cầu thủ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = ">>Danh sách đội bóng";
            // 
            // tabSân
            // 
            this.tabSân.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabSân.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabSân.Controls.Add(this.dataGridView1_san);
            this.tabSân.Controls.Add(this.lbsucchua);
            this.tabSân.Controls.Add(this.lbdiachi);
            this.tabSân.Controls.Add(this.lbtensan);
            this.tabSân.Controls.Add(this.tbsucchua);
            this.tabSân.Controls.Add(this.lbmasan);
            this.tabSân.Controls.Add(this.tbtensan);
            this.tabSân.Controls.Add(this.tbdiachi);
            this.tabSân.Controls.Add(this.tbmasan);
            this.tabSân.Controls.Add(this.btrefesh);
            this.tabSân.Controls.Add(this.button1);
            this.tabSân.Controls.Add(this.btxoasan);
            this.tabSân.Controls.Add(this.btthem);
            this.tabSân.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabSân.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSân.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabSân.Location = new System.Drawing.Point(4, 33);
            this.tabSân.Name = "tabSân";
            this.tabSân.Padding = new System.Windows.Forms.Padding(3);
            this.tabSân.Size = new System.Drawing.Size(646, 431);
            this.tabSân.TabIndex = 1;
            this.tabSân.Text = "Sân";
            // 
            // dataGridView1_san
            // 
            this.dataGridView1_san.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1_san.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1_san.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_san.Location = new System.Drawing.Point(8, 186);
            this.dataGridView1_san.Name = "dataGridView1_san";
            this.dataGridView1_san.Size = new System.Drawing.Size(625, 238);
            this.dataGridView1_san.TabIndex = 6;
            this.dataGridView1_san.Click += new System.EventHandler(this.dataGridView1_san_Click);
            // 
            // lbsucchua
            // 
            this.lbsucchua.AutoSize = true;
            this.lbsucchua.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbsucchua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsucchua.Location = new System.Drawing.Point(80, 133);
            this.lbsucchua.Name = "lbsucchua";
            this.lbsucchua.Size = new System.Drawing.Size(81, 21);
            this.lbsucchua.TabIndex = 4;
            this.lbsucchua.Text = "Sức chứa";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbdiachi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiachi.Location = new System.Drawing.Point(80, 98);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(65, 21);
            this.lbdiachi.TabIndex = 3;
            this.lbdiachi.Text = "Địa chỉ";
            // 
            // lbtensan
            // 
            this.lbtensan.AutoSize = true;
            this.lbtensan.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbtensan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtensan.Location = new System.Drawing.Point(80, 28);
            this.lbtensan.Name = "lbtensan";
            this.lbtensan.Size = new System.Drawing.Size(69, 21);
            this.lbtensan.TabIndex = 2;
            this.lbtensan.Text = "Tên sân";
            // 
            // tbsucchua
            // 
            this.tbsucchua.BackColor = System.Drawing.Color.White;
            this.tbsucchua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsucchua.Location = new System.Drawing.Point(179, 130);
            this.tbsucchua.Name = "tbsucchua";
            this.tbsucchua.Size = new System.Drawing.Size(177, 29);
            this.tbsucchua.TabIndex = 3;
            this.tbsucchua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsucchua_KeyPress);
            // 
            // lbmasan
            // 
            this.lbmasan.AutoSize = true;
            this.lbmasan.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbmasan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmasan.Location = new System.Drawing.Point(80, 62);
            this.lbmasan.Name = "lbmasan";
            this.lbmasan.Size = new System.Drawing.Size(64, 21);
            this.lbmasan.TabIndex = 2;
            this.lbmasan.Text = "Mã sân";
            // 
            // tbtensan
            // 
            this.tbtensan.BackColor = System.Drawing.Color.White;
            this.tbtensan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtensan.Location = new System.Drawing.Point(179, 25);
            this.tbtensan.Name = "tbtensan";
            this.tbtensan.Size = new System.Drawing.Size(177, 29);
            this.tbtensan.TabIndex = 1;
            // 
            // tbdiachi
            // 
            this.tbdiachi.BackColor = System.Drawing.Color.White;
            this.tbdiachi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdiachi.Location = new System.Drawing.Point(179, 95);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(177, 29);
            this.tbdiachi.TabIndex = 4;
            // 
            // tbmasan
            // 
            this.tbmasan.BackColor = System.Drawing.Color.White;
            this.tbmasan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmasan.Location = new System.Drawing.Point(179, 59);
            this.tbmasan.Name = "tbmasan";
            this.tbmasan.Size = new System.Drawing.Size(177, 29);
            this.tbmasan.TabIndex = 2;
            // 
            // btrefesh
            // 
            this.btrefesh.ForeColor = System.Drawing.Color.White;
            this.btrefesh.Image = ((System.Drawing.Image)(resources.GetObject("btrefesh.Image")));
            this.btrefesh.Location = new System.Drawing.Point(480, 129);
            this.btrefesh.Name = "btrefesh";
            this.btrefesh.Size = new System.Drawing.Size(90, 29);
            this.btrefesh.TabIndex = 0;
            this.btrefesh.Text = "Refresh";
            this.btrefesh.UseVisualStyleBackColor = true;
            this.btrefesh.Click += new System.EventHandler(this.btrefesh_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(480, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // btxoasan
            // 
            this.btxoasan.ForeColor = System.Drawing.Color.White;
            this.btxoasan.Image = ((System.Drawing.Image)(resources.GetObject("btxoasan.Image")));
            this.btxoasan.Location = new System.Drawing.Point(480, 59);
            this.btxoasan.Name = "btxoasan";
            this.btxoasan.Size = new System.Drawing.Size(90, 29);
            this.btxoasan.TabIndex = 0;
            this.btxoasan.Text = "Xoá";
            this.btxoasan.UseVisualStyleBackColor = true;
            this.btxoasan.Click += new System.EventHandler(this.XoaSan_Click);
            // 
            // btthem
            // 
            this.btthem.ForeColor = System.Drawing.Color.White;
            this.btthem.Image = ((System.Drawing.Image)(resources.GetObject("btthem.Image")));
            this.btthem.Location = new System.Drawing.Point(480, 19);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(90, 29);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // tabBHL
            // 
            this.tabBHL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabBHL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabBHL.Controls.Add(this.BHL_MaDB_dataGridView1);
            this.tabBHL.Controls.Add(this.dataGridView2_BHL);
            this.tabBHL.Controls.Add(this.cbbMaDB_BHL);
            this.tabBHL.Controls.Add(this.cbbchucvuhlv);
            this.tabBHL.Controls.Add(this.btchucvu);
            this.tabBHL.Controls.Add(this.bthoten);
            this.tabBHL.Controls.Add(this.btmadoibong);
            this.tabBHL.Controls.Add(this.btmabanhuanluyen);
            this.tabBHL.Controls.Add(this.tbhoten);
            this.tabBHL.Controls.Add(this.tbmabhl);
            this.tabBHL.Controls.Add(this.btthembhl);
            this.tabBHL.Controls.Add(this.btxoabhl);
            this.tabBHL.Controls.Add(this.btcapnhatbhl);
            this.tabBHL.Controls.Add(this.btrefeshbhl);
            this.tabBHL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBHL.ForeColor = System.Drawing.Color.Green;
            this.tabBHL.Location = new System.Drawing.Point(4, 33);
            this.tabBHL.Name = "tabBHL";
            this.tabBHL.Size = new System.Drawing.Size(646, 431);
            this.tabBHL.TabIndex = 2;
            this.tabBHL.Text = "Ban huấn luyện";
            // 
            // BHL_MaDB_dataGridView1
            // 
            this.BHL_MaDB_dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.BHL_MaDB_dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BHL_MaDB_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BHL_MaDB_dataGridView1.Location = new System.Drawing.Point(621, 406);
            this.BHL_MaDB_dataGridView1.Name = "BHL_MaDB_dataGridView1";
            this.BHL_MaDB_dataGridView1.Size = new System.Drawing.Size(10, 11);
            this.BHL_MaDB_dataGridView1.TabIndex = 6;
            this.BHL_MaDB_dataGridView1.Visible = false;
            // 
            // dataGridView2_BHL
            // 
            this.dataGridView2_BHL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2_BHL.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2_BHL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2_BHL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_BHL.Location = new System.Drawing.Point(12, 194);
            this.dataGridView2_BHL.Name = "dataGridView2_BHL";
            this.dataGridView2_BHL.Size = new System.Drawing.Size(619, 223);
            this.dataGridView2_BHL.TabIndex = 8;
            this.dataGridView2_BHL.Click += new System.EventHandler(this.dataGridView2_BHL_Click);
            // 
            // cbbMaDB_BHL
            // 
            this.cbbMaDB_BHL.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaDB_BHL.FormattingEnabled = true;
            this.cbbMaDB_BHL.Location = new System.Drawing.Point(169, 138);
            this.cbbMaDB_BHL.Name = "cbbMaDB_BHL";
            this.cbbMaDB_BHL.Size = new System.Drawing.Size(209, 29);
            this.cbbMaDB_BHL.TabIndex = 3;
            this.cbbMaDB_BHL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaDB_BHL_KeyPress);
            // 
            // cbbchucvuhlv
            // 
            this.cbbchucvuhlv.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbchucvuhlv.FormattingEnabled = true;
            this.cbbchucvuhlv.Items.AddRange(new object[] {
            "Huấn luyện viên trưởng",
            "Huấn luyện viên phó",
            "Trợ lý "});
            this.cbbchucvuhlv.Location = new System.Drawing.Point(169, 96);
            this.cbbchucvuhlv.Name = "cbbchucvuhlv";
            this.cbbchucvuhlv.Size = new System.Drawing.Size(209, 29);
            this.cbbchucvuhlv.TabIndex = 2;
            this.cbbchucvuhlv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaDB_BHL_KeyPress);
            // 
            // btchucvu
            // 
            this.btchucvu.AutoSize = true;
            this.btchucvu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchucvu.Location = new System.Drawing.Point(39, 99);
            this.btchucvu.Name = "btchucvu";
            this.btchucvu.Size = new System.Drawing.Size(74, 21);
            this.btchucvu.TabIndex = 2;
            this.btchucvu.Text = "Chức vụ";
            // 
            // bthoten
            // 
            this.bthoten.AutoSize = true;
            this.bthoten.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthoten.Location = new System.Drawing.Point(39, 24);
            this.bthoten.Name = "bthoten";
            this.bthoten.Size = new System.Drawing.Size(82, 21);
            this.bthoten.TabIndex = 2;
            this.bthoten.Text = "Họ và tên";
            // 
            // btmadoibong
            // 
            this.btmadoibong.AutoSize = true;
            this.btmadoibong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmadoibong.Location = new System.Drawing.Point(39, 146);
            this.btmadoibong.Name = "btmadoibong";
            this.btmadoibong.Size = new System.Drawing.Size(81, 21);
            this.btmadoibong.TabIndex = 2;
            this.btmadoibong.Text = "Đội bóng";
            // 
            // btmabanhuanluyen
            // 
            this.btmabanhuanluyen.AutoSize = true;
            this.btmabanhuanluyen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmabanhuanluyen.Location = new System.Drawing.Point(39, 61);
            this.btmabanhuanluyen.Name = "btmabanhuanluyen";
            this.btmabanhuanluyen.Size = new System.Drawing.Size(75, 21);
            this.btmabanhuanluyen.TabIndex = 2;
            this.btmabanhuanluyen.Text = "Mã BHL";
            // 
            // tbhoten
            // 
            this.tbhoten.BackColor = System.Drawing.Color.White;
            this.tbhoten.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhoten.Location = new System.Drawing.Point(170, 16);
            this.tbhoten.Name = "tbhoten";
            this.tbhoten.Size = new System.Drawing.Size(208, 29);
            this.tbhoten.TabIndex = 0;
            this.tbhoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbhoten_KeyPress);
            // 
            // tbmabhl
            // 
            this.tbmabhl.BackColor = System.Drawing.Color.White;
            this.tbmabhl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmabhl.Location = new System.Drawing.Point(170, 55);
            this.tbmabhl.Name = "tbmabhl";
            this.tbmabhl.Size = new System.Drawing.Size(208, 29);
            this.tbmabhl.TabIndex = 1;
            // 
            // btthembhl
            // 
            this.btthembhl.ForeColor = System.Drawing.Color.White;
            this.btthembhl.Image = ((System.Drawing.Image)(resources.GetObject("btthembhl.Image")));
            this.btthembhl.Location = new System.Drawing.Point(443, 17);
            this.btthembhl.Name = "btthembhl";
            this.btthembhl.Size = new System.Drawing.Size(90, 29);
            this.btthembhl.TabIndex = 4;
            this.btthembhl.Text = "Thêm";
            this.btthembhl.UseVisualStyleBackColor = true;
            this.btthembhl.Click += new System.EventHandler(this.btthembhl_Click);
            // 
            // btxoabhl
            // 
            this.btxoabhl.ForeColor = System.Drawing.Color.White;
            this.btxoabhl.Image = ((System.Drawing.Image)(resources.GetObject("btxoabhl.Image")));
            this.btxoabhl.Location = new System.Drawing.Point(443, 57);
            this.btxoabhl.Name = "btxoabhl";
            this.btxoabhl.Size = new System.Drawing.Size(90, 29);
            this.btxoabhl.TabIndex = 5;
            this.btxoabhl.Text = "Xoá";
            this.btxoabhl.UseVisualStyleBackColor = true;
            this.btxoabhl.Click += new System.EventHandler(this.btxoabhl_Click);
            // 
            // btcapnhatbhl
            // 
            this.btcapnhatbhl.ForeColor = System.Drawing.Color.White;
            this.btcapnhatbhl.Image = ((System.Drawing.Image)(resources.GetObject("btcapnhatbhl.Image")));
            this.btcapnhatbhl.Location = new System.Drawing.Point(443, 94);
            this.btcapnhatbhl.Name = "btcapnhatbhl";
            this.btcapnhatbhl.Size = new System.Drawing.Size(90, 29);
            this.btcapnhatbhl.TabIndex = 6;
            this.btcapnhatbhl.Text = "Cập nhật";
            this.btcapnhatbhl.UseVisualStyleBackColor = true;
            this.btcapnhatbhl.Click += new System.EventHandler(this.btcapnhatbhl_Click);
            // 
            // btrefeshbhl
            // 
            this.btrefeshbhl.ForeColor = System.Drawing.Color.White;
            this.btrefeshbhl.Image = ((System.Drawing.Image)(resources.GetObject("btrefeshbhl.Image")));
            this.btrefeshbhl.Location = new System.Drawing.Point(443, 135);
            this.btrefeshbhl.Name = "btrefeshbhl";
            this.btrefeshbhl.Size = new System.Drawing.Size(90, 29);
            this.btrefeshbhl.TabIndex = 7;
            this.btrefeshbhl.Text = "Refresh";
            this.btrefeshbhl.UseVisualStyleBackColor = true;
            this.btrefeshbhl.Click += new System.EventHandler(this.btrefeshbhl_Click);
            // 
            // sANBindingSource1
            // 
            this.sANBindingSource1.DataMember = "SAN";
            this.sANBindingSource1.DataSource = this.quanLyBongDaDataSet1;
            // 
            // quanLyBongDaDataSet1
            // 
            this.quanLyBongDaDataSet1.DataSetName = "QuanLyBongDaDataSet";
            this.quanLyBongDaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bHLBindingSource1
            // 
            this.bHLBindingSource1.DataMember = "BHL";
            this.bHLBindingSource1.DataSource = this.quanLyBongDaDataSet1;
            // 
            // sANTableAdapter1
            // 
            this.sANTableAdapter1.ClearBeforeFill = true;
            // 
            // bHLTableAdapter
            // 
            this.bHLTableAdapter.ClearBeforeFill = true;
            // 
            // sANBindingSource
            // 
            this.sANBindingSource.DataMember = "SAN";
            // 
            // bHLBindingSource
            // 
            this.bHLBindingSource.DataMember = "BHL";
            // 
            // kETQUABindingSource
            // 
            this.kETQUABindingSource.DataMember = "KETQUA";
            // 
            // QuanLyDoiBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabDoiBong);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "QuanLyDoiBong";
            this.Size = new System.Drawing.Size(654, 468);
            this.tabDoiBong.ResumeLayout(false);
            this.tabDB.ResumeLayout(false);
            this.tabDB.PerformLayout();
            this.tabSân.ResumeLayout(false);
            this.tabSân.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_san)).EndInit();
            this.tabBHL.ResumeLayout(false);
            this.tabBHL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BHL_MaDB_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_BHL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBongDaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kETQUABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDoiBong;
        private System.Windows.Forms.TabPage tabDB;
        private System.Windows.Forms.TabPage tabSân;
        private System.Windows.Forms.TabPage tabBHL;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbChiTietDSCT;
        private System.Windows.Forms.Label lbChiTietDSDB;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtensan;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.Button btxoasan;
        private System.Windows.Forms.TextBox tbmasan;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label lbsucchua;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbtensan;
        private System.Windows.Forms.TextBox tbsucchua;
        private System.Windows.Forms.Label lbmasan;
        private System.Windows.Forms.DataGridView dataGridView1_san;
        private System.Windows.Forms.Button btrefesh;
        private System.Windows.Forms.Label bthoten;
        private System.Windows.Forms.Label btmadoibong;
        private System.Windows.Forms.Label btmabanhuanluyen;
        private System.Windows.Forms.TextBox tbhoten;
        private System.Windows.Forms.TextBox tbmabhl;
        private System.Windows.Forms.Button btthembhl;
        private System.Windows.Forms.Button btxoabhl;
        private System.Windows.Forms.Button btcapnhatbhl;
        private System.Windows.Forms.Button btrefeshbhl;
        private System.Windows.Forms.ComboBox cbbchucvuhlv;
        private System.Windows.Forms.Label btchucvu;
        private System.Windows.Forms.DataGridView dataGridView2_BHL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbMaDB_BHL;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBHLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bHLBindingSource;
        private System.Windows.Forms.BindingSource sANBindingSource;
        private System.Windows.Forms.BindingSource kETQUABindingSource;
        private System.Windows.Forms.BindingSource sANBindingSource1;
        private Presentations.Data.QuanLyBongDaDataSet quanLyBongDaDataSet1;
        private System.Windows.Forms.BindingSource bHLBindingSource1;
        private Presentations.Data.QuanLyBongDaDataSetTableAdapters.SANTableAdapter sANTableAdapter1;
        private Presentations.Data.QuanLyBongDaDataSetTableAdapters.BHLTableAdapter bHLTableAdapter;
        private System.Windows.Forms.DataGridView BHL_MaDB_dataGridView1;

    }
}
