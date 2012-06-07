using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DALayer
{
    public class DSCauThuGhiBanAdapter
    {
        public bool Insert_GhiBan(GhiBan gb)
        {
            SqlParameter[] pa = new SqlParameter[5];
            string ma = "BT";
            int mabt = 0;
            if (string.Compare(gb.Mabt, "") != 0)
            {
                mabt = int.Parse(gb.Mabt.Replace("BT", ""));
            }
            mabt++;
            if (mabt < 10)
            {
                gb.Mabt = ma + "0" + mabt;
            }
            else
            {
                gb.Mabt = ma + mabt;
            }

            pa[0] = new SqlParameter("@mabt", gb.Mabt);
            pa[1] = new SqlParameter("@matrd", gb.Matrd);
            pa[2] = new SqlParameter("@mact", gb.Mact);
            pa[3] = new SqlParameter("@thoidiem", gb.Thoidiem);
            pa[4] = new SqlParameter("@ghichu", gb.Ghichu);
            return SQLProvider.Execute_NonQuery("Insert_ghiban_1", pa);
        }

        public bool Delete_GhiBan(GhiBan gb)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@mabt", gb.Mabt);
            return SQLProvider.Execute_NonQuery("delete_ghiban_1", pa);
        }

        public bool Update_GhiBan(GhiBan gb)
        {
            SqlParameter[] pa = new SqlParameter[5];
            pa[0] = new SqlParameter("@mabt", gb.Mabt);
            pa[1] = new SqlParameter("@matrd", gb.Matrd);
            pa[2] = new SqlParameter("@mact", gb.Mact);
            pa[3] = new SqlParameter("@thoidiem", gb.Thoidiem);
            pa[4] = new SqlParameter("@ghichu", gb.Ghichu);
            return SQLProvider.Execute_NonQuery("Update_ghiban_1", pa);
        }

        public void MaTranDau(ComboBox matrd)
        {
            string s = "select *from trandau";
            SqlDataReader dr = SQLProvider.Execute_Reader(s);
            while (dr.Read())
            {
                matrd.Items.Add(dr["matrd"]);
            }
        }

        public void MaCauThu(ComboBox c, ComboBox a_by_c)
        {
            string s = "";
            if (c.SelectedItem == null)
                MessageBox.Show("Bạn chưa chọn mã trận đấu!");
            else
            {
                s = c.SelectedItem.ToString();
            }
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@matrd", s);
            SqlDataReader dr = SQLProvider.Execute_Reader("MaCauThu_by_MaTranDau", pa);
            while (dr.Read())
            {
                a_by_c.Items.Add(dr["hoten_CT"]);
            }
        }
    }
}
