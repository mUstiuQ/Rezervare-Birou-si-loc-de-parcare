using System;
using System.Collections.Generic;

namespace ProiectPOO
{
    public class SistemRezervare
    {
        private List<LocBirou> locuriBirou;
        private List<LocParcare> locuriParcare;

        public SistemRezervare()
        {
            locuriBirou = new List<LocBirou>();
            locuriParcare = new List<LocParcare>();

            // Inițializare locuri de birou și parcare
            for (int i = 1; i <= 10; i++)
            {
                locuriBirou.Add(new LocBirou(i, "Individual"));
                locuriParcare.Add(new LocParcare(i, "Standard"));
            }
        }

        public void AfisareStareLocuri()
        {
            Console.WriteLine("Locuri de birou:");
            foreach (var loc in locuriBirou)
            {
                Console.WriteLine($"Loc {loc.numar} - {(loc.esteRezervat ? "Rezervat" : "Liber")}");
            }

            Console.WriteLine("\nLocuri de parcare:");
            foreach (var loc in locuriParcare)
            {
                Console.WriteLine($"Loc {loc.numar} - {(loc.esteRezervat ? "Rezervat" : "Liber")}");
            }
        }

        public void RezervareLoc()
        {
            Console.WriteLine("Tip loc (1 - Birou, 2 - Parcare):");
            string? tipLoc = Console.ReadLine();

            if (string.IsNullOrEmpty(tipLoc))
            {
                Console.WriteLine("Tipul de loc nu poate fi gol.");
                return;
            }

            Console.WriteLine("Introdu numarul locului:");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int numar))
            {
                if (tipLoc == "1") // Loc de birou
                {
                    LocBirou? loc = locuriBirou.Find(l => l.numar == numar);
                    if (loc != null)
                    {
                        loc.Rezerva();
                    }
                    else
                    {
                        Console.WriteLine("Locul de birou nu exista.");
                    }
                }
                else if (tipLoc == "2") // Loc de parcare
                {
                    LocParcare? loc = locuriParcare.Find(l => l.numar == numar);
                    if (loc != null)
                    {
                        loc.Rezerva();
                    }
                    else
                    {
                        Console.WriteLine("Locul de parcare nu exista.");
                    }
                }
                else
                {
                    Console.WriteLine("Tip loc invalid.");
                }
            }
            else
            {
                Console.WriteLine("Numarul introdus este invalid.");
            }
        }


        public void AfisareHartaLocuri()
        {
            Console.WriteLine("Harta locuri de birou:");
            foreach (var loc in locuriBirou)
            {
                Console.Write(loc.esteRezervat ? "[X]" : "[ ]");
            }
            Console.WriteLine();

            Console.WriteLine("\nHarta locuri de parcare:");
            foreach (var loc in locuriParcare)
            {
                Console.Write(loc.esteRezervat ? "[X]" : "[ ]");
            }
            Console.WriteLine();
        }

        public void GeneralizareRezervari()
        {
            Console.WriteLine("Functionalitatea de rezervare pentru coworking și parcare publica urmeaza sa fie implementata.");
        }

        public void EditareLocuri()
        {
            Console.WriteLine("Functionalitatea de editare locuri este rezervata administratorilor.");
        }

        public void GestionareRezervariPersonale()
        {
            Console.WriteLine("Functionalitatea de gestionare a rezervarilor personale.");
        }

        public void GestionareRezervariEchipa()
        {
            Console.WriteLine("Functionalitatea de gestionare a rezervarilor echipei.");
        }
    }
}
