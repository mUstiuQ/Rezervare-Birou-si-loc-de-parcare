using System;
using System.Collections.Generic;

namespace ProiectPOO
{
    public class Administrator : Angajat
    {
        public Administrator(string nume, string prenume) : base(nume, prenume) { }

        public void AdaugaLoc<T>(List<T> locuri, T locNou) where T : Loc
        {
            locuri.Add(locNou);
            Console.WriteLine($"Locul {locNou.numar} a fost adaugat.");
        }

        public void ModificaLoc<T>(List<T> locuri, int numarLoc, T locModificat) where T : Loc
        {
            var loc = locuri.Find(l => l.numar == numarLoc);
            if (loc != null)
            {
                locuri.Remove(loc);
                locuri.Add(locModificat);
                Console.WriteLine($"Locul {numarLoc} a fost modificat.");
            }
            else
            {
                Console.WriteLine("Locul specificat nu exista.");
            }
        }

        public void StergeLoc<T>(List<T> locuri, int numarLoc) where T : Loc
        {
            var loc = locuri.Find(l => l.numar == numarLoc);
            if (loc != null)
            {
                locuri.Remove(loc);
                Console.WriteLine($"Locul {numarLoc} a fost sters.");
            }
            else
            {
                Console.WriteLine("Locul specificat nu exista.");
            }
        }

        public void VizualizareToateLocurile(List<LocBirou> locuriBirou, List<LocParcare> locuriParcare)
        {
            Console.WriteLine("Toate locurile de birou:");
            foreach (var loc in locuriBirou)
            {
                Console.WriteLine($"Loc {loc.numar} - {(loc.esteRezervat ? "Rezervat" : "Liber")}");
            }

            Console.WriteLine("\nToate locurile de parcare:");
            foreach (var loc in locuriParcare)
            {
                Console.WriteLine($"Loc {loc.numar} - {(loc.esteRezervat ? "Rezervat" : "Liber")}");
            }
        }
    }
}
