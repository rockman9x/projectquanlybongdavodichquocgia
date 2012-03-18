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
using Utilities;
using DALayer;
using System.Data.SqlClient;

namespace Presentations
{
    public partial class ChiTietDanhSachCauThu : UserControl
    {
        QuanLyCT_BLL ql = new QuanLyCT_BLL();
        public ChiTietDanhSachCauThu()
        {
            InitializeComponent();
        }

        //public CauThu GetValueForm()
        //{
        //    CauThu ct = new CauThu();
        //    ct.Mact = tbmact.Text.ToUpper();
        //    ct.Madb = cbbmadb.Text;
        //    ct.Hotenct = tbhotenct.Text;
        //    ct.Ngaysinh = datetimeNgaySinh.Value.Date;
        //    ct.Gioitinh = cbbGioiTinh.Text;
        //    ct.Mavt = cbbvtri.Text;
        //    ct.Quoctich = cbbQuocTich.Text;
        //    ct.Soao = nbsoao.Value.ToString();
        //    return ct;

        //}
        public CauThu GetValueForm()
        {
            CauThu ct = new CauThu();
            ct.Mact = tbmact.Text.ToUpper();
            ct.Hotenct = tbhotenct.Text;
            ct.Ngaysinh = datetimeNgaySinh.Value.Date;
            ct.Gioitinh = cbbGioiTinh.Text;
            ct.Mavt = cbbvtri.Text;
            ct.Quoctich = cbbQuocTich.Text;
            ct.Soao = nbsoao.Value.ToString();
            //bi
            CT_MaDB_dataGridView2.DataSource = ql.TimMaDBTheoTen(cbbmadb.Text);
            if (CT_MaDB_dataGridView2[0, 0].Value != null)
                ct.Madb = CT_MaDB_dataGridView2[0, 0].Value.ToString();
            return ct;

        }

        private void DanhSach()
        {
            //dataGridView1.DataSource=ql.DSCauThu(SQLProvider.GetAll("CauThu"));
            dataGridView1.DataSource = ql.DSCauThuBi("LoadCauThu");
        }

        private void ChiTietDanhSachCauThu_Load(object sender, EventArgs e)
        {
            DanhSach();
            LoadComboboxMaDB();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int vitricot = dataGridView1.Rows.IndexOf(row);
                tbmact.Text = dataGridView1[0, vitricot].Value.ToString();
                tbmact.Enabled = false;
                cbbmadb.Text = dataGridView1[1, vitricot].Value.ToString();
                tbhotenct.Text = dataGridView1[2, vitricot].Value.ToString();
                cbbGioiTinh.Text = dataGridView1[3, vitricot].Value.ToString();
                datetimeNgaySinh.Value = DateTime.Parse(dataGridView1[4, vitricot].Value.ToString());
                nbsoao.Value = int.Parse(dataGridView1[5, vitricot].Value.ToString());
                cbbvtri.Text = dataGridView1[6, vitricot].Value.ToString();
                cbbQuocTich.Text = dataGridView1[7, vitricot].Value.ToString();
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbmact.Text, cbbmadb.Text, tbhotenct.Text, cbbGioiTinh.Text, cbbvtri.Text, cbbQuocTich.Text, nbsoao.Value.ToString()))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
            }
            else if (ql.Insert_CauThu(GetValueForm()))
            {
                MessageBox.Show("Thêm thành công");
                this.DanhSach();
            }
            else
            {
                MessageBox.Show("Mã cầu thủ bị trùng rồi");
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbmact.Text))
            {
                MessageBox.Show("Bạn chưa chọn cầu thủ để xoá");
            }
            else if (ql.Delete_CauThu(GetValueForm()))
            {
                MessageBox.Show(" Xoá thành công");
                this.DanhSach();
            }
            else
            {
                MessageBox.Show(" Xoá không thành công");
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbmact.Text))
            {
                MessageBox.Show("Bạn chưa chọn cầu thủ để sửa");
            }
            else if (ql.Update_CauThu(GetValueForm()))
            {
                MessageBox.Show("Thông tin đã được sửa");
                this.DanhSach();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            tbhotenct.Text = "";
            tbmact.Text = "";
            cbbmadb.Text = "";
            cbbGioiTinh.Text = "";
            cbbQuocTich.Text = "";
            cbbvtri.Text = "";
            datetimeNgaySinh.Value = DateTime.Now;
            nbsoao.Value = 0;
            tbmact.Enabled = true;
            this.DanhSach();
        }

        private void LoadComboboxMaDB()
        {
            ql.MaDB(cbbmadb);
        }

        private void tbhotenct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                (sender as TextBox).ReadOnly = false;
            else
            {
                MessageBox.Show("Bạn chỉ được nhập chữ.");
                (sender as TextBox).ReadOnly = true;
            }
            //if (!(e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b') e.KeyChar = '\0';
        }

        private void cbbmadb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
