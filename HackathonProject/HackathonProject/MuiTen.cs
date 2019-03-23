using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class MuiTen
    {
        public double fa, fms, p, hopluc;
        public double PLenght = 90;
        public double FALenght()
        {
            return (Math.Abs(fa) / Math.Abs(p)) * PLenght;
        }
        public double FMSLenght()
        {
            return (Math.Abs(fms) / Math.Abs(p)) * PLenght;
        }
        public double HoplucLenght()
        {
            return (Math.Abs(hopluc) / Math.Abs(p)) * PLenght;
        }
    }
}
