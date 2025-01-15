// Clasa CoworkingSpace extinde funcționalitățile clasei SistemRezervare, adăugând metode
// specifice pentru rezervarea locurilor de coworking și afișarea hărții locurilor.

namespace proiect_poo
{


    public class CoworkingSpace : SistemRezervare
    {
        
        public bool RezervaLocCoworking(int idLoc, Angajat angajat, HartaLocuri hartaLocuri)
        {
            // Caută un loc disponibil de tip "Birou" pe baza ID-ului.
            var loc = Locuri.FirstOrDefault(l => l.Id == idLoc && l.Tip == "Birou");
            if (loc != null && !loc.EsteRezervat) // Verifică dacă locul este disponibil.
            {
                loc.EsteRezervat = true; // Marchează locul ca rezervat.
                angajat.AddRezervare(loc); // Adaugă locul în lista de rezervări a angajatului.

                // Actualizează harta locurilor pentru a reflecta rezervarea.
                int linie = (idLoc - 1) / hartaLocuri.GetNrColoane(); // Determină linia pe hartă.
                int coloana = (idLoc - 1) % hartaLocuri.GetNrColoane(); // Determină coloana pe hartă.
                hartaLocuri.RezervaLoc(linie, coloana); // Rezervă locul pe hartă.
                return true; 
            }

            Console.WriteLine($"Locul {idLoc} nu este disponibil pentru rezervare.");
            return false; 
        }

        // Metoda afișează harta locurilor de coworking utilizând funcționalitatea oferită de HartaLocuri.
        // Parametru: hartaLocuri - Obiect care gestionează și afișează starea locurilor.
        public void AfiseazaHartaLocuri(HartaLocuri hartaLocuri)
        {
            Console.WriteLine("=== Harta locurilor de coworking ===");
            hartaLocuri.AfiseazaHarta(); 
        }

        // Suprascrie metoda de rezervare pentru a utiliza logica de bază din SistemRezervare.
        public bool RezervaLocCoworking(int idLoc, Angajat angajat)
        {
            return RezervaLoc(idLoc, angajat); // Apelează metoda RezervaLoc din clasa de bază.
        }
    }
}