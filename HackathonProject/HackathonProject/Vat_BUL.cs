using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class Vat_BUL
    {
        public static List<Vat> LoadVat()
        {
            return Vat_DAL.LoadVat();
        }

        public static bool InsertVat(Vat vatThiNghiem)
        {
            /*Call method insert city into THANHPHO_DAL layer*/
            bool result = Vat_DAL.InsertVat(vatThiNghiem);
            return result;
        }

        public static bool DeleteVat(string maVat)
        {
            bool result = Vat_DAL.DeleteVat(maVat);
            return result;
        }
    }
}
