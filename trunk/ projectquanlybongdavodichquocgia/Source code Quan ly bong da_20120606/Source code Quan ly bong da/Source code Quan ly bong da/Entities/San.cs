using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class San
    {
        private string masan;

        public string Masan
        {
            get { return masan; }
            set { masan = value; }
        }
        private string tensan;

        public string Tensan
        {
            get { return tensan; }
            set { tensan = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private int succhua;

        public int Succhua
        {
            get { return succhua; }
            set { succhua = value; }
        }

        public San() { }

        public San(string ma, string ten, string diachisan, int succhuakg)
        {
            masan = ma;
            tensan = ten;
            diachi = diachisan;
            succhua = succhuakg;
        }

        public override string ToString()
        {
            return Masan ;
        }

    }
}
