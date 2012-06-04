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
using System.Data.SqlClient;
using DALayer;

namespace Presentations
{
    public partial class QuanLyDoiBong : UserControl
    {
        QuanLyDB_BLL ql = new QuanLyDB_BLL();

        public QuanLyDoiBong()
        {
            InitializeComponent();
        }

        private void lbChiTietDSDB_Click_1(object sender, EventArgs e)
        {
            GiaoDienChinh.GetInstance().AddChiTietDSDB();
        }

        private void lbChiTietDSCT_Click_1(object sender, EventArgs e)
        {
            GiaoDienChinh.GetInstance().AddChiTietDSCT();
        }

        private void lbChiTietDSDB_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font((sender as Label).Font, FontStyle.Underline);
        }

        private void lbChiTietDSDB_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font((sender as Label).Font, FontStyle.Regular);
        }

        //Tab San
        private void LoadSan()
        {

            dataGridView1_san.DataSource = ql.San(SQLProvider.GetAll("San"));
        }

        private San GetValueSan()
        {
            San s = new San();
            s.Masan = tbmasan.Text.ToUpper();
            s.Tensan = tbtensan.Text;
            s.Diachi = tbdiachi.Text;
            s.Succhua = int.Parse(tbsucchua.Text);
            return s;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            string tensan = tbtensan.Text;
            string masan = tbmasan.Text;
            if (!DataUtils.KiemTra(tbmasan.Text, tbtensan.Text, tbdiachi.Text, tbsucchua.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else if (ql.Insert_San(GetValueSan()))
            {
                MessageBox.Show("Đã thêm sân " + tensan + " thành công.");
                this.LoadSan();
            }
            else
            {
                SqlDataReader dr = SQLProvider.Execute_Reader(SQLProvider.GetAll("san"));
                int i = 0;
                while (dr.Read())
                {
                    string s1 = dr["tensan"].ToString();
                    string s2 = dr["masan"].ToString();

                    if (tbtensan.Text.CompareTo(s1) == 0)
                    {
                        MessageBox.Show("Đã có sân " + tensan + " trong danh sach.");
                        break;
                    }
                    if (tbmasan.Text.ToUpper().CompareTo(s2) == 0)
                    {
                        MessageBox.Show(" Mã sân " + masan + " đã được sử dụng.\n Bạn hãy chọn mã sân khác.");
                        break;
                    }
                }
            }

        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            if (!DataUtils.KiemTra(tbmasan.Text))
            {
                MessageBox.Show("Bạn chưa chọn sân để cập nhật");

            }
            else if (ql.Update_San(GetValueSan()))
            {
                MessageBox.Show("Thông tin đã được cập nhật");
                this.LoadSan();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }

        }

        private void dataGridView1_san_Click(object sender, EventArgs e)
        {
            if (dataGridView1_san.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1_san.SelectedRows[0];
                int vitrirow = dataGridView1_san.Rows.IndexOf(row);
                tbmasan.Text = dataGridView1_san[0, vitrirow].Value.ToString();
                tbmasan.Enabled = false;
                tbtensan.Text = dataGridView1_san[1, vitrirow].Value.ToString();
                tbdiachi.Text = dataGridView1_san[2, vitrirow].Value.ToString();
                tbsucchua.Text = dataGridView1_san[3, vitrirow].Value.ToString();
            }
        }

        private void XoaSan_Click(object sender, EventArgs e)
        {
            string s = tbtensan.Text;
            if (!DataUtils.KiemTra(tbmasan.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sân sẽ được xoá");
            }
            else if (ql.Delete_San(GetValueSan()))
            {
                MessageBox.Show("Sân " + s + " đã được xoá khỏi danh sách.");
                this.LoadSan();
            }
            else
            {
                MessageBox.Show("Xoá không thành công.\nHiện tại có đội bóng hay trận đấu đang sử dụng sân " + s + ".");
            }
        }

        private void btrefesh_Click(object sender, EventArgs e)
        {
            tbdiachi.Text = "";
            tbtensan.Text = "";
            tbmasan.Text = "";
            tbsucchua.Text = "";
            tbmasan.Enabled = true;
            this.LoadSan();
        }


        //Tab ban huan luyen vien 
        private void LoadBHL()
        {
            //dataGridView2_BHL.DataSource = ql.BHL(SQLProvider.GetAll("BHL"));
            dataGridView2_BHL.DataSource = ql.LoadBHL("LoadBHL");
        }

        private void btthembhl_Click(object sender, EventArgs e)
        {
            string tenBHL = tbhoten.Text;
            string maHLV = tbmabhl.Text;
            if (!DataUtils.KiemTra(cbbMaDB_BHL.Text, tbhoten.Text, tbmabhl.Text, cbbchucvuhlv.Text))
            {
                MessageBox.Show(" Bạn chưa nhập đầy đủ thông tin");
            }
            else if (ql.Insert_BHL(GetValue_BHL()))
            {
                this.LoadBHL();
                MessageBox.Show(" Huấn luyện viên " + tenBHL + " đã được thêm vào danh sach.");
            }
            else
            {
                MessageBox.Show(" Mã " + maHLV + " đã được sử dụng. \n Bạn hãy nhập mã khác.");
            }

        }

        private void btxoabhl_Click(object sender, EventArgs e)
        {
            string tenBHL = tbhoten.Text;
            if (!DataUtils.KiemTra(tbmabhl.Text))
            {
                MessageBox.Show("Bạn chưa chọn thông tin để xoá");
            }
            else if (ql.Delete_BHL(GetValue_BHL()))
            {
                this.LoadBHL();
                MessageBox.Show("Huấn luyện viên " + tenBHL + " đã được xoá khỏi danh sách.");

            }
            else
            {
                MessageBox.Show("Huấn luyện viên " + tenBHL + " không thể xoá khỏi danh sách.");
            }
        }

        private void btcapnhatbhl_Click(object sender, EventArgs e)
        {
            string tenBHL = tbhoten.Text;
            string maHLV = tbmabhl.Text;
            if (!DataUtils.KiemTra(tbmabhl.Text))
            {
                MessageBox.Show("Bạn chưa chọn thông tin để cập nhật");
            }
            else if (ql.Update_BHL(GetValue_BHL()))
            {
                this.LoadBHL();
                MessageBox.Show("Thông tin của huấn luyện viên " + tenBHL + " đã được cập nhật.");
            }
            else
            {
                MessageBox.Show(" Cập nhật không thành công.");
            }

        }

        private void btrefeshbhl_Click(object sender, EventArgs e)
        {
            cbbMaDB_BHL.Text = "";
            tbhoten.Text = "";
            tbmabhl.Text = "";
            cbbchucvuhlv.Text = "";
            tbmabhl.Enabled = true;
            this.LoadBHL();
        }

        private BHL GetValue_BHL()
        {
            BHL hl = new BHL();
            hl.Mabhl = tbmabhl.Text.ToUpper();
            hl.Hoten = tbhoten.Text;
            hl.Chucvu = cbbchucvuhlv.Text;
            //Bi
            BHL_MaDB_dataGridView1.DataSource = ql.TimMaDBTheoTen(cbbMaDB_BHL.Text);

            BHL_MaDB_dataGridView1.DataSource = ql.TimMaDBTheoTen(cbbMaDB_BHL.Text);
            if (BHL_MaDB_dataGridView1[0, 0].Value != null)
                hl.Madb = BHL_MaDB_dataGridView1[0, 0].Value.ToString();
            return hl;
        }

        private void dataGridView2_BHL_Click(object sender, EventArgs e)
        {
            if (dataGridView2_BHL.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2_BHL.SelectedRows[0];
                int vitricot = dataGridView2_BHL.Rows.IndexOf(row);
                tbmabhl.Text = dataGridView2_BHL[0, vitricot].Value.ToString();
                tbhoten.Text = dataGridView2_BHL[1, vitricot].Value.ToString();
                cbbMaDB_BHL.Text = dataGridView2_BHL[2, vitricot].Value.ToString();
                cbbchucvuhlv.Text = dataGridView2_BHL[3, vitricot].Value.ToString();
                tbmabhl.Enabled = false;
            }
        }

        private void tabDoiBong_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
                this.LoadSan();
            if (e.TabPageIndex == 2)
            {
                this.LoadBHL();
                cbbMaDB_BHL.Items.Clear();
                LoadComboboxMadb_BHL();
            }
        }

        private void LoadComboboxMadb_BHL()
        {
            ql.MaDB(cbbMaDB_BHL);
        }

        private void tbsucchua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                MessageBox.Show("Bạn chỉ được nhập số.");
                e.KeyChar = '\0';
            }
        }

        private void cbbMaDB_BHL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void tbhoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Bạn chỉ được nhập chữ.");
                e.KeyChar = '\0';
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
