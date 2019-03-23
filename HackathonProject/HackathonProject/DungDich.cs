using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class DungDich
    {
        private string maDungDich;
        private string tenDungDich;
        private string giaTraiDungDich;
        private string iSDEFAUT;

        //public string MaDungDich { get => maDungDich; set => maDungDich = value; }
        //public string TenDungDich { get => tenDungDich; set => tenDungDich = value; }
        //public string GiaTraiDungDich { get => giaTraiDungDich; set => giaTraiDungDich = value; }


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

        public string TenDungDich
        {
            get
            {
                return tenDungDich;
            }

            set
            {
                tenDungDich = value;
            }
        }

        public string GiaTraiDungDich
        {
            get
            {
                return giaTraiDungDich;
            }

            set
            {
                giaTraiDungDich = value;
            }
        }

        public string ISDEFAUT
        {
            get
            {
                return iSDEFAUT;
            }

            set
            {
                iSDEFAUT = value;
            }
        }
    }
}
