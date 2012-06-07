using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace DALayer
{
    public class XepLichThiDauAdapter
    {
        public bool insert_TranDau(TranDau entity)
        {
            SqlParameter[] pa = new SqlParameter[7];
            string ma = "TD";
            int matd = 0;
            if (string.Compare(entity.Matrd, "") != 0)
            {
                matd = int.Parse(entity.Matrd.Replace("TD", ""));
            }
            matd++;
            if (matd < 10)
            {
                entity.Matrd = ma + "0" + matd;
            }
            else
            {
                entity.Matrd = ma + matd;
            }
            
            pa[0] = new SqlParameter("@MaTrD", entity.Matrd);
            pa[1] = new SqlParameter("@Madb1", entity.Madb1);
            pa[2] = new SqlParameter("@Madb2", entity.Madb2);
            pa[3] = new SqlParameter("@Masan", entity.Masan);
            pa[4] = new SqlParameter("@ngaygio", entity.Ngaygio);
            pa[5] = new SqlParameter("@giothidau", entity.GioThiDau);
            pa[6] = new SqlParameter("@Vong", entity.Vong);
            return SQLProvider.Execute_NonQuery("insert_trandau_1", pa);
        }

        public bool Delete_TranDau(TranDau entity)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@MaTrD", entity.Matrd);

            return SQLProvider.Execute_NonQuery("delete_trandau_1", pa);
        }

        public bool Update_TranDau(TranDau entity)
        {
            SqlParameter[] pa = new SqlParameter[7];
            pa[0] = new SqlParameter("@MaTrD", entity.Matrd);
            pa[1] = new SqlParameter("@Madb1", entity.Madb1);
            pa[2] = new SqlParameter("@Madb2", entity.Madb2);
            pa[3] = new SqlParameter("@Masan", entity.Masan);
            pa[4] = new SqlParameter("@ngaygio", entity.Ngaygio);
            pa[5] = new SqlParameter("@giothidau", entity.GioThiDau);
            pa[6] = new SqlParameter("@Vong", entity.Vong);
            return SQLProvider.Execute_NonQuery("update_trandau_1", pa);
        }

        public void MaSan(ComboBox masan)
        {
            //SqlDataReader dr=SQLProvider .Execute_Reader(SQLProvider.GetAll("san"));
            //while (dr.Read())
            //    masan.Items.Add(dr["masan"]);
            SqlDataReader dr = SQLProvider.Execute_Reader(SQLProvider.GetAll("san"));
            while (dr.Read())
                masan.Items.Add(dr["tensan"]);
        }

        public void MaDB(ComboBox madb)
        {
            //SqlDataReader dr = SQLProvider.Execute_Reader(SQLProvider.GetAll("doibong"));
            //while (dr.Read())
            //    madb.Items.Add(dr["madb"]);
            SqlDataReader dr = SQLProvider.Execute_Reader(SQLProvider.GetAll("doibong"));
            while (dr.Read())
                madb.Items.Add(dr["tendb"]);
        }

        public DataTable TimMaTDTheoTen(string tendb1,string tendb2)
        {
            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@madb1", tendb1);
            paras[1] = new SqlParameter("@madb2", tendb2);
            return SQLProvider.Fill_Table("TimMaTDTheoTen", paras);
        }
    }
}
