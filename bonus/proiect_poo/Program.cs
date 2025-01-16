using System;

namespace ProiectPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            SistemRezervare sistemRezervare = new SistemRezervare();

            bool ruleaza = true;
            while (ruleaza)
            {
                Console.Clear();
                Console.WriteLine("Meniu Principal");
                Console.WriteLine("1. Vizualizare starea locurilor (birou/parcare)");
                Console.WriteLine("2. Rezervare loc birou/parcare");
                Console.WriteLine("3. Gestionare rezervari personale");
                Console.WriteLine("4. Gestionare rezervari echipă (doar pentru manageri)");
                Console.WriteLine("5. Editare locuri (doar pentru administratori)");
                Console.WriteLine("6. Afisare harta locuri");
                Console.WriteLine("7. Generalizare rezervari coworking/parcare publica");
                Console.WriteLine("0. Iesire");

                Console.Write("\nAlege o optiune: ");
                string optiune = Console.ReadLine() ?? string.Empty; // Protecție împotriva `null`

                switch (optiune)
                {
                    case "1":
                        menu.VizualizareLocuri(sistemRezervare);
                        break;
                    case "2":
                        menu.RezervareLoc(sistemRezervare);
                        break;
                    case "3":
                        menu.GestionareRezervariPersonale(sistemRezervare);
                        break;
                    case "4":
                        menu.GestionareRezervariEchipa(sistemRezervare);
                        break;
                    case "5":
                        menu.EditareLocuri(sistemRezervare);
                        break;
                    case "6":
                        menu.AfisareHartaLocuri(sistemRezervare);
                        break;
                    case "7":
                        menu.GeneralizareRezervari(sistemRezervare);
                        break;
                    case "0":
                        ruleaza = false;
                        break;
                    default:
                        Console.WriteLine("Optiune invalida. Apasa orice tasta pentru a incerca din nou.");
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("La revedere!");
        }
    }
}
