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
    public partial class QuanLyTrongTai : UserControl
    {
        QuanLyTrongTai_BLL ql = new QuanLyTrongTai_BLL();

        public QuanLyTrongTai()
        {
            InitializeComponent();
        }

        //Tab Trong Tai

        private TrongTai GetValue_TT()
        {
            TrongTai tt = new TrongTai();
            tt.Matt = tbmatrongtai.Text.ToUpper();
            tt.Tentt = tbtentrongtai.Text;
            tt.Ngaysinh = datetimengaysinhtrongtai.Value.Date;
            return tt;
        }

        public void LoadTT()
        {
            dataGridView1.DataSource = ql.Load(SQLProvider.GetAll("TrongTai"));
        }

        private void btthemtrongtai_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbtentrongtai.Text, tbmatrongtai.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else if (ql.Insert_TrongTai(GetValue_TT()))
            {
                MessageBox.Show("Thêm thành công");
                this.LoadTT();
            }
            else
            {
                MessageBox.Show("Bạn nhập mã trọng tài bị trùng");
            }


        }

        private void btxoatrongtai_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbmatrongtai.Text))
            {

                MessageBox.Show("Bạn chưa chọn thông tin để xoá");
            }
            else if (ql.Delete_TrongTai(GetValue_TT()))
            {
                MessageBox.Show("Xoá thành công");
                this.LoadTT();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }


        }

        private void btcapnhattrongtai_Click(object sender, EventArgs e)
        {

            if (!DataUtils.KiemTra(tbmatrongtai.Text))
            {

                MessageBox.Show("Bạn chưa chọn thông tin để cập nhật");
            }
            else if (ql.Update_TrongTai(GetValue_TT()))
            {
                MessageBox.Show("Cập nhật thành công");
                this.LoadTT();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btrefeshtrongtai_Click(object sender, EventArgs e)
        {
            tbmatrongtai.Text = "";
            tbtentrongtai.Text = "";
            tbmatrongtai.Enabled = true;
            datetimengaysinhtrongtai.Value = datetimengaysinhtrongtai.MinDate;
            this.LoadTT();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int vitricot = dataGridView1.Rows.IndexOf(row);
                tbmatrongtai.Text = dataGridView1[0, vitricot].Value.ToString();
                tbmatrongtai.Enabled = false;
                tbtentrongtai.Text = dataGridView1[1, vitricot].Value.ToString();
                datetimengaysinhtrongtai.Value = DateTime.Parse(dataGridView1[2, vitricot].Value.ToString());
            }
        }


        //Tab điều khiển
        private DieuKhien GetValue_DK()
        {
            DieuKhien dk = new DieuKhien();
            dk.Matrd = cbbmadieukhientrandau.Text;
            dk.Mavtro = cbbvaitrodieukhien.Text;


            //bi
            DK_MaTT_dataGridView3.DataSource = ql.TimMaTTTheoTen(cbbmatrongtaidieukhien.Text);
            if (DK_MaTT_dataGridView3[0, 0].Value != null)
                dk.Matt = DK_MaTT_dataGridView3[0, 0].Value.ToString();
            return dk;
        }

        public void LoadDK()
        {
            //dataGridView2.DataSource = ql.Load(SQLProvider.GetAll("DieuKhien"));
            dataGridView2.DataSource = ql.LoadTrongTai("LoadTrongTai");
        }

        private void btXoadk_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(cbbmadieukhientrandau.Text, cbbmatrongtaidieukhien.Text, cbbvaitrodieukhien.Text))
            {
                MessageBox.Show("Bạn chưa chọn thông tin để xoá");
            }
            else if (ql.Delete_DieuKhien(GetValue_DK()))
            {
                MessageBox.Show("Xoá thành công");
                this.LoadDK();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }

        private void btThemdk_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(cbbmadieukhientrandau.Text, cbbmatrongtaidieukhien.Text, cbbvaitrodieukhien.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else if (ql.Insert_DieuKhien(GetValue_DK()))
            {
                MessageBox.Show("Thêm thành công");
                this.LoadDK();

            }
            else { MessageBox.Show("Mã trận đấu hoặc mã trọng tài bị trùng.Kiểm tra lại"); }
        }

        private void btCapNhatDK_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(cbbmadieukhientrandau.Text, cbbmatrongtaidieukhien.Text, cbbvaitrodieukhien.Text))
            {
                MessageBox.Show("Bạn chưa chọn thông tin để cập nhật");
            }
            else if (ql.Update_DieuKhien(GetValue_DK()))
            {
                MessageBox.Show("Cập nhật thành công");
                this.LoadDK();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btRefreshDK_Click(object sender, EventArgs e)
        {
            cbbmadieukhientrandau.Text = "";
            cbbmatrongtaidieukhien.Text = "";
            cbbvaitrodieukhien.Text = "";
            cbbmadieukhientrandau.Enabled = true;
            cbbmatrongtaidieukhien.Enabled = true;
            this.LoadDK();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];
                int vitricot = dataGridView2.Rows.IndexOf(row);
                cbbmatrongtaidieukhien.Text = dataGridView2[1, vitricot].Value.ToString();
                cbbmadieukhientrandau.Text = dataGridView2[0, vitricot].Value.ToString();
                cbbvaitrodieukhien.Text = dataGridView2[2, vitricot].Value.ToString();
                cbbmadieukhientrandau.Enabled = false;
                cbbmatrongtaidieukhien.Enabled = false;
            }
        }

        //Lấy mã trận đấu từ bảng trận đấu đưa vào comboboxmatradau
        private void LoadComboboxMaTranDau()
        {
            ql.MaTrD(cbbmadieukhientrandau);
        }

        //Lấy dữ liệu matrongtai từ bảng Trong tai vào comboboxmatrongtai
        private void LoadComboboxMaTrongTai()
        {
            ql.MaTrongTai(cbbmatrongtaidieukhien);
        }

        private void Select(object sender, TabControlEventArgs e)
        {

            if (e.TabPageIndex == 1)
            {
                this.LoadDK();
                cbbmadieukhientrandau.Items.Clear();
                LoadComboboxMaTranDau();
                cbbmatrongtaidieukhien.Items.Clear();
                LoadComboboxMaTrongTai();
            }

        }

        private void cbbmadieukhientrandau_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void tbtentrongtai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Bạn chỉ được nhập chữ.");
                e.KeyChar = '\0';
            }
        }

        private void tabTrongTai_Click(object sender, EventArgs e)
        {

        }

    }
}
