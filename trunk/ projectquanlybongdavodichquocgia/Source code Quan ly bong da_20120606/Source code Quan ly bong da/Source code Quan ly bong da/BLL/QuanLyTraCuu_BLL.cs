using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DALayer;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class QuanLyTraCuu_BLL
    {
        TraCuuAdapter tc = new TraCuuAdapter();
        public DataTable TraCuu(string query)
        { 
            return SQLProvider.Fill_Table(query); 
        }
       

        public DataTable TraCuu_DoiBong(string s)
        {
            return tc.TraCuu_DoiBong(s);
        }

        public DataTable TraCuu_CauThu(string s)
        {
            return tc.TraCuu_CauThu(s);
        }

        public DataTable TraCuu_TrongTai(string s)
        {
            return tc.TraCuu_TrongTai(s);
        }

        public DataTable TraCuu_San(string s)
        {
            return tc.TraCuu_San(s);
        }

        public DataTable TraCuu_KetQuaTD(string s)
        {
            return tc.TraCuu_KetQuaTD(s);
        }

        public DataTable TraCuu_LichThiDau(string s)
        {
            return tc.TraCuu_LichThiDau(s);
        }
    }
}
