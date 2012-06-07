using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entities;
using DALayer;
using System.Windows.Forms;

namespace BLL
{
    public class QuanLyQuyDinh_BLL
    {
        //bi
        public DataTable LoadTDQD(string query)
        {
            return SQLProvider.Store_Execute_Table(query);
        }
        //bi

        QuyDinhAdapter adapter = new QuyDinhAdapter();
        public DataTable DSQuyDinh(string query)
        {
            return SQLProvider.Fill_Table(query);
        }

        public bool Insert_QuyDinh(QuyDinh qd)
        {
            return adapter.Insert_QuyDinh(qd);
        }

        public bool Delete_QuyDinh(QuyDinh qd)
        {
            return adapter.Delete_QuyDinh(qd);
        }

        public bool Update_QuyDinh(QuyDinh qd)
        {
            return adapter.Update_QuyDinh(qd);
        }
    }
}
