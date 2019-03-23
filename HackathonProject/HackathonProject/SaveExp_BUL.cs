using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class SaveExp_BUL
    {
        public static List<SaveExp> LoadSave()
        {
            return SaveExp_DAL.LoadSave();
        }

        public static bool InsertSave(SaveExp saveExp)
        {
            /*Call method insert city into THANHPHO_DAL layer*/
            bool result = SaveExp_DAL.InsertSave(saveExp);
            return result;
        }

        public static bool DeleteSave(string id)
        {
            bool result = SaveExp_DAL.DeleteSave(id);
            return result;
        }
    }
}
