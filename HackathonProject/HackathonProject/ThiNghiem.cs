using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class ThiNghiem
    {
        private string maThiNghiem;
        private string maVat;
        private string maDungDich;
        private DateTime thoiGianThucHien;

        public string MaThiNghiem
        {
            get
            {
                return maThiNghiem;
            }

            set
            {
                maThiNghiem = value;
            }
        }

        public string MaVat
        {
            get
            {
                return maVat;
            }

            set
            {
                maVat = value;
            }
        }

        public string MaDungDich
        {
            get
            {
                return maDungDich;
            }

            set
            {
                maDungDich = value;
            }
        }

        public DateTime ThoiGianThucHien
        {
            get
            {
                return thoiGianThucHien;
            }

            set
            {
                thoiGianThucHien = value;
            }
        }

        //public string MaThiNghiem { get => maThiNghiem; set => maThiNghiem = value; }
        //public string MaVat { get => maVat; set => maVat = value; }
        //public string MaDungDich { get => maDungDich; set => maDungDich = value; }
        //public DateTime ThoiGianThucHien { get => thoiGianThucHien; set => thoiGianThucHien = value; }
    }
}
