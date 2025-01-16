using System;
using System.Collections.Generic;

namespace ProiectPOO
{
    public class HartaLocuri
    {
        public void AfisareHarta(List<LocBirou> locuriBirou, List<LocParcare> locuriParcare)
        {
            Console.WriteLine("Harta locuri de birou:");
            AfisareMatrice(locuriBirou, "Birou");

            Console.WriteLine("\nHarta locuri de parcare:");
            AfisareMatrice(locuriParcare, "Parcare");
        }

        private void AfisareMatrice<T>(List<T> locuri, string tipLoc) where T : Loc
        {
            int nrColoane = 5; // Numarul de locuri per rand
            int contor = 0;

            foreach (var loc in locuri)
            {
                Console.Write(loc.esteRezervat ? "[X]" : "[ ]");
                contor++;

                if (contor % nrColoane == 0)
                {
                    Console.WriteLine(); // Trecem pe rândul următor
                }
            }

            if (contor % nrColoane != 0)
            {
                Console.WriteLine(); // Finalizăm rândul curent
            }
        }
    }
}
