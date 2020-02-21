using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok02_21
{
    class Gomb
    {
        public int r;

        public double Felszin()
        {
            double A = (double)4 * r * r * Math.PI;
            return A;
        }

        public double Terfogat()
        {
            double V = (double)(4 * Math.Pow(r, 3) * Math.PI) / 3;
            return V;
        }
    }
}
