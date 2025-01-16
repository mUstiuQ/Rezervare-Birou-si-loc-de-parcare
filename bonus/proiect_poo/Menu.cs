using System;

namespace ProiectPOO
{
    public class Menu
    {
        public void VizualizareLocuri(SistemRezervare sistem)
        {
            Console.Clear();
            Console.WriteLine("Starea locurilor:");
            sistem.AfisareStareLocuri();
            Console.WriteLine("\nApasa orice tasta pentru a te intoarce la meniu.");
            Console.ReadKey();
        }

        public void RezervareLoc(SistemRezervare sistem)
        {
            Console.Clear();
            Console.WriteLine("Rezervare loc:");
            sistem.RezervareLoc();
            Console.WriteLine("\nApasa orice tasta pentru a te intoarce la meniu.");
            Console.ReadKey();
        }

        public void GestionareRezervariPersonale(SistemRezervare sistem)
        {
            Console.Clear();
            Console.WriteLine("Gestionare rezervari personale:");
            sistem.GestionareRezervariPersonale();
            Console.WriteLine("\nApasa orice tasta pentru a te antoarce la meniu.");
            Console.ReadKey();
        }

        public void GestionareRezervariEchipa(SistemRezervare sistem)
        {
            Console.Clear();
            Console.WriteLine("Gestionare rezervari echipa (doar pentru manageri):");
            sistem.GestionareRezervariEchipa();
            Console.WriteLine("\nApasa orice tasta pentru a te intoarce la meniu.");
            Console.ReadKey();
        }

        public void EditareLocuri(SistemRezervare sistem)
        {
            Console.Clear();
            Console.WriteLine("Editare locuri (doar pentru administratori):");
            sistem.EditareLocuri();
            Console.WriteLine("\nApasa orice tasta pentru a te intoarce la meniu.");
            Console.ReadKey();
        }

        public void AfisareHartaLocuri(SistemRezervare sistem)
        {
            Console.Clear();
            Console.WriteLine("Harta locuri:");
            sistem.AfisareHartaLocuri();
            Console.WriteLine("\nApasa orice tasta pentru a te intoarce la meniu.");
            Console.ReadKey();
        }

        public void GeneralizareRezervari(SistemRezervare sistem)
        {
            Console.Clear();
            Console.WriteLine("Rezervari pentru coworking sau parcare publica:");
            sistem.GeneralizareRezervari();
            Console.WriteLine("\nApasa orice tasta pentru a te intoarce la meniu.");
            Console.ReadKey();
        }
    }
}
