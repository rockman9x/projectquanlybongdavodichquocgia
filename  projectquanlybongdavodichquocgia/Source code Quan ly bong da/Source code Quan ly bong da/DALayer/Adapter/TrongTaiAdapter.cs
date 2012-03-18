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
    public class TrongTaiAdapter
    {
        public static TrongTaiAdapter CreateTrongTaiAdapter()
        { return new TrongTaiAdapter(); }

        public bool Insert_TrongTai(TrongTai tt)
        {
            SqlParameter[] pa = new SqlParameter[3];
            pa[0] = new SqlParameter("@matt", tt.Matt);
            pa[1] = new SqlParameter("@tentt", tt.Tentt);
            pa[2] = new SqlParameter("@ngaysinh", tt.Ngaysinh);
            return SQLProvider.Execute_NonQuery("insert_trongtai", pa);
        }

        public bool Delete_TrongTai(TrongTai tt)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@matt", tt.Matt);
            return SQLProvider.Execute_NonQuery("Delete_trongtai", pa);
        }

        public bool Update_TrongTai(TrongTai tt)
        {
            SqlParameter[] pa = new SqlParameter[3];
            pa[0] = new SqlParameter("@matt", tt.Matt);
            pa[1] = new SqlParameter("@tentt", tt.Tentt);
            pa[2] = new SqlParameter("@ngaysinh", tt.Ngaysinh);
            return SQLProvider.Execute_NonQuery("Update_trongtai", pa);
        }
       

        public DataTable TimMaTTTheoTen(string tendb)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@tentt", tendb);
            return SQLProvider.Fill_Table("TimMaTTTheoTen", paras);
        }
    }
}
