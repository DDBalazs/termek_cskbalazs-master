using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace termek_cskbalazs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cikkszám: ");
            string cikkszam = Console.ReadLine();

            Console.WriteLine("Megnevezése: ")
            string megnevezes = Console.ReadLine();

            Console.WriteLine("Beszerzési ár: ")
            int beszerzesiar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ÁFA kulcs: ");
            int afakulcs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Akciós?");
            string akcios = Console.ReadLine();

            Console.WriteLine("Kedvezmény értéke: ")
            int kedvezmeny = int.Parse(Console.ReadLine());


            Termekek t = new Termek(cikkszam, megnevezes, beszerzesiar, afakulcs, akcios, kedvezmeny);
            Console.WriteLine($"Nettó ár: {t.netto}")
            Console.WriteLine($"Brutto ár: {t.brutto}");
            
            if( t.akcios = "Igen")
            {
                Console.WriteLine($"A {t.cikkszam} {t.megnevezes} jelengleg akciós")
                Console.WriteLine($"Kedvezményes ár: {t.kedvezmeny}");
            }
            else
            {
                Console.WriteLine($"A {t.cikkszam} {t.megnevezes} jelengleg nem akciós")
            }

            Console.ReadKey();
        }
        
    }
}
