namespace Presentations
{
    partial class TraCuu
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
            this.cbbChon = new System.Windows.Forms.ComboBox();
            this.btTim = new System.Windows.Forms.Button();
            this.tbTuKhoa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbChon
            // 
            this.cbbChon.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbbChon.FormattingEnabled = true;
            this.cbbChon.Items.AddRange(new object[] {
            "Đội bóng",
            "Cầu Thủ",
            "Trọng tài",
            "Sân",
            "Kết quả trận đấu",
            "Lịch thi đấu"});
            this.cbbChon.Location = new System.Drawing.Point(248, 22);
            this.cbbChon.Name = "cbbChon";
            this.cbbChon.Size = new System.Drawing.Size(121, 29);
            this.cbbChon.TabIndex = 1;
            this.cbbChon.Text = "       Chọn";
            this.cbbChon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbChon_KeyPress);
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTim.BackgroundImage = global::Presentations.Properties.Resources.button;
            this.btTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.ForeColor = System.Drawing.Color.Cornsilk;
            this.btTim.Location = new System.Drawing.Point(394, 20);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(121, 33);
            this.btTim.TabIndex = 2;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            this.btTim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btTim_KeyPress);
            // 
            // tbTuKhoa
            // 
            this.tbTuKhoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTuKhoa.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbTuKhoa.Location = new System.Drawing.Point(16, 22);
            this.tbTuKhoa.Name = "tbTuKhoa";
            this.tbTuKhoa.Size = new System.Drawing.Size(210, 29);
            this.tbTuKhoa.TabIndex = 0;
            this.tbTuKhoa.Text = "Từ Khoá";
            this.tbTuKhoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            this.tbTuKhoa.Click += new System.EventHandler(this.tbTuKhoa_Click);
            this.tbTuKhoa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbTuKhoa_MouseDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 362);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = ">>>Gõ Tiếng Việt có dấu để tìm kiếm chính xác\r\n";
            // 
            // TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTuKhoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.cbbChon);
            this.Name = "TraCuu";
            this.Size = new System.Drawing.Size(654, 468);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbChon;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox tbTuKhoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}
