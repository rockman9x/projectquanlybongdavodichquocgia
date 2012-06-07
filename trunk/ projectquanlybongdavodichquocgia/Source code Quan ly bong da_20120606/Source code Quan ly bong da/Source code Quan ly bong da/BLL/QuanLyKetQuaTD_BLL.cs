using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DALayer;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BLL
{
    public class QuanLyKetQuaTD_BLL
    {
        ////bi
        //public DataTable LoadKQ(string query)
        //{
        //    return SQLProvider.Fill_Table(query);
        //}                                   

        //public DataTable LoadGhiBan(string query)
        //{
        //    return SQLProvider.Store_Execute_Table(query);
        //}

        //public DataTable LoadPhat(string query)
        //{
        //    return SQLProvider.Store_Execute_Table(query);
        //}
        ////bi

        public DataTable Load(string query)
        { return SQLProvider.Fill_Table(query); }


        //Tab Ket qua thi dau
        KetQuaThiDauAdapter adapter_kqtd = new KetQuaThiDauAdapter();
        public bool Insert_KetQua(KetQua kq)
        {
            return adapter_kqtd.Insert_KetQuaTD(kq);
        }

        public bool Delete_KetQua(KetQua kq)
        {
            return adapter_kqtd.Delete_KetQuaTD(kq);
        }

        public bool Update_KetQua(KetQua kq)
        {      
            return adapter_kqtd.Update_KetQuaTD(kq);
        }

        public void MaDoiBong_by_MaTranDau_KQ(ComboBox c,ComboBox a_by_c)
        {
            adapter_kqtd.MaDoiBong(c,a_by_c);
        }

        public void MaTranDau_KQ(ComboBox matrd)
        {
            adapter_kqtd.MaTranDau(matrd);
        }

        //bi
        public DataTable TimMaDBTheoTen(string tendb)
        {
            DoiBongAdapter db = new DoiBongAdapter();
            return db.TimMaDBTheoTen(tendb);
        }


        //Tab Danh sach cau thu ghi ban
        DSCauThuGhiBanAdapter adapter_dsgb = new DSCauThuGhiBanAdapter();

        public bool Insert_GhiBan(GhiBan gb)
        {
            return adapter_dsgb.Insert_GhiBan(gb);
        }

        public bool Delete_GhiBan(GhiBan gb)
        {
            return adapter_dsgb.Delete_GhiBan(gb);
        }
        public bool Update_GhiBan(GhiBan gb)
        {
            return adapter_dsgb.Update_GhiBan(gb);
        }

        public void MaCauThu_by_MaTranDau_GhiBan(ComboBox c, ComboBox a_by_c)
        {
            adapter_dsgb.MaCauThu(c, a_by_c);
        }

        public void MaTranDau_GhiBan(ComboBox matrd)
        {
            adapter_dsgb.MaTranDau(matrd);
        }

        public DataTable TimMaCTTheoTen(string tenct)
        {
            CauThuAdapter ct = new CauThuAdapter();
            return ct.TimMaCTTheoTen(tenct);
        }
        //Tab danh sach cau thu bi phat

        DSCauThuBiPhatAdapter adapter_dsphat = new DSCauThuBiPhatAdapter();

        public bool Insert_Phat(Phat p)
        {
            return adapter_dsphat.Insert_Phat(p);
        }

        public bool Delete_Phat(Phat p)
        {
            return adapter_dsphat.Delete_Phat(p);
        }

        public bool Update_Phat(Phat p)
        {
            return adapter_dsphat.Update_Phat(p);
        }

        public void MaCauThu_by_MaTranDau_Phat(ComboBox MaCT, ComboBox Matrd)
        {
            adapter_dsphat.MaCauThu(MaCT, Matrd);
        }

        public void MaTranDau_Phat(ComboBox matrd)
        {
            adapter_dsphat.MaTranDau(matrd);
        }
        //Tab xep hang 
       
    }
}
