using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok02_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolgozo Pista = new Dolgozo();
            Console.WriteLine("Kérem a Dolgozó Vezetéknevét!");
            Pista.vezeteknev = Console.ReadLine();
            Console.WriteLine("Kérem a Dolgozó Keresztnevét!");
            Pista.keresztnev = Console.ReadLine();
            Console.WriteLine("Kérem a Dolgozó gyerekeinek a számát!");
            Pista.gyermekekSzama = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a Dolgozó Születési évét!");
            Pista.szulEv = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} Havi Családi pótléka: {1} Ft.-",Pista.keresztnev,Pista.CsaladiPotlek());
            Pista.Nyugdij();
            Console.ReadKey();

        }
    }
}
