using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DALayer;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class QuanLyTrongTai_BLL
    {

                                    //bi
                                    public DataTable LoadTrongTai(string query)
                                    {
                                        return SQLProvider.Store_Execute_Table(query);
                                    }

                                    public DataTable TimMaTTTheoTen(string tentt)
                                    {
                                        TrongTaiAdapter tt = new TrongTaiAdapter();
                                        return tt.TimMaTTTheoTen(tentt);
                                    }

                                    //bi
        public DataTable Load(string query)
        {
            return SQLProvider.Fill_Table(query);
        }

        //Tab Trong tai
        public bool Insert_TrongTai(TrongTai tt)
        {
            TrongTaiAdapter a = TrongTaiAdapter.CreateTrongTaiAdapter();
            return a.Insert_TrongTai(tt);
        }

        public bool Delete_TrongTai(TrongTai tt)
        {
            TrongTaiAdapter a = TrongTaiAdapter.CreateTrongTaiAdapter();
            return a.Delete_TrongTai(tt);
        }

        public bool Update_TrongTai(TrongTai tt)
        {
            TrongTaiAdapter a = TrongTaiAdapter.CreateTrongTaiAdapter();
            return a.Update_TrongTai(tt);
        }

        //Tab dieu khien
        DieuKhienAdapter a = new DieuKhienAdapter();
        public bool Insert_DieuKhien(DieuKhien dk)
        {
            return a.Insert_DieuKhien(dk);
        }

        public bool Delete_DieuKhien(DieuKhien dk)
        {
            return a.Delete_DieuKhien(dk);
        }

        public bool Update_DieuKhien(DieuKhien dk)
        {
            return a.Update_DieuKhien(dk);
        }

        public void MaTrD(ComboBox matrd)
        {
            a.MaTranDau(matrd);
        }

        public void MaTrongTai(ComboBox matt)
        {
            a.MaTrongTai(matt);
        }

      



    }
}
