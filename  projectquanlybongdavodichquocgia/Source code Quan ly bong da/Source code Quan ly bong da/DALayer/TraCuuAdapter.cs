using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace DALayer
{
    public class TraCuuAdapter
    {
        public DataTable TraCuu_DoiBong(string s)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@tukhoa",s);
            return SQLProvider.Fill_Table("Tracuudoibong", pa);
        }

        public DataTable TraCuu_CauThu(string s)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@tukhoa", s);
            return SQLProvider.Fill_Table("Tracuucauthu", pa);
        }

        public DataTable TraCuu_TrongTai(string s)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@tukhoa", s);
            return SQLProvider.Fill_Table("Tracuutrongtai", pa);
        }

        public DataTable TraCuu_San(string s)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@tukhoa", s);
            return SQLProvider.Fill_Table("Tracuusan", pa);
        }

        public DataTable TraCuu_KetQuaTD(string s)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@tukhoa", s);
            return SQLProvider.Fill_Table("Tracuuketquatd", pa);
        }

        public DataTable TraCuu_LichThiDau(string s)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@tukhoa", s);
            return SQLProvider.Fill_Table("Tracuulichthidau", pa);
        }
    }
}
