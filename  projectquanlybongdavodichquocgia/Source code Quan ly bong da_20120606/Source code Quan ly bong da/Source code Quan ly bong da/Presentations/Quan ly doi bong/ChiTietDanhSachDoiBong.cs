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
        int mode = 0;
        public ChiTietDanhSachDoiBong()
        {
            InitializeComponent();
        }


        public DoiBong GetValueForm()
        {
            DoiBong db = new DoiBong();
            if(mode == 1 || mode == 3)
            {
                int ma = dataGridView1.Rows.Count;
                if (ma > 0)
                {
                    db.Madb = dataGridView1.Rows[ma - 1].Cells[0].Value.ToString();
                }
                else
                {
                    db.Madb = "";
                }
            }
            else
            {
                db.Madb = tbMaDB.Text;
            }
            db.Tendb = this.tbTenDB.Text;
            DB_TimMaSan_dataGridView2.DataSource = ql.TimMaSanTheoTen(cbbMaSan.Text);
            db.Diachi = this.tbDiaChi.Text;

            if (DB_TimMaSan_dataGridView2[0, 0].Value != null)
            db.Masan = DB_TimMaSan_dataGridView2[0, 0].Value.ToString();
                      
            return db;
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            mode = 1;
            //this.LoadData();
            if (!DataUtils.KiemTra(tbTenDB.Text, cbbMaSan.Text, tbDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.");
            }
            else if (ql.Insert_DoiBong(GetValueForm()))
            {
                MessageBox.Show("Thêm đội bóng thành công");
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
            cbbMaSan.Items.Clear();
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
            mode = 2;
            int flg = 0;
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                DoiBong db = new DoiBong();
                db.Madb = item.Cells[0].Value.ToString();
                if (ql.Delete_DoiBong(db))
                {
                    flg = 1;
                }
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            if (flg == 1)
            {
                MessageBox.Show("Xoá đội bóng thành công");
                this.ChiTietDanhSachDoiBong_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Qúa trình thực hiện thất bại");
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
            mode = 3;
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
            //Xu ly viec chen gia tri vao combobox
            ql.MaSan(cbbMaSan);

        }

        private void cbbMaSan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }
    }
}
