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
using System.Data;
using DALayer;
using BLL;

namespace Presentations
{
    public partial class TraCuu : UserControl
    {
        enum LoaiTimKiem
        {
            CauThu,
            DoiBong,
            TrongTai,San,KetQuaTranDau,LichThiDau
        }
        public TraCuu()
        {
            InitializeComponent();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string name = "";
            if(cbbChon.SelectedItem==null)
                MessageBox.Show("Bạn chưa chọn đối tượng cần tìm!");
            else
                name = cbbChon.SelectedItem.ToString();
            QuanLyTraCuu_BLL ql = new QuanLyTraCuu_BLL(); 
            string s1 = tbTuKhoa.Text;
            string s = "%" + s1 + "%";
            switch (name)
            {
                case "Đội bóng":
                    {
                        dataGridView1.DataSource = ql.TraCuu_DoiBong(s);
                        break; 
                    }
                case "Cầu Thủ":
                    {
                        dataGridView1.DataSource = ql.TraCuu_CauThu(s);
                        break;
                    }
                case "Trọng tài":
                    dataGridView1.DataSource=ql.TraCuu_TrongTai(s);
                    break;
                case "Sân":
                    dataGridView1.DataSource = ql.TraCuu_San(s);
                    break;
                case "Kết quả trận đấu":
                    dataGridView1.DataSource = ql.TraCuu_KetQuaTD(s);
                    break;
                case "Lịch thi đấu":
                    dataGridView1.DataSource = ql.TraCuu_LichThiDau(s);
                    break;
                default:
                    
                    break;
            }
            
        }

        private void tbTuKhoa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbTuKhoa.Text = "";
            tbTuKhoa.ForeColor = Color.Black;
        }

        private void btTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cbbChon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btTim_Click(sender as ComboBox, e);
            e.KeyChar = '\0';
        }

        
        private void tbTuKhoa_Click(object sender, EventArgs e)
        {
            tbTuKhoa.Text = "";
            tbTuKhoa.ForeColor = Color.Black;

        }

        
    }
}
