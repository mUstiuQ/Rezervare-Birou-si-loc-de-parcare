using System;
using System.Collections.Generic;

namespace ProiectPOO
{
    public class CoworkingSpace
    {
        private List<LocBirou> LocuriBirou;
        private Dictionary<string, double> TarifeTipBirou;

        public CoworkingSpace(int numarLocuri, Dictionary<string, double> tarifeTipBirou)
        {
            LocuriBirou = new List<LocBirou>();
            TarifeTipBirou = tarifeTipBirou;

            int contor = 1;
            foreach (var tip in tarifeTipBirou.Keys)
            {
                for (int i = 0; i < numarLocuri / tarifeTipBirou.Count; i++)
                {
                    LocuriBirou.Add(new LocBirou(contor++, tip));
                }
            }
        }

        public void AfisareLocuri()
        {
            Console.WriteLine("Locuri disponibile in spatiul de coworking:");
            foreach (var loc in LocuriBirou)
            {
                Console.WriteLine($"Loc {loc.numar} ({loc.tipBirou}) - {(loc.esteRezervat ? "Rezervat" : "Liber")}");
            }
        }

        public void RezervareLoc(int numarLoc, int oreRezervare)
        {
            var loc = LocuriBirou.Find(l => l.numar == numarLoc);
            if (loc != null && !loc.esteRezervat)
            {
                loc.Rezerva();
                double cost = CalculTarif(loc.tipBirou, oreRezervare);
                Console.WriteLine($"Locul {numarLoc} ({loc.tipBirou}) a fost rezervat pentru {oreRezervare} ore. Cost: {cost} RON.");
            }
            else
            {
                Console.WriteLine("Locul nu poate fi rezervat. Este fie inexistent, fie deja rezervat.");
            }
        }

        public void ElibereazaLoc(int numarLoc)
        {
            var loc = LocuriBirou.Find(l => l.numar == numarLoc);
            if (loc != null && loc.esteRezervat)
            {
                loc.Elibereaza();
                Console.WriteLine($"Locul {numarLoc} a fost eliberat.");
            }
            else
            {
                Console.WriteLine("Locul specificat nu este rezervat.");
            }
        }

        private double CalculTarif(string tipBirou, int oreRezervare)
        {
            if (TarifeTipBirou.ContainsKey(tipBirou))
            {
                return oreRezervare * TarifeTipBirou[tipBirou];
            }
            Console.WriteLine("Tipul de birou specificat nu are un tarif definit.");
            return 0;
        }
    }
}
