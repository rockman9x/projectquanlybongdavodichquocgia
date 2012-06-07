using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class GhiBan
    {
        private string matrd;

        public string Matrd
        {
            get { return matrd; }
            set { matrd = value; }
        }
        private string mact;

        public string Mact
        {
            get { return mact; }
            set { mact = value; }
        }
        private string mabt;

        public string Mabt
        {
            get { return mabt; }
            set { mabt = value; }
        }
        private int thoidiem;

        public int Thoidiem
        {
            get { return thoidiem; }
            set { thoidiem = value; }
        }
        private string ghichu;

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }

        public GhiBan() { }

        public GhiBan(string matrandau, string macauthu, string mabanthang, int thoidiemghiban, string ghichubanthang)
        {
            matrd = matrandau;
            mact = macauthu;
            mabt = mabanthang;
            thoidiem = thoidiemghiban;
            ghichu = ghichubanthang;
        }

    }
}
