// Clasa CoworkingSpace extinde funcționalitățile clasei SistemRezervare, adăugând metode
// specifice pentru rezervarea locurilor de coworking și afișarea hărții locurilor.

namespace proiect_poo
{


    public class CoworkingSpace : SistemRezervare
    {
        // Metoda permite rezervarea unui loc de coworking de tip "Birou" pentru un angajat.
        // Parametri:
        // - idLoc: ID-ul locului ce urmează să fie rezervat.
        // - angajat: Angajatul care face rezervarea.
        // - hartaLocuri: Obiect care reprezintă harta locurilor și starea lor.
        // Returnează: true dacă rezervarea a fost realizată cu succes, altfel false.
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
                return true; // Rezervarea a avut succes.
            }

            // Afișează un mesaj dacă locul nu este disponibil pentru rezervare.
            Console.WriteLine($"Locul {idLoc} nu este disponibil pentru rezervare.");
            return false; // Rezervarea a eșuat.
        }

        // Metoda afișează harta locurilor de coworking utilizând funcționalitatea oferită de HartaLocuri.
        // Parametru: hartaLocuri - Obiect care gestionează și afișează starea locurilor.
        public void AfiseazaHartaLocuri(HartaLocuri hartaLocuri)
        {
            Console.WriteLine("=== Harta locurilor de coworking ===");
            hartaLocuri.AfiseazaHarta(); // Afișează harta locurilor.
        }

        // Suprascrie metoda de rezervare pentru a utiliza logica de bază din SistemRezervare.
        // Parametri:
        // - idLoc: ID-ul locului de rezervat.
        // - angajat: Angajatul care face rezervarea.
        // Returnează: true dacă rezervarea a fost realizată cu succes, altfel false.
        public bool RezervaLocCoworking(int idLoc, Angajat angajat)
        {
            return RezervaLoc(idLoc, angajat); // Apelează metoda RezervaLoc din clasa de bază.
        }
    }
}