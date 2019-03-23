using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class Vat
    {
        private string maVat;
        private string tenVat;
        private string giaTriVat;
        private string iSDEFAUT;

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

        public string TenVat
        {
            get
            {
                return tenVat;
            }

            set
            {
                tenVat = value;
            }
        }

        public string GiaTriVat
        {
            get
            {
                return giaTriVat;
            }

            set
            {
                giaTriVat = value;
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









        //public string MaVat { get => maVat; set => maVat = value; }
        //public string TenVat { get => tenVat; set => tenVat = value; }
        //public string GiaTriVat { get => giaTriVat; set => giaTriVat = value; }
    }
}
