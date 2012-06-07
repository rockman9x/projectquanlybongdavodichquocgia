using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    class ViTri
    {
        private string mavt;

        public string Mavt
        {
            get { return mavt; }
            set { mavt = value; }
        }
        private string tenvt;

        public string Tenvt
        {
            get { return tenvt; }
            set { tenvt = value; }
        }

        public ViTri() { }

        public ViTri(string mavitri, string tenvitri)
        { mavt = mavitri; tenvt = tenvitri; }

    }
}
