using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    class VaiTro
    {
        private string mavtro;

        public string Mavtro
        {
            get { return mavtro; }
            set { mavtro = value; }
        }
        private string tenvtro;

        public string Tenvtro
        {
            get { return tenvtro; }
            set { tenvtro = value; }
        }

        public VaiTro() { }

        public VaiTro(string mavaitro, string tenvaitro)
        { mavtro = mavaitro; tenvtro = tenvaitro; }

    }
}
