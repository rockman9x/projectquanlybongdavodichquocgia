using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class QuyDinh
    {
        private string maqd;

        public QuyDinh()
        { }

        public string Maqd
        {
            get { return maqd; }
            set { maqd = value; }
        }
        private string tenqd;

        public string Tenqd
        {
            get { return tenqd; }
            set { tenqd = value; }
        }

        private string giatri;

        public string GiaTri
        {
            get { return giatri; }
            set { giatri = value; }
        }

        public QuyDinh(string maquydinh, string tenquydinh, string gtri)
        {
            maqd = maquydinh;
            tenqd = tenquydinh;
            giatri = gtri;
        }
        public override string ToString()
        {
            return Maqd;
        }
    }
}
