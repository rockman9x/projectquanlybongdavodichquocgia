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
    public class QuanLyCT_BLL
    {
                                        //bi
                                        public DataTable DSCauThuBi(string query)
                                        {
                                            return SQLProvider.Store_Execute_Table(query);
                                        }
                                        //bi



        CauThuAdapter adapter = new CauThuAdapter();
        public DataTable DSCauThu(string query)
        {
            return SQLProvider.Fill_Table(query);
        }

        public bool Insert_CauThu(CauThu ct)
        {
            return adapter.Insert_CauThu(ct);
        }

        public bool Delete_CauThu(CauThu ct)
        {
            return adapter.Delete_CauThu(ct);
        }

        public bool Update_CauThu(CauThu ct)
        {
            return adapter.Update_CauThu(ct);
        }

        public void MaDB(ComboBox madb)
        {
            adapter.MaDB(madb);
        }
                                        //bi
                                        public DataTable TimMaDBTheoTen(string tendb)
                                        {
                                            DoiBongAdapter db = new DoiBongAdapter();
                                            return db.TimMaDBTheoTen(tendb);
                                        }
                                        //bi

    }
}
