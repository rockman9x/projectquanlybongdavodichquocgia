using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DALayer
{
    public class RaSanAdapter
    {
        public bool Insert_RaSan(RaSan a)
        {
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("@mars", a.Mars);
            pa[1] = new SqlParameter("@matrd", a.Matrd);
            pa[2] = new SqlParameter("@mact", a.Mact);
            pa[3] = new SqlParameter("@vitri", a.Mavt);

            return SQLProvider.Execute_NonQuery("insert_rasan_1", pa);
        }

        public bool Update_RaSan(RaSan a)
        {
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("@mars", a.Mars);
            pa[1] = new SqlParameter("@matrd", a.Matrd);
            pa[2] = new SqlParameter("@mact", a.Mact);
            pa[3] = new SqlParameter("@vitri", a.Mavt);

            return SQLProvider.Execute_NonQuery("update_rasan_1", pa);
        }

        public bool Delete_RaSan(RaSan a)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@mars", a.Mars);
            return SQLProvider.Execute_NonQuery("delete_rasan_1", pa);
        }

        public void MaTranDau(ComboBox matrd)
        {
            string s = SQLProvider.GetAll("trandau");
            SqlDataReader dr = SQLProvider.Execute_Reader(s);
            while (dr.Read())
            {
                matrd.Items.Add(dr["matrd"]);
            }
        }

        public void MaCauThu(ComboBox c, ComboBox a_by_c)
        {
            string s = "";
            if (a_by_c.SelectedItem == null)
                MessageBox.Show("Bạn chưa chọn mã trận đấu!");
            else
            {
                s = a_by_c.SelectedItem.ToString();
            }
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@matrd", s);
            SqlDataReader dr = SQLProvider.Execute_Reader("MaCauThu_by_MaTranDau", pa);
            while (dr.Read())
            {
                //c.Items.Add(dr["mact"]);
                c.Items.Add(dr["hoten_CT"]);
            }
        }
    }
}
