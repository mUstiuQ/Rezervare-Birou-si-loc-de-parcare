namespace proiect_poo
{    public class Administrator
    {
        // Metoda VizualizeazaToateLocurile permite administratorului să vizualizeze toate locurile din sistem.
        public void VizualizeazaToateLocurile(SistemRezervare sistem)
        {
            Console.WriteLine("=== Vizualizare toate locurile ===");

            sistem.AfiseazaLocuri();

            Console.WriteLine("Apasa orice tasta pentru a continua...");
            Console.ReadKey();
        }

        // Metoda EditareLoc permite administratorului să modifice informațiile unui loc din sistem.
        public void EditareLoc(SistemRezervare sistem, int idLoc, string numeNou, bool esteRezervat)
        {
            // Căutăm locul după ID în lista Locuri a sistemului
            var loc = sistem.Locuri.FirstOrDefault(l => l.Id == idLoc);

            // Verificăm dacă locul a fost găsit
            if (loc != null)
            {
                // Modificăm numele și statutul de rezervare al locului
                loc.Nume = numeNou;
                loc.EsteRezervat = esteRezervat;

                Console.WriteLine($"Locul {idLoc} a fost modificat.");
            }
            else
            {
                Console.WriteLine("Locul nu a fost gasit.");
            }

            Console.WriteLine("Apasa orice tasta pentru a continua...");
            Console.ReadKey();
        }
    }
}