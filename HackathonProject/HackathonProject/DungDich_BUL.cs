using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class DungDich_BUL
    {
        public static List<DungDich> LoadDungDich()
        {
            return DungDich_DAL.LoadDungDich();
        }

        public static bool InsertDungDich(DungDich dungDichThiNghiem)
        {
            /*Call method insert city into THANHPHO_DAL layer*/
            bool result = DungDich_DAL.InsertDungDich(dungDichThiNghiem);
            return result;
        }

        public static bool DeleteDungDich(string maDungDich)
        {
            bool result = DungDich_DAL.DeleteDungDich(maDungDich);
            return result;
        }
    }
}
