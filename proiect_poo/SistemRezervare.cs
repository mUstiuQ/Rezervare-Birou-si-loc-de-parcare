﻿namespace proiect_poo
{


    public class SistemRezervare
    {
        public List<Loc> Locuri { get; set; } = new List<Loc>();

        // Metoda AdaugaLoc adaugă un loc nou în lista de locuri disponibile.
        public void AdaugaLoc(Loc loc)
        {
            Locuri.Add(loc); // Adăugăm locul în lista Locuri
            Console.WriteLine($"Locul {loc.Nume} a fost adaugat cu succes.");
        }

        // Metoda AfiseazaLocuri afișează toate locurile disponibile. 
        public void AfiseazaLocuri()
        {
            if (Locuri.Count == 0)
            {
                Console.WriteLine("Nu exista locuri disponibile.");
            }
            else
            {
                Console.WriteLine("Locuri disponibile:");
                foreach (var loc in Locuri)
                {
                    Console.WriteLine(loc.ToString()); // Afișăm detaliile fiecărui loc
                }
            }
        }

        // Metoda RezervaLoc rezervă un loc pentru un angajat, în funcție de ID-ul locului.
        public bool RezervaLoc(int idLoc, Angajat angajat)
        {
            // Căutăm locul după ID
            var loc = Locuri.FirstOrDefault(l => l.Id == idLoc);

            // Verificăm dacă locul există și nu este deja rezervat
            if (loc != null && !loc.EsteRezervat)
            {
                // Dacă locul este disponibil, îl rezervăm și îl adăugăm în lista de rezervări a angajatului
                loc.EsteRezervat = true;
                angajat.AddRezervare(loc); 
                return true; 
            }

            return false; 
        }

        // Metoda ModificaLoc permite modificarea unui loc, cum ar fi schimbarea statutului de rezervare și actualizarea numelui.
        public bool ModificaLoc(int idLoc, bool esteRezervat, string numeNou)
        {
            // Căutăm locul după ID
            var loc = Locuri.FirstOrDefault(l => l.Id == idLoc);

            // Dacă locul există, actualizăm informațiile
            if (loc != null)
            {
                loc.EsteRezervat = esteRezervat; // Modificăm statutul de rezervare
                loc.Nume = numeNou; // Schimbăm numele locului
                return true; // Modificările au fost aplicate cu succes
            }

            return false; // Locul nu a fost găsit pentru a aplica modificările
        }
    }
}