using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace DALayer
{
    public class XepHangAdapter
    {
        public static DataTable XepHang()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("XepLoai", ConnectToDataBase.StartConnection());
            DataTable dd = new DataTable();
            da.Fill(dd);
            return dd;

        }

    }
}
