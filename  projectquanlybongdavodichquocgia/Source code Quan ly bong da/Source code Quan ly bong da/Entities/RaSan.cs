using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class RaSan
    {
        private string mars;

        public string Mars
        {
            get { return mars; }
            set { mars = value; }
        }
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
        private string mavt;

        public string Mavt
        {
            get { return mavt; }
            set { mavt = value; }
        }

        public RaSan() { }

        public RaSan(string marasan, string matrandau, string macauthu, string mavitri)
        {
            mars = marasan;
            matrd = matrandau;
            mact = macauthu;
            mavt = mavitri;
        }

    }
}
