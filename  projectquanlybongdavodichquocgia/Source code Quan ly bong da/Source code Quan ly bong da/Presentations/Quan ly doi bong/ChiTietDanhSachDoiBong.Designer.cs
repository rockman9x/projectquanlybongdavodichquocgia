namespace Presentations
{
    partial class ChiTietDanhSachDoiBong
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbMaSan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbTenDB = new System.Windows.Forms.TextBox();
            this.tbMaDB = new System.Windows.Forms.TextBox();
            this.DB_TimMaSan_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btDangKy = new System.Windows.Forms.Button();
            this.dOIBONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TimMaSan_dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOIBONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(629, 264);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // cbbMaSan
            // 
            this.cbbMaSan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbbMaSan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaSan.FormattingEnabled = true;
            this.cbbMaSan.Location = new System.Drawing.Point(179, 83);
            this.cbbMaSan.Name = "cbbMaSan";
            this.cbbMaSan.Size = new System.Drawing.Size(201, 30);
            this.cbbMaSan.TabIndex = 3;
            this.cbbMaSan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaSan_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(54, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mã sân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(54, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(54, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên đội bóng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã đội bóng:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbDiaChi.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(179, 116);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(201, 29);
            this.tbDiaChi.TabIndex = 4;
            // 
            // tbTenDB
            // 
            this.tbTenDB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTenDB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenDB.Location = new System.Drawing.Point(179, 51);
            this.tbTenDB.Name = "tbTenDB";
            this.tbTenDB.Size = new System.Drawing.Size(201, 29);
            this.tbTenDB.TabIndex = 2;
            // 
            // tbMaDB
            // 
            this.tbMaDB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbMaDB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaDB.Location = new System.Drawing.Point(179, 17);
            this.tbMaDB.Name = "tbMaDB";
            this.tbMaDB.Size = new System.Drawing.Size(201, 29);
            this.tbMaDB.TabIndex = 1;
            // 
            // DB_TimMaSan_dataGridView2
            // 
            this.DB_TimMaSan_dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.DB_TimMaSan_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DB_TimMaSan_dataGridView2.Location = new System.Drawing.Point(629, 411);
            this.DB_TimMaSan_dataGridView2.Name = "DB_TimMaSan_dataGridView2";
            this.DB_TimMaSan_dataGridView2.Size = new System.Drawing.Size(11, 11);
            this.DB_TimMaSan_dataGridView2.TabIndex = 29;
            this.DB_TimMaSan_dataGridView2.Visible = false;
            // 
            // btRefresh
            // 
            this.btRefresh.BackgroundImage = global::Presentations.Properties.Resources.button;
            this.btRefresh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRefresh.Location = new System.Drawing.Point(459, 112);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(105, 28);
            this.btRefresh.TabIndex = 0;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btSua
            // 
            this.btSua.BackgroundImage = global::Presentations.Properties.Resources.button;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSua.Location = new System.Drawing.Point(459, 80);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(105, 28);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Cập nhật";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackgroundImage = global::Presentations.Properties.Resources.button;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.Location = new System.Drawing.Point(459, 47);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(105, 28);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btDangKy
            // 
            this.btDangKy.BackgroundImage = global::Presentations.Properties.Resources.button;
            this.btDangKy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDangKy.Location = new System.Drawing.Point(459, 13);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(105, 28);
            this.btDangKy.TabIndex = 0;
            this.btDangKy.Text = "Đăng ký";
            this.btDangKy.UseVisualStyleBackColor = true;
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // dOIBONGBindingSource
            // 
            this.dOIBONGBindingSource.DataMember = "DOIBONG";
            // 
            // ChiTietDanhSachDoiBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DB_TimMaSan_dataGridView2);
            this.Controls.Add(this.cbbMaSan);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbTenDB);
            this.Controls.Add(this.tbMaDB);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btDangKy);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ChiTietDanhSachDoiBong";
            this.Size = new System.Drawing.Size(654, 435);
            this.Load += new System.EventHandler(this.ChiTietDanhSachDoiBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TimMaSan_dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOIBONGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbMaSan;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbTenDB;
        private System.Windows.Forms.TextBox tbMaDB;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dOIBONGBindingSource;
        private System.Windows.Forms.DataGridView DB_TimMaSan_dataGridView2;

    }
}
