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
    public class CauThuAdapter
    {
        public static CauThuAdapter CreateCauThuAdapter()
        { return new CauThuAdapter() ;}

        /// <summary>
        /// ket noi du lieu sql
        /// </summary>
        /// <returns></returns>
        //public static SqlConnection StartConnectToDataBase()
        //{
        //    return ConnectToDataBase.StartConnection();
        //}

        public bool Insert_CauThu(CauThu entity)
        {
            SqlParameter[] pa = new SqlParameter[8];
            pa[0] = new SqlParameter("@mact", entity.Mact);
            pa[1] = new SqlParameter("@madb", entity.Madb);
            pa[2] = new SqlParameter("@hoten_ct", entity.Hotenct);
            pa[3] = new SqlParameter("@gioitinh", entity.Gioitinh);
            pa[4] = new SqlParameter("@ngaysinh", entity.Ngaysinh);
            pa[5] = new SqlParameter("@soao", entity.Soao);
            pa[6] = new SqlParameter("@mavt", entity.Mavt);
            pa[7] = new SqlParameter("@quoctich", entity.Quoctich);
            return SQLProvider.Execute_NonQuery("Insert_CauThu", pa);
        }

        public bool Delete_CauThu(CauThu entity)
        {
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@maCt", entity.Mact);
            return SQLProvider.Execute_NonQuery("Delete_CauThu", pa);
        }

        public bool Update_CauThu(CauThu entity)
        {
            SqlParameter[] pa = new SqlParameter[8];
            pa[0] = new SqlParameter("@mact_1", entity.Mact);
            pa[1] = new SqlParameter("@madb_3", entity.Madb);
            pa[2] = new SqlParameter("@hoten_ct_4", entity.Hotenct);
            pa[3] = new SqlParameter("@gioitinh_5", entity.Gioitinh);
            pa[4] = new SqlParameter("@ngaysinh_6", entity.Ngaysinh);
            pa[5] = new SqlParameter("@soao_7", entity.Soao);
            pa[6] = new SqlParameter("@mavt_8", entity.Mavt);
            pa[7] = new SqlParameter("@QuocTich_9", entity.Quoctich);
            //pa[8] = new SqlParameter("@thephat", entity.Thephat);
            //pa[9] = new SqlParameter("@ghiban", entity.Ghiban);
            return SQLProvider.Execute_NonQuery("update_CauThu", pa);
        }

        public void MaDB(ComboBox madb)
        {
            //string s = SQLProvider.GetAll("doibong");
            //SqlDataReader dr = SQLProvider.Execute_Reader(s);
            //while (dr.Read())
            //{
            //    madb.Items.Add(dr["madb"]);
            //}
            string s = SQLProvider.GetAll("doibong");
            SqlDataReader dr = SQLProvider.Execute_Reader(s);
            while (dr.Read())
            {
                madb.Items.Add(dr["tendb"]);
            }
        }

        public DataTable TimMaCTTheoTen(string tendb)
        {
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@tenct", tendb);
            return SQLProvider.Fill_Table("TimMaCTTheoTen", paras);
        }
    }
}
