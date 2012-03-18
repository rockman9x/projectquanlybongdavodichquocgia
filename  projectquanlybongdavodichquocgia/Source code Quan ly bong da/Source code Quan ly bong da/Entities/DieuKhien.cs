using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class DieuKhien
    {
        private string madk;

        public string Madk
        {
            get { return madk; }
            set { madk = value; }
        }
        private string matrd;

        public string Matrd
        {
            get { return matrd; }
            set { matrd = value; }
        }
        private string matt;

        public string Matt
        {
            get { return matt; }
            set { matt = value; }
        }
        private string mavtro;

        public string Mavtro
        {
            get { return mavtro; }
            set { mavtro = value; }
        }

        public DieuKhien(){}

        public DieuKhien(string matrandau, string matrongtai, string mavaitro)
        {
            matrd = matrandau;
            matt = matrongtai;
            mavtro = mavaitro;
        }

    }
}
