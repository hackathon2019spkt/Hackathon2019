using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class KhoiCau
    {
        const double g = 9.81;
        public double rho; // khoi luong rieng cua vat
        public double R; // ban kinh vat hinh cau
        public double rho0; // khoi luong rieng chat long 
        public double mu = 0.0009; // do nhot cua chat long
        public double dt = 0.0005;
        public double time = 0;
        public double S, V, m, k1, k2, fa, aa, a, vt, fms, h;

        public KhoiCau(double khoiluongriengvat, double bankinhvat, double khoiluongriengchatlong, double h0)
        {
            rho = khoiluongriengvat;
            R = bankinhvat;
            rho0 = khoiluongriengchatlong;
            h = h0;
        }

        public void SetValue()
        {
            S = Math.PI * (R * R);
            V = (4 / 3) * Math.PI * (R * R * R);
            m = rho * V;

            k1 = 6 * Math.PI * mu * R; // dinh luat Stokes
            k2 = 0.5 * 0.4 * S * rho0; // cong thuc tinh k2 danh cho vat hinh cau

            vt = 0;
            fa = rho0 * g * V;
            aa = fa / m;
        }
        public void DeltaY(bool IsInLiquid)
        {
            if (IsInLiquid)
            {
                fms = Math.Sign(vt) * k1 * vt - Math.Sign(vt) * k2 * vt * vt;
                a = -g + aa + fms / m;
            }
            else
            {
                a = -g;    
            }
            vt += a * dt;

            h += vt * dt + 0.5 * a * dt * dt;
            time += dt;
        }
    }
}

