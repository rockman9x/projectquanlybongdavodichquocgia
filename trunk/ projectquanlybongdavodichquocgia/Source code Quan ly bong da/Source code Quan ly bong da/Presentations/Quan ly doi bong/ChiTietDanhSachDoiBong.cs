using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities;
using BLL;
using DALayer;
using Utilities;

namespace Presentations
{
    public partial class ChiTietDanhSachDoiBong : UserControl
    {
        QuanLyDB_BLL ql = new QuanLyDB_BLL();

        public ChiTietDanhSachDoiBong()
        {
            InitializeComponent();
        }

        // public DoiBong GetValueForm()
        //{
        //    DoiBong db = new DoiBong();
        //    db.Madb = this.tbMaDB.Text.ToUpper();
        //    db.Tendb = this.tbTenDB.Text;
        //    db.Masan = this.cbbMaSan.Text;
        //    db.Diachi = this.tbDiaChi.Text;
        //    return db;
        //}
        public DoiBong GetValueForm()
        {
            DoiBong db = new DoiBong();
            db.Madb = this.tbMaDB.Text.ToUpper();
            db.Tendb = this.tbTenDB.Text;
            DB_TimMaSan_dataGridView2.DataSource = ql.TimMaSanTheoTen(cbbMaSan.Text);
            db.Diachi = this.tbDiaChi.Text;

            if (DB_TimMaSan_dataGridView2[0, 0].Value != null)
                db.Masan = DB_TimMaSan_dataGridView2[0, 0].Value.ToString();
            //db.Masan = this.cbbMaSan.Text;

            return db;
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbMaDB.Text, tbTenDB.Text, cbbMaSan.Text, tbDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.");
            }
            else if (ql.Insert_DoiBong(GetValueForm()))
            {
                MessageBox.Show("Thêm thành công");
                this.LoadData();
            }
            else
            {
                MessageBox.Show("Mã đội bóng hoặc mã sân bị trùng");
            }


        }

        private void LoadData()
        {
            //string s = "select * from DoiBong";
            //dataGridView1.DataSource = ql.DSDoiBong(SQLProvider.GetAll("Doibong"));
            dataGridView1.DataSource = ql.LoaDBBi("LoadDB");
            LoadComboboxMaSan();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int vitricot = dataGridView1.Rows.IndexOf(row);
                tbMaDB.Text = dataGridView1[0, vitricot].Value.ToString();
                tbMaDB.Enabled = false;
                tbTenDB.Text = dataGridView1[1, vitricot].Value.ToString();
                cbbMaSan.Text = dataGridView1[2, vitricot].Value.ToString();
                tbDiaChi.Text = dataGridView1[3, vitricot].Value.ToString();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbMaDB.Text))
            {
                MessageBox.Show("Bạn chưa chọn đội bóng để xoá");
            }
            else if (ql.Delete_DoiBong(GetValueForm()))
            {
                MessageBox.Show("Xoá thành công");
                this.LoadData();
            }
            else
            {
                MessageBox.Show("Xoá không thành công");
            }
        }

        private void ChiTietDanhSachDoiBong_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            tbMaDB.Text = "";
            tbTenDB.Text = "";
            tbDiaChi.Text = "";
            cbbMaSan.Text = "";
            tbMaDB.Enabled = true;
            this.LoadData();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbMaDB.Text))
            {
                MessageBox.Show("Bạn chưa chọn đội bóng để sửa");
            }
            else
            {
                ql.Update_DoiBong(GetValueForm());
                MessageBox.Show("Sửa thành công");
                this.LoadData();
            }
        }

        //Lấy ma san từ bảng san vào comboboxmasan
        public void LoadComboboxMaSan()
        {
            ql.MaSan(cbbMaSan);
        }

        private void cbbMaSan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }




    }
}
