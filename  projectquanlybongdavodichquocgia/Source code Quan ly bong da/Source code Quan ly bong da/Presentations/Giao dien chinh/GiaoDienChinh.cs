using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities;

namespace Presentations
{
    public partial class GiaoDienChinh : Form
    {
        Label selectedLabel = null;
        Button selectedButton = null;
        bool hienpanel = false;
        ToolTip tooltip;
        string tenPhanMem = "Quản Lý Giải Vô Địch Bóng Đá Toàn Quốc";
        public GiaoDienChinh()
        {
            InitializeComponent();
            _instance = this;
            tooltip = new ToolTip();
            this.Text = tenPhanMem;
        }

        private void btQuanLy_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            hienpanel = true; 
            btQuanLy.Font = new Font(btQuanLy.Font, FontStyle.Bold);
            btQuanLy.ForeColor=Color.Brown;
            if (selectedButton != null)
            {
                selectedButton.Font = new Font(selectedButton.Font, FontStyle.Regular);
                selectedButton.ForeColor = Color.Black;
            }
            selectedButton = (sender as Button);
            this.Text = btQuanLy.Text+" - "+tenPhanMem;
        }

        private void lbQuanLyDoiBong_Click(object sender, EventArgs e)
        {
            lbQuanLyDoiBong.Font = new Font(lbQuanLyDoiBong.Font, FontStyle.Bold);
            if(selectedLabel != null) 
                selectedLabel.Font = new Font(selectedLabel.Font, FontStyle.Regular);
            selectedLabel = (sender as Label);
            panel2.Visible = true;
            QuanLyDoiBong qldb = new QuanLyDoiBong();
            panel2.Controls.Clear();
            panel2.Controls.Add(qldb);
            this.Text = lbQuanLyDoiBong.Text + " - " + tenPhanMem;
        }

        private static GiaoDienChinh _instance;

        public static GiaoDienChinh GetInstance()
        {
            return _instance; 
        }

        public void AddChiTietDSDB()
        {
            panel2.Controls.Clear();
            ChiTietDanhSachDoiBong ctdb = new ChiTietDanhSachDoiBong();
            panel2.Controls.Add(ctdb);
        }

        public void AddChiTietDSCT()
        {
            panel2.Controls.Clear();
            ChiTietDanhSachCauThu ctct = new ChiTietDanhSachCauThu();
            panel2.Controls.Add(ctct);
        }

        public void AddQuanLyDoiBong()
        {
            panel2.Controls.Clear();
            QuanLyDoiBong qldb = new QuanLyDoiBong();
            panel2.Controls.Add(qldb);
        }

        private void lbQuanLyTrongTai_Click(object sender, EventArgs e)
        {
            lbQuanLyTrongTai.Font = new Font(lbQuanLyTrongTai.Font, FontStyle.Bold);
            if (selectedLabel != null)
                selectedLabel.Font = new Font(selectedLabel.Font, FontStyle.Regular);
            selectedLabel = (sender as Label);
            panel2.Visible = true;
            panel2.Controls.Clear();
            QuanLyTrongTai n = new QuanLyTrongTai();
            panel2.Controls.Add(n);
            n.LoadTT();
            this.Text = lbQuanLyTrongTai.Text + " - " + tenPhanMem;
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font((sender as Label).Font, FontStyle.Bold);
        }

        private void lbQuanLyDoiBong_MouseLeave(object sender, EventArgs e)
        {
            if(selectedLabel != (sender as Label))
                (sender as Label).Font = new Font((sender as Label).Font, FontStyle.Regular);
        }

        private void lbQuanLyThiDau_Click(object sender, EventArgs e)
        {
            lbQuanLyThiDau.Font = new Font(lbQuanLyThiDau.Font, FontStyle.Bold);
            if (selectedLabel != null)
                selectedLabel.Font = new Font(selectedLabel.Font, FontStyle.Regular);
            selectedLabel = (sender as Label);
            panel2.Visible = true;            
            selectedLabel = (sender as Label);
            panel2.Controls.Clear();
            QuanLyThiDau n =new QuanLyThiDau();
            panel2.Controls.Add(n);
            n.LoadTranDau();
            n.LoadComboboxMaSan();
            n.LoadComboboxMaDB1_ComboboxMaDB2();
            this.Text = lbQuanLyThiDau.Text + " - " + tenPhanMem;
        }

        private void lbQuanLyKQTD_Click(object sender, EventArgs e)
        {
            lbQuanLyKetQuaTD.Font=new Font(lbQuanLyKetQuaTD.Font,FontStyle.Bold);
            if(selectedLabel !=null)
                selectedLabel.Font=new Font(selectedLabel.Font,FontStyle.Regular);
            selectedLabel = (sender as Label);
            panel2.Visible = true;
            panel2.Controls.Clear();
            QuanLyKetQua kq = new QuanLyKetQua();
            panel2.Controls.Add(kq);
            kq.Load_KetQua();
            this.Text = lbQuanLyKetQuaTD.Text + " - " + tenPhanMem;
        }

        private void TraCuu_CLick(object sender, EventArgs e)
        {
            btTraCuu.Font = new Font(btTraCuu.Font, FontStyle.Bold);
            btTraCuu.ForeColor = Color.Brown;
            if (selectedButton != null)
            {
                selectedButton.Font = new Font(selectedButton.Font, FontStyle.Regular);
                selectedButton.ForeColor=Color.Black;
            }
            selectedButton=(sender as Button);
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Controls.Clear();
            TraCuu tc = new TraCuu();
            panel2.Controls.Add(tc);
            this.Text = btTraCuu.Text + " - " + tenPhanMem;
        }

        private void TroGiup_Click(object sender, EventArgs e)
        {
            btTroGiup.Font = new Font(btTroGiup.Font, FontStyle.Bold);
            btTroGiup.ForeColor = Color.Brown;
            if (selectedButton != null)
            {
                selectedButton.Font = new Font(selectedButton.Font, FontStyle.Regular);
                selectedButton.ForeColor=Color.Black;
            }
            selectedButton=(sender as Button);
            Help.ShowHelp(this, "help.chm");
        }

        private void btQuanLy_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Font = new Font((sender as Button).Font, FontStyle.Bold);
        }

        private void btQuanLy_MouseLeave(object sender, EventArgs e)
        {
            if (selectedButton != (sender as Button))
            {
                (sender as Button).Font = new Font((sender as Button).Font, FontStyle.Regular);
            }
        }

    }
}
