using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Phat
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
        private string maphat;

        public string Maphat
        {
            get { return maphat; }
            set { maphat = value; }
        }
        private int thoidiem;

        public int Thoidiem
        {
            get { return thoidiem; }
            set { thoidiem = value; }
        }

        private string loaithe;

        public string Loaithe
        {
            get { return loaithe; }
            set { loaithe = value; }
        }

        public Phat() { }

        public Phat(string matrandau, string macauthu, string mathephat, int thoidiemphat, string loaithephat)
        {
            matrd = matrandau;
            mact = macauthu;
            maphat = mathephat;
            thoidiem = thoidiemphat;
            loaithe = loaithephat;
        }

    }
}
