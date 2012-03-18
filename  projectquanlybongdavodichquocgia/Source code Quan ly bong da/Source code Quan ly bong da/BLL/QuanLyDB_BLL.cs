using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using Entities;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BLL
{
    public class QuanLyDB_BLL
    {
                                            //bi
                                            public DataTable LoaDBBi(string q)
                                            {
                                                return SQLProvider.Store_Execute_Table(q);
                                            }
                                            //bi
        //Tab Doi bong
        DoiBongAdapter adapter = DoiBongAdapter.CreatDoiBongAdapter();

        public DataTable DSDoiBong(string query)
        {
            return SQLProvider.Fill_Table(query);
        }        


        public bool Insert_DoiBong(DoiBong db)
        {
            return adapter.Insert_DoiBong(db);
        }

        public bool Delete_DoiBong(DoiBong db)
        {
            return adapter.Delete_DoiBong(db);
        }

        public bool Update_DoiBong(DoiBong db)
        {
            return adapter.Update_DoiBong(db);
        }

        public void MaSan(ComboBox masan)
        {
            adapter.MaSan(masan);
        }

                                        //bi
                                        public DataTable TimMaSanTheoTen(string tensan)
                                        {
                                            SanAdapter a = SanAdapter.CreatSanAdapter();
                                            return a.TimMaSanTheoTen(tensan);
                                        }
                                        //bi
        //Tab san

        public DataTable San(string query)
        {
            return SQLProvider.Fill_Table(query);
        }

        public bool Insert_San(San s)
        {
            SanAdapter a = SanAdapter.CreatSanAdapter();
            return a.Insert_San(s);
        }

        public bool Update_San(San s)
        {
            SanAdapter a = SanAdapter.CreatSanAdapter();
            return a.Update_San(s);
        }

        public bool Delete_San(San s)
        {
            SanAdapter a = new SanAdapter();
            return a.Delete_San(s);
        }

        //Tab Ban Huan Luyen
        BHLAdapter a_BHL = BHLAdapter.CreatBHLAdapter();


                                    //bi
                                    public DataTable LoadBHL(string query)
                                    {
                                        return SQLProvider.Store_Execute_Table(query);
                                    }
                                    //bi



        public DataTable BHL(string query)
        {
            return SQLProvider.Fill_Table(query);
        }

        public bool Insert_BHL(BHL bhl)
        {

            return a_BHL.Insert_BHL(bhl);
        }

        public bool Delete_BHL(BHL bhl)
        {
            return a_BHL.Delete_BHL(bhl);
        }

        public bool Update_BHL(BHL bhl)
        {
            return a_BHL.Update_BHL(bhl);
        }

        public void MaDB(ComboBox madb)
        {
            a_BHL.MaDB(madb);
        }
                                                //bi
                                                public DataTable TimMaDBTheoTen(string tendb)
                                                {
                                                    return adapter.TimMaDBTheoTen(tendb);
                                                }
                                                   //bi
    }
}
