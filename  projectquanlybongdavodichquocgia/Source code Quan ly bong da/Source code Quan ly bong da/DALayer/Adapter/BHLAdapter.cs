using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DALayer
{
    public class BHLAdapter
    {
        public static BHLAdapter CreatBHLAdapter()
        { return new BHLAdapter(); }

        public bool Insert_BHL(BHL bhl)
        {
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("@mabhl_1", bhl.Mabhl);
            pa[1] = new SqlParameter("@madb_2", bhl.Madb);
            pa[2] = new SqlParameter("@hoten_3", bhl.Hoten);
            pa[3] = new SqlParameter("@chucvu_4", bhl.Chucvu);
            return SQLProvider.Execute_NonQuery("Insert_BHL_1", pa);
        }

        public bool Delete_BHL(BHL bhl)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@mabhl_1", bhl.Mabhl);
            return SQLProvider.Execute_NonQuery("delete_BHL_1", pa);
        }

        public bool Update_BHL(BHL bhl)
        {
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("@mabhl_2", bhl.Mabhl);
            pa[1] = new SqlParameter("@madb_3", bhl.Madb);
            pa[2] = new SqlParameter("@hoten_4", bhl.Hoten);
            pa[3] = new SqlParameter("@chucvu_5", bhl.Chucvu);
            return SQLProvider.Execute_NonQuery("update_BHL_1", pa);
        }

        public void MaDB(ComboBox madb)
        {
            //SqlDataReader dr = SQLProvider.Execute_Reader("select *from doibong");
            //while (dr.Read())
            //    madb.Items.Add(dr["madb"]);
            SqlDataReader dr = SQLProvider.Execute_Reader("select *from doibong");
            while (dr.Read())
                madb.Items.Add(dr["tendb"]);
        }
    }
}
