using System;
using System.Collections.Generic;

namespace ProiectPOO
{
    public class Manager : Angajat
    {
        private List<Angajat> Echipa;

        public Manager(string nume, string prenume) : base(nume, prenume)
        {
            Echipa = new List<Angajat>();
        }

        public void AdaugaInEchipa(Angajat angajat)
        {
            if (!Echipa.Contains(angajat))
            {
                Echipa.Add(angajat);
                Console.WriteLine($"{angajat.numee} {angajat.prenume} a fost adaugat in echipa.");
            }
            else
            {
                Console.WriteLine("Angajatul este deja in echipa.");
            }
        }

        public void VizualizeazaRezervariEchipa()
        {
            Console.WriteLine("Rezervarile echipei:");
            foreach (var angajat in Echipa)
            {
                Console.WriteLine($"\nRezervarile lui {angajat.numee} {angajat.prenume}:");
                angajat.VizualizeazaRezervari();
            }
        }

        public void ModificaRezervareEchipa(Angajat angajat, Loc locActual, Loc locNou)
        {
            if (Echipa.Contains(angajat))
            {
                Console.WriteLine($"Modificare rezervare pentru {angajat.numee} {angajat.prenume}:");
                angajat.ModificaRezervare(locActual, locNou);
            }
            else
            {
                Console.WriteLine("Angajatul nu face parte din echipa.");
            }
        }

        public void StergeRezervareEchipa(Angajat angajat, Loc loc)
        {
            if (Echipa.Contains(angajat))
            {
                Console.WriteLine($"Stergere rezervare pentru {angajat.numee} {angajat.prenume}:");
                angajat.StergeRezervare(loc);
            }
            else
            {
                Console.WriteLine("Angajatul nu face parte din echipa.");
            }
        }
    }
}
