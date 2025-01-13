namespace proiect_poo
{



    public class Administrator
    {
        // Metoda VizualizeazaToateLocurile permite administratorului să vizualizeze toate locurile din sistem.
        public void VizualizeazaToateLocurile(SistemRezervare sistem)
        {
            Console.WriteLine("=== Vizualizare toate locurile ===");

            // Apelăm metoda AfiseazaLocuri din clasa SistemRezervare pentru a afișa locurile disponibile.
            sistem.AfiseazaLocuri();

            // Așteptăm ca utilizatorul să apese o tastă pentru a continua.
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

                // Afișăm un mesaj de succes
                Console.WriteLine($"Locul {idLoc} a fost modificat.");
            }
            else
            {
                // Dacă locul nu este găsit, afișăm un mesaj de eroare
                Console.WriteLine("Locul nu a fost gasit.");
            }

            // Așteptăm ca utilizatorul să apese o tastă pentru a continua.
            Console.WriteLine("Apasa orice tasta pentru a continua...");
            Console.ReadKey();
        }
    }
}