using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class TranDau
    {
        private string matrd;

        public string Matrd
        {
            get { return matrd; }
            set { matrd = value; }
        }
        private string madb1;

        public string Madb1
        {
            get { return madb1; }
            set { madb1 = value; }
        }
        private string madb2;

        public string Madb2
        {
            get { return madb2; }
            set { madb2 = value; }
        }
        private string masan;

        public string Masan
        {
            get { return masan; }
            set { masan = value; }
        }
        private DateTime ngaygio;

        public DateTime Ngaygio
        {
            get { return ngaygio; }
            set { ngaygio = value; }
        }

        private string gioThiDau;

        public string GioThiDau
        {
            get { return gioThiDau; }
            set { gioThiDau = value; }
        }

        private int vong;

        public int Vong
        {
            get { return vong; }
            set { vong = value; }
        }

        public TranDau() { }

        public TranDau(string matrdau, string madoibong1, string madoibong2, string masandau, DateTime ngaygiothidau, string gio, int vongdau)
        {
            matrd = matrdau;
            madb1 = madoibong1;
            madb2 = madoibong2;
            masan = masandau;
            ngaygio = ngaygiothidau;
            gioThiDau = gio;
            vong = vongdau;
        }

        public override string ToString()
        {
            return matrd;
        }

    }
}
