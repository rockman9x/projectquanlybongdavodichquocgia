using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class BHL
    {
        private string mabhl;

        public string Mabhl
        {
            get { return mabhl; }
            set { mabhl = value; }
        }
        private string madb;

        public string Madb
        {
            get { return madb; }
            set { madb = value; }
        }
        private string hoten;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        private string chucvu;

        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }

        public BHL() { }

        public BHL(string mabanhuanluyen, string madoibong, string hotenhlv, string chucvuhlv)
        {
            mabhl = mabanhuanluyen;
            madb = madoibong;
            hoten = hotenhlv;
            chucvu = chucvuhlv;
        }

    }
}
