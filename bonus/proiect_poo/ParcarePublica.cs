using System;
using System.Collections.Generic;

namespace ProiectPOO
{
    public class ParcarePublica
    {
        private List<LocParcare> LocuriParcare;
        private double TarifaOra;

        public ParcarePublica(int numarLocuri, double tarifaOra)
        {
            LocuriParcare = new List<LocParcare>();
            TarifaOra = tarifaOra;

            for (int i = 1; i <= numarLocuri; i++)
            {
                LocuriParcare.Add(new LocParcare(i, "Public"));
            }
        }

        public void AfisareLocuri()
        {
            Console.WriteLine("Locuri disponibile în parcarea publică:");
            foreach (var loc in LocuriParcare)
            {
                Console.WriteLine($"Loc {loc.numar} - {(loc.esteRezervat ? "Rezervat" : "Liber")}");
            }
        }

        public void RezervareLoc(int numarLoc, int oreRezervare)
        {
            var loc = LocuriParcare.Find(l => l.numar == numarLoc);
            if (loc != null && !loc.esteRezervat)
            {
                loc.Rezerva();
                double cost = CalculTarif(oreRezervare);
                Console.WriteLine($"Locul {numarLoc} a fost rezervat pentru {oreRezervare} ore. Cost: {cost} RON.");
            }
            else
            {
                Console.WriteLine("Locul nu poate fi rezervat. Este fie inexistent, fie deja rezervat.");
            }
        }

        public void ElibereazaLoc(int numarLoc)
        {
            var loc = LocuriParcare.Find(l => l.numar == numarLoc);
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

        private double CalculTarif(int oreRezervare)
        {
            return oreRezervare * TarifaOra;
        }
    }
}
