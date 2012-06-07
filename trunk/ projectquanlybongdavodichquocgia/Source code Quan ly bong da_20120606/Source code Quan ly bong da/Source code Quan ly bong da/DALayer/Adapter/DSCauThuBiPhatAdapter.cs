using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DALayer
{
    public class DSCauThuBiPhatAdapter
    {
        public bool Insert_Phat(Phat p)
        {
            SqlParameter[] pa = new SqlParameter[5];
            string ma = "MP";
            int mamp = 0;
            if (string.Compare(p.Maphat, "") != 0)
            {
                mamp = int.Parse(p.Maphat.Replace("MP", ""));
            }
            mamp++;
            if (mamp < 10)
            {
                p.Maphat = ma + "0" + mamp;
            }
            else
            {
                p.Maphat = ma + mamp;
            }

            pa[0] = new SqlParameter("@maphat", p.Maphat);
            pa[1] = new SqlParameter("@matrd", p.Matrd);
            pa[2] = new SqlParameter("@mact", p.Mact);
            pa[3] = new SqlParameter("@thoidiem", p.Thoidiem);
            pa[4] = new SqlParameter("@loaithe", p.Loaithe);
            return SQLProvider.Execute_NonQuery("insert_phat_1", pa);
        }

        public bool Delete_Phat(Phat p)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@maphat", p.Maphat);
            return SQLProvider.Execute_NonQuery("delete_phat_1", pa);
        }

        public bool Update_Phat(Phat p)
        {
            SqlParameter[] pa = new SqlParameter[5];
            pa[0] = new SqlParameter("@maphat", p.Maphat);
            pa[1] = new SqlParameter("@matrd", p.Matrd);
            pa[2] = new SqlParameter("@mact", p.Mact);
            pa[3] = new SqlParameter("@thoidiem", p.Thoidiem);
            pa[4] = new SqlParameter("@loaithe", p.Loaithe);
            return SQLProvider.Execute_NonQuery("update_phat_1", pa);
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
