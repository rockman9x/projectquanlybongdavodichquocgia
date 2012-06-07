using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class CauThu
    {
        private string mact;

        public string Mact
        {
            get { return mact; }
            set { mact = value; }
        }
        private string madb;

        public string Madb
        {
            get { return madb; }
            set { madb = value; }
        }
        private string hotenct;

        public string Hotenct
        {
            get { return hotenct; }
            set { hotenct = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private DateTime ngaysinh;

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private string soao;

        public string Soao
        {
            get { return soao; }
            set { soao = value; }
        }
        private string mavt;

        public string Mavt
        {
            get { return mavt; }
            set { mavt = value; }
        }

        private string quoctich;

        public string Quoctich
        {
            get { return quoctich; }
            set { quoctich = value; }
        }
        private int ghiban;

        public int Ghiban
        {
            get { return ghiban; }
            set { ghiban = value; }
        }
        private int thephat;

        public int Thephat
        {
            get { return thephat; }
            set { thephat = value; }
        }

        public CauThu()
        { }

        public CauThu(string ma, string madbong, string hoten, string phai, DateTime ngsinh, string soaoct, string mavtri, string quoctichct,int the,int ghib)
        {
            mact = ma;
            madb = madbong;
            hotenct = hoten;
            gioitinh = phai;
            ngaysinh = ngsinh;
            soao = soaoct;
            mavt = mavtri;
            quoctich = quoctichct;
            thephat = the;
            ghiban = ghib;
        }
        public override string ToString()
        {
            return Mact;
        }

    }
}
