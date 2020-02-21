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
            Feladat1();
            Feladat2();

        }

        static void Feladat1() 
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

            Console.WriteLine("{0} Havi Családi pótléka: {1} Ft.-", Pista.keresztnev, Pista.CsaladiPotlek());
            Pista.Nyugdij();
            Console.ReadKey();
            Console.Clear();
        }
        static void Feladat2() 
        {
            Gomb gomb = new Gomb();
            Console.WriteLine("Kérem a gömb sugarát!");
            gomb.r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A gömb felszíne: {0:0.00}",gomb.Felszin());
            Console.WriteLine("A gömb térfogata: {0:0.00}",gomb.Terfogat());
            Console.ReadKey();
        }
    }
}
