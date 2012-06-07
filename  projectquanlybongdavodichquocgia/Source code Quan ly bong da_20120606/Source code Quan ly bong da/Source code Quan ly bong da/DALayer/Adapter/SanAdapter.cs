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
    public class SanAdapter
    {
        public static SanAdapter CreatSanAdapter()
        { return new SanAdapter(); }

        public bool Insert_San(San s)
        {
            SqlParameter[] pa = new SqlParameter[4];
            string ma = "SVD";
            int mas = 0;
            if (string.Compare(s.Masan, "") != 0)
            {
                mas = int.Parse(s.Masan.Replace("SVD", ""));
            }
            mas++;
            if (mas < 10)
            {
                s.Masan = ma + "0" + mas;
            }
            else
            {
                s.Masan = ma + mas;
            }

            pa[0] = new SqlParameter("@masan_1", s.Masan);
            pa[1] = new SqlParameter("@Diachi_2", s.Diachi);
            pa[2] = new SqlParameter("@tenSan_3", s.Tensan);
            pa[3] = new SqlParameter("@succhua_4", s.Succhua);
            return SQLProvider.Execute_NonQuery("insert_SAN_1", pa);            
        }

        public bool Update_San(San s)
        {
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("@masan_2", s.Masan);
            pa[1] = new SqlParameter("@Diachi_3", s.Diachi);
            pa[2] = new SqlParameter("@tenSan_4", s.Tensan);
            pa[3] = new SqlParameter("@succhua_5", s.Succhua);
            return SQLProvider.Execute_NonQuery("update_SAN_1", pa);
        }

        public bool Delete_San(San s)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@masan_1", s.Masan);
            return SQLProvider.Execute_NonQuery("delete_San_1", pa);
        }

        public DataTable TimMaSanTheoTen(string tensan)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@tensan", tensan);
            return SQLProvider.Fill_Table("TimMaSanTheoTen", paras);
        }
    }

    
}
