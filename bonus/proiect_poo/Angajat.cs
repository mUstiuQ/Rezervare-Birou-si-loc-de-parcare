using System;
using System.Collections.Generic;

namespace ProiectPOO
{
    public class Angajat
    {
        private string Nume;

        public string numee
        {
            get { return Nume; }
            set { Nume = value; }
        }
        private string Prenume;

        public string prenume
        {
            get { return Prenume; }
            set { Prenume = value; }
        }
        private List<Loc> Rezervari;

        public List<Loc> rezervari
        {
            get { return Rezervari; }
            set { Rezervari = value; }
        }

        public Angajat(string nume, string prenume)
        {
            Nume = nume;
            Prenume = prenume;
            Rezervari = new List<Loc>();
        }

        public void VizualizeazaRezervari()
        {
            Console.WriteLine($"Rezervarile lui {Nume} {Prenume}:");
            if (Rezervari.Count == 0)
            {
                Console.WriteLine("Nu există rezervari.");
            }
            else
            {
                foreach (var rezervare in Rezervari)
                {
                    string tipLoc = rezervare is LocBirou ? "Birou" : "Parcare";
                    Console.WriteLine($"Loc {rezervare.numar} ({tipLoc}) - {(rezervare.esteRezervat ? "Rezervat" : "Liber")}");
                }
            }
        }

        public void AdaugaRezervare(Loc loc)
        {
            if (loc != null && !loc.esteRezervat)
            {
                loc.Rezerva();
                Rezervari.Add(loc);
                Console.WriteLine($"Rezervarea locului {loc.numar} a fost adaugata.");
            }
            else
            {
                Console.WriteLine("Locul nu poate fi rezervat.");
            }
        }

        public void ModificaRezervare(Loc locActual, Loc locNou)
        {
            if (Rezervari.Contains(locActual))
            {
                locActual.Elibereaza();
                Rezervari.Remove(locActual);

                AdaugaRezervare(locNou);
            }
            else
            {
                Console.WriteLine("Rezervarea specificata nu exista.");
            }
        }

        public void StergeRezervare(Loc loc)
        {
            if (Rezervari.Contains(loc))
            {
                loc.Elibereaza();
                Rezervari.Remove(loc);
                Console.WriteLine($"Rezervarea locului {loc.numar} a fost stearsa.");
            }
            else
            {
                Console.WriteLine("Rezervarea specificata nu exista.");
            }
        }
    }
}
