using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok02_21
{
    class Dolgozo
    {
        public string vezeteknev;
        public string keresztnev;
        public int gyermekekSzama;
        public int szulEv;

        public int CsaladiPotlek() 
        {
            int fizetendo;
            if (gyermekekSzama == 1)
                fizetendo = 12200;
            else if (gyermekekSzama == 2)
                fizetendo = 13400 * gyermekekSzama;
            else if (gyermekekSzama >= 3)
                fizetendo = 16000 * gyermekekSzama;
            else
                fizetendo = 0;

            return fizetendo;
        }

        public void Nyugdij() 
        {
            int ev = 2020 - szulEv;
            if(ev < 63)
                Console.WriteLine("Még {0} év van a nyugdíjig!",63- ev);
            else
                Console.WriteLine("Már Nyugdíjas vagy!");
        }
    }
}
