using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;
using Entities;
using BLL;
using DALayer;

namespace Presentations
{
    public partial class QuanLyKetQua : UserControl
    {
        public QuanLyKetQua()
        {
            InitializeComponent();
        }

        //Tab Kết quả thi đấu
        QuanLyKetQuaTD_BLL qlkq = new QuanLyKetQuaTD_BLL();

        private KetQua GetValue_KetQua()
        {
            KetQua kq = new KetQua();
            kq.Ketqua = cbbKetQuaThiDau.Text;
            kq.Matrd = cbbMaTrD_KQ.Text;
            kq.Sobt = int.Parse(tbSoBanThang_KQ.Text);
            kq.Sothe = int.Parse(tbSoThePhat_KQ.Text);
            //bi
            KQ_MaDB_dataGridView4.DataSource = qlkq.TimMaDBTheoTen(cbbMaDB_KQ.Text);
            if (KQ_MaDB_dataGridView4[0, 0].Value != null)
                kq.Madb = KQ_MaDB_dataGridView4[0, 0].Value.ToString();
            return kq;
        }

        private void cbbMaDB_KQ_MouseClick(object sender, MouseEventArgs e)
        {
            cbbMaDB_KQ.Items.Clear();
            qlkq.MaDoiBong_by_MaTranDau_KQ(cbbMaTrD_KQ, cbbMaDB_KQ);
        }

        public void Load_KetQua()
        {
            //dataGridView1_KQ.DataSource=qlkq.Load(SQLProvider.GetAll("ketqua"));
            dataGridView1_KQ.DataSource = qlkq.Load("LoadKQ");
        }

        private void btThem_KQ_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(cbbKetQuaThiDau.Text, cbbMaDB_KQ.Text, cbbMaTrD_KQ.Text, tbSoBanThang_KQ.Text, tbSoThePhat_KQ.Text))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin");
            }
            else if (qlkq.Insert_KetQua(GetValue_KetQua()))
            {
                MessageBox.Show("Thêm thành công");
                this.Load_KetQua();
            }
            else
            {
                MessageBox.Show("Bạn nhập mã trận đấu và mã đội bóng bị trùng");
            }

        }

        private void btXoa_KQ_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(cbbMaDB_KQ.Text, cbbMaTrD_KQ.Text))
            {

                MessageBox.Show("Bạn chưa chọn thông tin để xoá");
            }
            else if (qlkq.Delete_KetQua(GetValue_KetQua()))
            {
                MessageBox.Show("Xoá thành công");
                this.Load_KetQua();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }

        }

        private void btCapNhat_KQ_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(cbbMaDB_KQ.Text, cbbMaTrD_KQ.Text))
            {

                MessageBox.Show("Bạn chưa chọn thông tin để cập nhật");
            }
            else if (qlkq.Update_KetQua(GetValue_KetQua()))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Load_KetQua();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btRefresh_KQ_Click(object sender, EventArgs e)
        {
            cbbKetQuaThiDau.Text = "";
            cbbMaTrD_KQ.Text = "";
            cbbMaDB_KQ.Text = "";
            tbSoBanThang_KQ.Text = "";
            tbSoThePhat_KQ.Text = "";
            cbbMaDB_KQ.Enabled = true;
            cbbMaTrD_KQ.Enabled = true;
            this.Load_KetQua();
        }

        private void dataGridView1_KQ_Click(object sender, EventArgs e)
        {
            if (dataGridView1_KQ.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1_KQ.SelectedRows[0];
                int vitri_row = dataGridView1_KQ.Rows.IndexOf(row);
                cbbMaTrD_KQ.Text = dataGridView1_KQ[0, vitri_row].Value.ToString();
                cbbMaTrD_KQ.Enabled = false;
                cbbMaDB_KQ.Text = dataGridView1_KQ[1, vitri_row].Value.ToString();
                cbbMaDB_KQ.Enabled = false;
                tbSoBanThang_KQ.Text = dataGridView1_KQ[2, vitri_row].Value.ToString();
                tbSoThePhat_KQ.Text = dataGridView1_KQ[3, vitri_row].Value.ToString();
                cbbKetQuaThiDau.Text = dataGridView1_KQ[4, vitri_row].Value.ToString();
            }
        }

        //Tab Danh sách cầu thủ ghi bàn

        //lấy mã trận đấu từ bảng trận đấu đưa vào combobox ma tran dau
        private void cbbMaTrD_GhiBan_MouseClick(object sender, MouseEventArgs e)
        {
            cbbMaCauThu_GhiBan.Text = "";//
            cbbMaTrD_GhiBan.Items.Clear();
            qlkq.MaTranDau_GhiBan(cbbMaTrD_GhiBan);
        }

        // Lấy mã cầu thủ từ bảng cầu thủ đưa vào combobox mã cầu thủ
        private void cbbMaCauThu_GhiBan_MouseClick(object sender, MouseEventArgs e)
        {
            cbbMaCauThu_GhiBan.Items.Clear();
            qlkq.MaCauThu_by_MaTranDau_GhiBan(cbbMaTrD_GhiBan, cbbMaCauThu_GhiBan);
        }

        private GhiBan GetValue_GhiBan()
        {
            GhiBan gb = new GhiBan();
            gb.Ghichu = cbbLoaiBanThang_GhiBan.Text;
            gb.Mabt = tbMaGhiBan.Text.ToUpper();
            gb.Matrd = cbbMaTrD_GhiBan.Text;
            gb.Thoidiem = int.Parse(ThoiDiemGhiBan.Text);
            //bi
            GhiBan_MaCT_dataGridView4.DataSource = qlkq.TimMaCTTheoTen(cbbMaCauThu_GhiBan.Text);
            if (GhiBan_MaCT_dataGridView4[0, 0].Value != null)
                gb.Mact = GhiBan_MaCT_dataGridView4[0, 0].Value.ToString();
            return gb;
        }

        private void Load_GhiBan()
        {
            dataGridView2_GhiBan.DataSource = qlkq.Load("loadghiban");
            // dataGridView2_GhiBan.DataSource = qlkq.LoadGhiBan("LoadGhiBan");
        }

        private void btThem_GhiBan_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(cbbLoaiBanThang_GhiBan.Text, cbbMaCauThu_GhiBan.Text, cbbMaTrD_GhiBan.Text, ThoiDiemGhiBan.Text, tbMaGhiBan.Text))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin");
            }
            else if (qlkq.Insert_GhiBan(GetValue_GhiBan()))
            {
                MessageBox.Show("Thêm thành công");
                this.Load_GhiBan();
            }
            else
            {
                MessageBox.Show("Bạn nhập bị trùng mã ghi bàn");
            }

        }

        private void btXoa_GhiBan_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbMaGhiBan.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin  cần xoá");
            }
            else if (qlkq.Delete_GhiBan(GetValue_GhiBan()))
            {
                MessageBox.Show("Xoá thành công");
                this.Load_GhiBan();
            }
            else
            {
                MessageBox.Show("Xoá không thành công");
            }

        }

        private void btCapNhat_GhiBan_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbMaGhiBan.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin  cần cập nhật");
            }
            else if (qlkq.Update_GhiBan(GetValue_GhiBan()))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Load_GhiBan();
            }

            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }

        private void btRefresh_GhiBan_Click(object sender, EventArgs e)
        {
            tbMaGhiBan.Text = "";
            cbbMaCauThu_GhiBan.Text = "";
            cbbLoaiBanThang_GhiBan.Text = "";
            cbbMaTrD_GhiBan.Text = "";
            cbbLoaiBanThang_GhiBan.Text = "";
            tbMaGhiBan.Enabled = true;
            this.Load_GhiBan();
        }

        private void dataGridView2_GhiBan_Click(object sender, EventArgs e)
        {
            if (dataGridView2_GhiBan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2_GhiBan.SelectedRows[0];
                int vitri_row = dataGridView2_GhiBan.Rows.IndexOf(row);
                tbMaGhiBan.Text = dataGridView2_GhiBan[0, vitri_row].Value.ToString();
                tbMaGhiBan.Enabled = false;
                cbbMaTrD_GhiBan.Text = dataGridView2_GhiBan[1, vitri_row].Value.ToString();
                cbbMaCauThu_GhiBan.Text = dataGridView2_GhiBan[2, vitri_row].Value.ToString();
                ThoiDiemGhiBan.Text = dataGridView2_GhiBan[3, vitri_row].Value.ToString();
                cbbLoaiBanThang_GhiBan.Text = dataGridView2_GhiBan[4, vitri_row].Value.ToString();
            }
        }
        //tab Phat
        private Phat GetValue_Phat()
        {
            Phat p = new Phat();
            p.Loaithe = cbbLoaiThePhat.Text;
            p.Maphat = tbMaPhat.Text.ToUpper();
            p.Matrd = cbbMaTranDau_Phat.Text;
            p.Thoidiem = DataUtils.ToInt(tbthoidiemphat.Text);
            //bi
            Phat_MaCT_dataGridView4.DataSource = qlkq.TimMaCTTheoTen(cbbMaCT_Phat.Text);
            if (Phat_MaCT_dataGridView4[0, 0].Value != null)
                p.Mact = Phat_MaCT_dataGridView4[0, 0].Value.ToString();
            return p;
        }

        private void Load_Phat()
        {
            dataGridView2.DataSource = qlkq.Load("LoadPhat");
            //dataGridView2.DataSource = qlkq.LoadPhat;
        }

        private void btThem_Phat_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(cbbLoaiThePhat.Text, cbbMaCT_Phat.Text, tbMaPhat.Text, cbbMaTranDau_Phat.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else if (qlkq.Insert_Phat(GetValue_Phat()))
            {
                MessageBox.Show("Thêm thành công");
                this.Load_Phat();
            }
            else
            {
                MessageBox.Show("Bạn nhập mã phạt bị trùng");
            }

        }

        private void btXoa_Phat_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbMaPhat.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần xoá");
            }
            else if (qlkq.Delete_Phat(GetValue_Phat()))
            {
                MessageBox.Show("Xoá thành công");
                this.Load_Phat();
            }
            else
            {
                MessageBox.Show("Xoá không thành công");
            }

        }

        private void btCapNhat_Phat_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbMaPhat.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần cập nhật");
            }
            else if (qlkq.Update_Phat(GetValue_Phat()))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Load_Phat();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }

        private void btRefesh_Phat_Click(object sender, EventArgs e)
        {
            tbMaPhat.Text = "";
            cbbMaTranDau_Phat.Text = "";
            cbbMaCT_Phat.Text = "";
            cbbLoaiThePhat.Text = "";
            tbthoidiemphat.Text = "";
            tbMaPhat.Enabled = true;
            this.Load_Phat();
        }

        private void dataGridView2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];
                int vitri_row = dataGridView2.Rows.IndexOf(row);
                tbMaPhat.Text = dataGridView2[0, vitri_row].Value.ToString();
                tbMaPhat.Enabled = false;
                cbbMaTranDau_Phat.Text = dataGridView2[1, vitri_row].Value.ToString();
                cbbMaCT_Phat.Text = dataGridView2[2, vitri_row].Value.ToString();
                tbthoidiemphat.Text = dataGridView2[3, vitri_row].Value.ToString();
                cbbLoaiThePhat.Text = dataGridView2[4, vitri_row].Value.ToString();
            }
        }

        private void cbbMaTranDau_Phat_MouseClick(object sender, MouseEventArgs e)
        {
            cbbMaTranDau_Phat.Text = "";
            cbbMaTranDau_Phat.Items.Clear();
            qlkq.MaTranDau_Phat(cbbMaTranDau_Phat);
        }

        private void cbbMaTrD_KQ_MouseClick(object sender, MouseEventArgs e)
        {
            cbbMaTrD_KQ.Items.Clear();
            qlkq.MaTranDau_KQ(cbbMaTrD_KQ);
        }

        private void cbbMaCT_Phat_MouseClick(object sender, MouseEventArgs e)
        {
            cbbMaCT_Phat.Items.Clear();
            qlkq.MaCauThu_by_MaTranDau_Phat(cbbMaTranDau_Phat, cbbMaCT_Phat);
        }

        //Tab xếp hạng



        //Su kien click chon tab
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                this.Load_GhiBan();

            }
            if (e.TabPageIndex == 2)
            {
                this.Load_Phat();
            }
            if (e.TabPageIndex == 3)
                dataGridView3.DataSource = XepHangAdapter.XepHang();
        }

        private void tbSoBanThang_KQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("Bạn chỉ được nhập số.");
                e.KeyChar = '\0';
            }

        }

        private void cbbMaTranDau_Phat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void ThoiDiemGhiBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }



    }
}
