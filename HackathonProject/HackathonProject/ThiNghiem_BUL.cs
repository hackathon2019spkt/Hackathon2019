using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class ThiNghiem_BUL
    {
        public static List<ThiNghiem> LoadThiNghiem()
        {
            return ThiNghiem_DAL.LoadThiNghiem();
        }

        public static bool InsertThiNghiem(ThiNghiem thiNghiem)
        {
            /*Call method insert city into THANHPHO_DAL layer*/
            bool result = ThiNghiem_DAL.InsertThiNghiem(thiNghiem);
            return result;
        }

        public static bool DeleteThiNghiem(string maThiNghiem)
        {
            bool result = ThiNghiem_DAL.DeleteThiNghiem(maThiNghiem);
            return result;
        }
    }
}
