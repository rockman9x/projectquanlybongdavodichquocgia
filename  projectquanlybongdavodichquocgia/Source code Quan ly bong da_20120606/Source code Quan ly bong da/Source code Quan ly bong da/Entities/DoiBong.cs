using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class DoiBong
    {
        private string madb;

        public string Madb
        {
            get { return madb; }
            set { madb = value; }
        }
        private string tendb;

        public string Tendb
        {
            get { return tendb; }
            set { tendb = value; }
        }
        private string masan;

        public string Masan
        {
            get { return masan; }
            set { masan = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private int TongDiem;

        public int TongDiem1
        {
            get { return TongDiem; }
            set { TongDiem = value; }
        }

        private int soBanGhiDuoc;

        public int SoBanGhiDuoc
        {
            get { return soBanGhiDuoc; }
            set { soBanGhiDuoc = value; }
        }
        private int soBanBiLotLuoi;

        public int SoBanBiLotLuoi
        {
            get { return soBanBiLotLuoi; }
            set { soBanBiLotLuoi = value; }
        }

        public DoiBong()
        { }

        public DoiBong(string ma, string ten, string san, string dchi,int td,int gd, int ll)
        {
            madb = ma;
            tendb = ten;
            masan = san;
            diachi = dchi;
            TongDiem = td;
            soBanBiLotLuoi = ll;
            soBanGhiDuoc = gd;
        }
        

        public override string ToString()
        {
            return Madb;
        }
    }
}
