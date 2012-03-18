using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DALayer
{
    public class DieuKhienAdapter
    {
        public static DieuKhienAdapter CreatDieuKhienAdapter()
        { return new DieuKhienAdapter(); }

        public bool Insert_DieuKhien(DieuKhien dk)
        {
            SqlParameter[] pa = new SqlParameter[3];
            pa[0] = new SqlParameter("@MaTrD", dk.Matrd);
            pa[1] = new SqlParameter("@MaTT", dk.Matt);
            pa[2] = new SqlParameter("@VaiTro", dk.Mavtro);
            return SQLProvider.Execute_NonQuery("insert_DIEUKHIEN_1", pa);
        }

        public bool Delete_DieuKhien(DieuKhien dk)
        {
            SqlParameter[] pa = new SqlParameter[2];
            pa[0] = new SqlParameter("@matrd", dk.Matrd);
            pa[1] = new SqlParameter("@matt", dk.Matt);
            return SQLProvider.Execute_NonQuery("delete_dieukhien_1", pa);
        }

        public bool Update_DieuKhien(DieuKhien dk)
        {
            SqlParameter[] pa = new SqlParameter[3];
            pa[0] = new SqlParameter("@MaTrD", dk.Matrd);
            pa[1] = new SqlParameter("@MaTT", dk.Matt);
            pa[2] = new SqlParameter("@VaiTro", dk.Mavtro);
            return SQLProvider.Execute_NonQuery("update_DIEUKHIEN_1", pa);
        }

        public void MaTranDau(ComboBox matrd)
        {
            SqlDataReader dr = SQLProvider.Execute_Reader(SQLProvider.GetAll("trandau"));
            while (dr.Read())
            {
                matrd.Items.Add(dr["matrd"]);
                
            }
        }

        public void MaTrongTai(ComboBox matt)
        {
            SqlDataReader dr = SQLProvider.Execute_Reader(SQLProvider.GetAll("trongtai"));
            while (dr.Read())
                matt.Items.Add(dr["tentt"]);
        }
    }
}
