using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace termek_cskbalazs
{
    internal class Termek
    {
        string cikkszam;
        public string megnevezes;
        public int beszerzesiar;
        int afakulcs;
        bool akcios;
        int kedvezmény;
        
        public double netto()
        {
            double netto = Math.Round(beszerzesiar * 1.35, 2);
            return netto;
        }
        public brutto()
        {
            int brutto =  Math.Round(netto * (100 + afakulcs) / 100,0);
            return brutto;
        }
        public string akciose()
        {
            if (akcios == "Igen" || "igen")
            {
                Console.WriteLine($"A {cikkszam}, {megnevezes} jelenleg akciós");
            }
            else if (akcios == "Nem" || "nem")
            {
                Console.WriteLine($"A {cikkszam}, {megnevezes} jelenleg nem akciós");
            }
        }
        public double kedvar()
        {
            double kedvar = Math.Round(brutto * (100 - kedvezmény) / 100,0);
        }

    }
}
