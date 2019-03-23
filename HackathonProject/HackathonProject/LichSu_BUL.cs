using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class LichSu_BUL
    {
        public static List<LichSu> LoadLichSu()
        {
            return LichSu_DAL.LoadLichSu();
        }

        public static bool InsertLichSu(LichSu lichSu)
        {
            /*Call method insert city into THANHPHO_DAL layer*/
            bool result = LichSu_DAL.InsertLichSu(lichSu);
            return result;
        }

        public static bool DeleteLichSu(string maLichSu)
        {
            bool result = LichSu_DAL.DeleteLichSu(maLichSu);
            return result;
        }
    }
}
