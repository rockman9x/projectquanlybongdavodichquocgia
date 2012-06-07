using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class KetQua
    {
        private string matrd;

        public string Matrd
        {
            get { return matrd; }
            set { matrd = value; }
        }
        private string madb;

        public string Madb
        {
            get { return madb; }
            set { madb = value; }
        }
        private int sobt;

        public int Sobt
        {
            get { return sobt; }
            set { sobt = value; }
        }
        private int sothe;

        public int Sothe
        {
            get { return sothe; }
            set { sothe = value; }
        }
        private string ketqua;

        public string Ketqua
        {
            get { return ketqua; }
            set { ketqua = value; }
        }

        public KetQua() { }

        public KetQua(string matrandau, string madoibong, int sobanthang, int sothephat, string ketquatrandau)
        {
            matrd = matrandau;
            madb = madoibong;
            sobt = sobanthang;
            sothe = sothephat;
            ketqua = ketquatrandau;
        }

    }
}
