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
    public class QuyDinhAdapter
    {
        public static QuyDinhAdapter CreateQuyDinhAdapter()
        { return new QuyDinhAdapter(); }

        public bool Insert_QuyDinh(QuyDinh qd)
        {
            SqlParameter[] pa = new SqlParameter[3];
            string ma = "QD";
            int maqd = 0;
            if (string.Compare(qd.Maqd, "") != 0)
            {
                maqd = int.Parse(qd.Maqd.Replace("QD", ""));
            }
            maqd++;
            if (maqd < 10)
            {
                qd.Maqd = ma + "0" + maqd;
            }
            else
            {
                qd.Maqd = ma + maqd;
            }

            pa[0] = new SqlParameter("@MaQuyDinh", qd.Maqd);
            pa[1] = new SqlParameter("@TenQuyDinh", qd.Tenqd);
            pa[2] = new SqlParameter("@GiaTri", qd.GiaTri);
            return SQLProvider.Execute_NonQuery("insert_QUYDINH", pa);
        }

        public bool Delete_QuyDinh(QuyDinh qd)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@MaQuyDinh", qd.Maqd);
            return SQLProvider.Execute_NonQuery("delete_QUYDINH", pa);
        }

        public bool Update_QuyDinh(QuyDinh qd)
        {
            SqlParameter[] pa = new SqlParameter[3];
            pa[0] = new SqlParameter("@MaQuyDinh", qd.Maqd);
            pa[1] = new SqlParameter("@TenQuyDinh", qd.Tenqd);
            pa[2] = new SqlParameter("@GiaTri", qd.GiaTri);
            return SQLProvider.Execute_NonQuery("update_QUYDINH", pa);
        }

        

    }
}
