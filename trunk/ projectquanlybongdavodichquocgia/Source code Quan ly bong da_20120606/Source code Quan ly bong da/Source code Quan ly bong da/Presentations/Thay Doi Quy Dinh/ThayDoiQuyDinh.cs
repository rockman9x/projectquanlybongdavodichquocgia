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
    public partial class ThayDoiQuyDinh : UserControl
    {
        QuanLyQuyDinh_BLL qlqd = new QuanLyQuyDinh_BLL();
        int mode = 0;
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        public void LoadQD()
        {
            dataGridView1_ThayDoiQD.DataSource = qlqd.DSQuyDinh(SQLProvider.GetAll("QuyDinh"));
        }

        private QuyDinh GetValueQuyDinh()
        {
            QuyDinh qd = new QuyDinh();
            if (mode == 1 || mode == 2)
            {
                int ma = dataGridView1_ThayDoiQD.Rows.Count;
                if (ma > 0)
                {
                    qd.Maqd = dataGridView1_ThayDoiQD.Rows[ma - 1].Cells[0].Value.ToString();
                }
                else
                {
                    qd.Maqd = "";
                }
            }
            else
            {
                qd.Maqd = txt_maquydinh.Text;
            }

            qd.Tenqd = txt_tequydinh.Text;
            qd.GiaTri = txt_giatri.Text;
            return qd;
        }

        //Load Thay Doi Quy Dinh
        public void LoadThayDoiQD()
        {
            dataGridView1_ThayDoiQD.DataSource = qlqd.LoadTDQD("LoadQD");
        }

        private void btn_themquydinh_Click(object sender, EventArgs e)
        {
            mode = 1;
            if (!DataUtils.KiemTra(txt_tequydinh.Text, txt_giatri.Text))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin.");
            }
            else if (qlqd.Insert_QuyDinh(GetValueQuyDinh()))
            {
                MessageBox.Show("Thêm quy định thành công");
                this.LoadQD();
            }
            else
            {
                MessageBox.Show("Bạn nhập mã quy định bị trùng");
            }
        }

        private void btn_xoaquydinh_Click(object sender, EventArgs e)
        {
            mode = 2;
            int flg = 0;
            foreach (DataGridViewRow item in dataGridView1_ThayDoiQD.SelectedRows)
            {
                QuyDinh qd = new QuyDinh();
                qd.Maqd = item.Cells[0].Value.ToString();
                if (qlqd.Delete_QuyDinh(qd))
                {
                    flg = 1;
                }
                dataGridView1_ThayDoiQD.Rows.RemoveAt(item.Index);           
            }

            if (flg == 1)
            {
                MessageBox.Show("Xoá quy định thành công");
                this.LoadThayDoiQD();
            }
            else
            {
                MessageBox.Show("Qúa trình thực hiện thất bại");
            }           
        }

        private void btn_suaquydinh_Click(object sender, EventArgs e)
        {
            mode = 3;
            if (!DataUtils.KiemTra(txt_maquydinh.Text))
            {
                MessageBox.Show("Bạn chưa chọn thông tin để cập nhật");
            }
            else if (qlqd.Update_QuyDinh(GetValueQuyDinh()))
            {
                MessageBox.Show("Cập nhật thành công");
                this.LoadThayDoiQD();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btn_refreshquydinh_Click(object sender, EventArgs e)
        {
            mode = 4;
            txt_maquydinh.Text = "";
            txt_tequydinh.Text = "";
            txt_giatri.Text = "";
            this.LoadThayDoiQD();
        }

        private void ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            this.LoadThayDoiQD();
        }

        private void dataGridView1_ThayDoiQD_Click(object sender, EventArgs e)
        {
            if (dataGridView1_ThayDoiQD.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1_ThayDoiQD.SelectedRows[0];
                int vitricot = dataGridView1_ThayDoiQD.Rows.IndexOf(row);
                txt_maquydinh.Text = dataGridView1_ThayDoiQD[0, vitricot].Value.ToString();
                txt_tequydinh.Text = dataGridView1_ThayDoiQD[1, vitricot].Value.ToString();
                txt_giatri.Text = dataGridView1_ThayDoiQD[2, vitricot].Value.ToString();
            }
        }
    }
}
