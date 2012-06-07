using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DALayer;
//using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class QuanLyThiDau_BLL
    {                                       //bi
                                            public DataTable LoadLichThiDau(string query)
                                            {
                                                return SQLProvider.Store_Execute_Table(query);
                                            }
                                            //bi

                                            public DataTable LoadRaSan(string query)
                                            {
                                                return SQLProvider.Store_Execute_Table(query);
                                            }
                                            //bi


        public DataTable Load(string query)
        {
            return SQLProvider.Fill_Table(query);
        }

        XepLichThiDauAdapter xl = new XepLichThiDauAdapter();
        //tab xep lich thi dau
        public bool Insert_TranDau(TranDau a)
        {
            return xl.insert_TranDau(a);
        }

        public bool Delete_TranDau(TranDau a)
        {
            return xl.Delete_TranDau(a);
        }

        public bool Update_TranDau(TranDau a)
        {
            return xl.Update_TranDau(a);
        }

        public void MaSan(ComboBox masan)
        { 
            xl.MaSan(masan); 
        }

        public void MaDB_ThiDau(ComboBox madb)
        {
            xl.MaDB(madb);
        }
                                           //
                                            public DataTable TimMaDBTheoTen(string tendb)
                                            {
                                                DoiBongAdapter db=new DoiBongAdapter();
                                                return db.TimMaDBTheoTen(tendb);
                                            }

                                            public DataTable TimMaSanTheoTen(string tensan)
                                            {
                                                SanAdapter san = new SanAdapter();
                                                return san.TimMaSanTheoTen(tensan);
                                            }
                                            //
        //tb ra san
        RaSanAdapter rs = new RaSanAdapter();
        public bool Insert_RaSan(RaSan a)
        {
            return rs.Insert_RaSan(a);
        }

        public bool Delete_RaSan(RaSan a)
        {
            return rs.Delete_RaSan(a);
        }

        public bool Update_RaSan(RaSan a)
        {
            return rs.Update_RaSan(a);
        }

        public void MaTrD(ComboBox matrd)
        {
            rs.MaTranDau(matrd);
        }

        public void MaCT_RaSan(ComboBox mact, ComboBox matrd)
        {
            rs.MaCauThu(mact, matrd);
        }
                                                            //bi   
                                                            public DataTable TimMaCTTheoTen(string tenct)
                                                            {
                                                                CauThuAdapter ct=new CauThuAdapter();
                                                                return ct.TimMaCTTheoTen(tenct);
                                                            }
                                                            //bi
    }
                                                        
}
