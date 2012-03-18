using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities;
using Utilities;
using System.Data.SqlClient;
using BLL;
using DALayer;

namespace Presentations
{
    public partial class QuanLyThiDau : UserControl
    {
        QuanLyThiDau_BLL ql = new QuanLyThiDau_BLL();

        public QuanLyThiDau()
        {
            InitializeComponent();
        }


        //tab xep lich thi dau
        public void LoadComboboxMaSan()
        {
            ql.MaSan(cbbMaSan);
        }

        //lấy mã đội bóng từ bảng đội bóng đưa vào combobox madb1 và madb2
        public void LoadComboboxMaDB1_ComboboxMaDB2()
        {
            ql.MaDB_ThiDau(cbbMaDB1);
            ql.MaDB_ThiDau(cbbMaDB2);
        }

        private TranDau GetValue_TranDau()
        {
            TranDau a = new TranDau();
            a.Matrd = tbMaTrD.Text.ToUpper();
            a.Ngaygio = dateTimeNgayGio.Value.Date;
            a.GioThiDau = cbbGioThiDau.Text + ":" + cbbPhutThiDau.Text;
            a.Vong = int.Parse(cbbVong.Text);
            //Bi

            MaDB_1_dataGridView1.DataSource = ql.TimMaDBTheoTen(cbbMaDB1.Text);
            MaDB_2_dataGridView1.DataSource = ql.TimMaDBTheoTen(cbbMaDB2.Text);
            MaSan_dataGridView2.DataSource = ql.TimMaSanTheoTen(cbbMaSan.Text);

            if (MaDB_1_dataGridView1[0, 0].Value != null)
                a.Madb1 = MaDB_1_dataGridView1[0, 0].Value.ToString();
            if (MaDB_2_dataGridView1[0, 0].Value != null)
                a.Madb2 = MaDB_2_dataGridView1[0, 0].Value.ToString();
            if (MaSan_dataGridView2[0, 0].Value != null)
                a.Masan = MaSan_dataGridView2[0, 0].Value.ToString();
            return a;
        }

        public void LoadTranDau()
        {
            //dataGridView1_thidau.DataSource = ql.Load(SQLProvider.GetAll("Trandau"));

            //bi
            //MaDB_1_dataGridView1.DataSource = ql.Load(SQLProvider.GetAll("Trandau"));
            dataGridView1_thidau.DataSource = ql.LoadLichThiDau("LoadLichThiDau");
            //bi

        }

        private void btThemThiDau_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(cbbMaDB1.Text, cbbMaDB2.Text, cbbMaSan.Text, tbMaTrD.Text, cbbVong.Text, cbbPhutThiDau.Text, cbbGioThiDau.Text))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin.");
            }
            else if (ql.Insert_TranDau(GetValue_TranDau()))
            {
                MessageBox.Show("Thêm thành công");
                this.LoadTranDau();
            }
            else
            {
                MessageBox.Show("Bạn nhập mã trận đấu bị trùng");
            }
        }

        private void btXoaThiDau_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbMaTrD.Text))
            {
                MessageBox.Show("Bạn chưa chọn thông tin để xoá");
            }
            else if (ql.Delete_TranDau(GetValue_TranDau()))
            {
                MessageBox.Show("Xoá thành công");
                this.LoadTranDau();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }

        }

        private void btCapNhatThiDau_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbMaTrD.Text))
            {
                MessageBox.Show("Bạn chưa chọn thông tin để cập nhật");
            }
            else if (ql.Update_TranDau(GetValue_TranDau()))
            {
                MessageBox.Show("Cập nhật thành công");
                this.LoadTranDau();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btRefreshThiDau_Click(object sender, EventArgs e)
        {
            tbMaTrD.Text = "";
            cbbMaDB1.Text = "";
            cbbMaDB2.Text = "";
            cbbMaSan.Text = "";
            tbMaTrD.Enabled = true;
            dateTimeNgayGio.Value = DateTime.Now;
            cbbGioThiDau.Text = "Giờ";
            cbbPhutThiDau.Text = "Phút";
            cbbVong.Text = "";
            this.LoadTranDau();
        }

        private void dataGridView1_thidau_Click(object sender, EventArgs e)
        {
            if (dataGridView1_thidau.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1_thidau.SelectedRows[0];
                int vitrirow = dataGridView1_thidau.Rows.IndexOf(row);
                tbMaTrD.Text = dataGridView1_thidau[0, vitrirow].Value.ToString();
                tbMaTrD.Enabled = false;
                cbbMaDB1.Text = dataGridView1_thidau[1, vitrirow].Value.ToString();
                cbbMaDB2.Text = dataGridView1_thidau[2, vitrirow].Value.ToString();
                cbbMaSan.Text = dataGridView1_thidau[3, vitrirow].Value.ToString();
                if (dataGridView1_thidau[4, vitrirow].Value == "")
                {
                    dateTimeNgayGio.Value = DateTime.Now;
                }
                else
                    dateTimeNgayGio.Value = DateTime.Parse(dataGridView1_thidau[4, vitrirow].Value.ToString());
                string s = dataGridView1_thidau[5, vitrirow].Value.ToString();
                string[] t = s.Split(':');
                cbbGioThiDau.Text = t[0];
                cbbPhutThiDau.Text = t[1];
                cbbVong.Text = dataGridView1_thidau[6, vitrirow].Value.ToString();

            }

        }

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //tab ra san  

        QuanLyThiDau_BLL qltd = new QuanLyThiDau_BLL();

        private RaSan GetValueRaSan()
        {
            RaSan a = new RaSan();
            a.Mars = tbmarasan.Text.ToUpper();
            a.Matrd = cbbmatrandaurasan.Text;
            a.Mavt = cbbvitrirasan.Text;

            //bi
            RaSan_MaCT_dataGridView1.DataSource = ql.TimMaCTTheoTen(cbbmacauthurasan.Text);
            if (RaSan_MaCT_dataGridView1[0, 0].Value != null)
                a.Mact = RaSan_MaCT_dataGridView1[0, 0].Value .ToString();
            return a;
        }

        private void Load_RaSan()
        {
            //dataGridView1_RaSan.DataSource = qltd.Load(SQLProvider.GetAll("rasan"));
            dataGridView1_RaSan.DataSource = qltd.LoadRaSan("LoadRaSan");
        }

        private void btThemRaSan_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbmarasan.Text))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin.");
            }
            else if (qltd.Insert_RaSan(GetValueRaSan()))
            {
                MessageBox.Show("Thêm thành công");
                this.Load_RaSan();
            }
            else
            {
                MessageBox.Show("Bạn nhập mã trận đấu bị trùng");
            }
        }

        private void btXoaRaSan_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbmarasan.Text))
            {
                MessageBox.Show("Bạn chưa chọn thông tin để xoá");
            }
            else if (qltd.Delete_RaSan(GetValueRaSan()))
            {

                MessageBox.Show("Xoá thành công");
                this.Load_RaSan();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }

        private void btCapNhatRaSan_Click(object sender, EventArgs e)
        {

            if (!DataUtils.KiemTra(tbmarasan.Text))
            {
                MessageBox.Show("Bạn chưa chọn thông tin để cập nhật");
            }
            else if (qltd.Update_RaSan(GetValueRaSan()))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Load_RaSan();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btRefreshRaSan_Click(object sender, EventArgs e)
        {
            tbmarasan.Text = "";
            cbbmacauthurasan.Text = "";
            cbbmatrandaurasan.Text = "";
            cbbvitrirasan.Text = "";
            tbmarasan.Enabled = true;
            this.Load_RaSan();
        }

        private void dataGridView1_RaSan_Click(object sender, EventArgs e)
        {
            if (dataGridView1_RaSan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1_RaSan.SelectedRows[0];
                int vitri_row = dataGridView1_RaSan.Rows.IndexOf(row);
                tbmarasan.Text = dataGridView1_RaSan[0, vitri_row].Value.ToString();
                tbmarasan.Enabled = false;
                cbbmacauthurasan.Text = dataGridView1_RaSan[2, vitri_row].Value.ToString();
                cbbmatrandaurasan.Text = dataGridView1_RaSan[1, vitri_row].Value.ToString();
                cbbvitrirasan.Text = dataGridView1_RaSan[3, vitri_row].Value.ToString();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                Load_RaSan();
            }
        }

        private void cbbmatrandaurasan_Click(object sender, EventArgs e)
        {
            cbbmatrandaurasan.Items.Clear();
            ql.MaTrD(cbbmatrandaurasan);
        }

        private void cbbmacauthurasan_Click(object sender, EventArgs e)
        {
            cbbmacauthurasan.Items.Clear();
            ql.MaCT_RaSan(cbbmacauthurasan, cbbmatrandaurasan);
        }

        private void cbbMaSan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void dataGridView1_thidau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MaDB_1_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MaDB_2_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MaSan_dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbMaDB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
