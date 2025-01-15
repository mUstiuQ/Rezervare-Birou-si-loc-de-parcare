namespace proiect_poo
{


    public class ParcarePublica : SistemRezervare
    {
        public bool RezervaLocCuTaxa(int idLoc, Angajat angajat, HartaLocuri hartaLocuri)
        {
            // Căutăm locul de parcare cu ID-ul specificat și care nu este deja rezervat.
            var loc = Locuri.FirstOrDefault(l => l.Id == idLoc && l.Tip == "Parcare");

            // Dacă locul este disponibil pentru rezervare
            if (loc != null && !loc.EsteRezervat)
            {
                // Se marchează locul ca rezervat
                loc.EsteRezervat = true;

                angajat.AddRezervare(loc);

                Console.WriteLine($"Locul {loc.Nume} a fost rezervat. Taxa de parcare este {loc.Taxa} lei.");

                // Actualizează harta locurilor pentru a reflecta rezervarea
                // Calculăm linia și coloana pe baza ID-urilor în harta locațiilor pentru a marca locul ca rezervat
                int linie = (idLoc - 1) / hartaLocuri.GetNrColoane(); 
                int coloana = (idLoc - 1) % hartaLocuri.GetNrColoane(); 
                hartaLocuri.RezervaLoc(linie, coloana);
                return true;
            }

            Console.WriteLine($"Locul {idLoc} nu este disponibil pentru rezervare.");
            return false;
        }
        
        // Metoda AfiseazaHartaLocuri afișează harta locurilor de parcare.
        public void AfiseazaHartaLocuri(HartaLocuri hartaLocuri)
        {
            // Afișăm un mesaj introductiv pentru harta locurilor de parcare si efectiv locurile disponibile
            Console.WriteLine("=== Harta locurilor de parcare ===");
            hartaLocuri.AfiseazaHarta();
        }
    }
}