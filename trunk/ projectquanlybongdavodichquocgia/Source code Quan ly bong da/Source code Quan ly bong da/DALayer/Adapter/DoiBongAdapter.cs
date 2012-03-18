using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DALayer
{
    public class DoiBongAdapter
    {
        public static DoiBongAdapter CreatDoiBongAdapter()
        { return new DoiBongAdapter(); }

        public bool Insert_DoiBong(DoiBong entity)
        {
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("@madb", entity.Madb);
            pa[1] = new SqlParameter("@tendb", entity.Tendb);
            pa[2] = new SqlParameter("@masan", entity.Masan);
            pa[3] = new SqlParameter("@diachi", entity.Diachi);
            return SQLProvider.Execute_NonQuery("insert_DoiBong", pa);//true;
        }

        public bool Delete_DoiBong(DoiBong entity)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@madb", entity.Madb);
            return SQLProvider.Execute_NonQuery("delete_DoiBong", pa);//true;
        }

        public bool Update_DoiBong(DoiBong entity)
        {
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("@madb_1", entity.Madb);
            pa[1] = new SqlParameter("@tendb_3", entity.Tendb);
            pa[2] = new SqlParameter("@masan_5", entity.Masan);
            pa[3] = new SqlParameter("@diachi_4", entity.Diachi);
            return SQLProvider.Execute_NonQuery("update_DoiBong", pa);
        }

        public void MaSan(ComboBox masan)
        {
            //SqlDataReader dr = SQLProvider.Execute_Reader(SQLProvider.GetAll("san"));
            //while (dr.Read())
            //    masan.Items.Add(dr["masan"]);
            SqlDataReader dr = SQLProvider.Execute_Reader(SQLProvider.GetAll("san"));
            while (dr.Read())
                masan.Items.Add(dr["tensan"]);
        }

        public DataTable TimMaDBTheoTen(string tendb)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@tendb", tendb);
            return SQLProvider.Fill_Table("TimMaDBTheoTen", paras);
        }
        
    }
}
