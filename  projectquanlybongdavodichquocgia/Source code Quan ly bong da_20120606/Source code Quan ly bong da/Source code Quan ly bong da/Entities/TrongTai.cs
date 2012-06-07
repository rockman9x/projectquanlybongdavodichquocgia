using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class TrongTai
    {
        private string matt;

        public string Matt
        {
            get { return matt; }
            set { matt = value; }
        }
        private string tentt;

        public string Tentt
        {
            get { return tentt; }
            set { tentt = value; }
        }
        private DateTime ngaysinh;

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        public TrongTai() { }
        public TrongTai(string ma, string ten, DateTime ngsinh)
        { matt = ma; tentt = ten; ngaysinh = ngsinh; }

        public override string ToString()
        {
            return Matt;
        }

    }
}
