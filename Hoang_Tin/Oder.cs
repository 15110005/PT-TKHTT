using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoang_Tin
{
    class Oder
    {
        private int maOder;
        private string maBan;
        private string maNV;
        private DateTime ngay;

        public int MaOder
        {
            get { return maOder; }
            set { maOder = value; }
        }

        public string MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public DateTime Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
    }
}
