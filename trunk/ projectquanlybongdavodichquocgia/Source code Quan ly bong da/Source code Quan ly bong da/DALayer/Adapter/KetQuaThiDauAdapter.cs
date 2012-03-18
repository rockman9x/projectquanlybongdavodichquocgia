using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Windows.Forms;
using Utilities;
using System.Data;

namespace DALayer
{
    public class KetQuaThiDauAdapter
    {
        public bool Insert_KetQuaTD(KetQua kq)
        {
            SqlParameter[] pa = new SqlParameter[5];
            pa[0] = new SqlParameter("@Matrd", kq.Matrd);
            pa[1] = new SqlParameter("@Madb", kq.Madb);
            pa[2] = new SqlParameter("@sobt", kq.Sobt);
            pa[3] = new SqlParameter("@sothe", kq.Sothe);
            pa[4] = new SqlParameter("@ketqua", System.Data.SqlDbType.NVarChar, 10);
            pa[4].Value = kq.Ketqua;
            return SQLProvider.Execute_NonQuery("insert_ketqua_1", pa);
        }

        public bool Delete_KetQuaTD(KetQua kq)
        {
            SqlParameter[] pa = new SqlParameter[2];
            pa[0] = new SqlParameter("@Matrd", kq.Matrd);
            pa[1] = new SqlParameter("@Madb", kq.Madb);
            return SQLProvider.Execute_NonQuery("delete_ketqua_1", pa);
        }

        public bool Update_KetQuaTD(KetQua kq)
        {
            SqlParameter[] pa = new SqlParameter[5];
            pa[0] = new SqlParameter("@Matrd", kq.Matrd);
            pa[1] = new SqlParameter("@Madb", kq.Madb);
            pa[2] = new SqlParameter("@sobt", kq.Sobt);
            pa[3] = new SqlParameter("@sothe", kq.Sothe);
            pa[4] = new SqlParameter("@ketqua", System.Data.SqlDbType.NVarChar, 10);
            pa[4].Value = kq.Ketqua;
            return SQLProvider.Execute_NonQuery("update_ketqua_1", pa);
        }

        //public List<DoiBong> ListDoiBong(ComboBox c)
        //{
        //    string s="";
        //    if (c.SelectedItem == null)
        //        MessageBox.Show("Bạn chưa chọn mã trận đấu!");
        //    else
        //    {
        //        s = c.SelectedItem.ToString();
        //    }
        //    SqlParameter[] pa = new SqlParameter[1];
        //    pa[0] = new SqlParameter("@matrd", s);
        //    try
        //    {
        //        List<DoiBong> results = new List<DoiBong>();
                
        //        IDataReader reader = SQLProvider.Execute_Reader("Madoibong",pa);
        //        while (reader.Read())
        //        {
        //            DoiBong entity = GetEntityFromDoiBong(reader);
        //            if (entity != null)
        //                results.Add(entity);
        //        }

        //        return results;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        //public DoiBong GetEntityFromDoiBong(IDataReader reader)
        //{
        //    try
        //    {
        //        DoiBong entity = new DoiBong();
        //        entity.Madb = DataUtils.ToString(reader["madb"]);
        //        entity.Tendb = DataUtils.ToString(reader["tendb"]);
        //        entity.Diachi = DataUtils.ToString(reader["diachi"]);
        //        entity.Masan = DataUtils.ToString(reader["masan"]);
        //        //entity.TongDiem1 = DataUtils.ToBoolean(reader["tongdiem"]);
        //        return entity;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        public void MaDoiBong(ComboBox c,ComboBox a_by_c)
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
            SqlDataReader dr = SQLProvider.Execute_Reader("MaDoiBong_by_MaTranDau", pa);
            while (dr.Read())
            {
                a_by_c.Items.Add(dr["tendb"]);
            }
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
    }
}
