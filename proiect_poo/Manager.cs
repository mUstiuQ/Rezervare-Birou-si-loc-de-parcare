// Clasa Manager extinde funcționalitățile clasei Angajat.
// Managerul are o listă de angajați în echipa sa și funcționalități suplimentare
// pentru a vizualiza, modifica și șterge rezervările acestora.
public class Manager : Angajat
{
    // Proprietatea Angajati reprezintă lista de angajați din echipa managerului.
    public List<Angajat> Angajati { get; set; }

    // Constructorul inițializează un Manager cu numele său și lista de angajați din echipă.
    // Parametri:
    // - nume: Numele managerului.
    // - angajati: Lista de angajați care fac parte din echipă.
    public Manager(string nume, List<Angajat> angajati) : base(nume)
    {
        Angajati = angajati;
    }

    // Metoda VizualizeazaRezervariEchipa afișează toate rezervările angajaților din echipa managerului.
    public void VizualizeazaRezervariEchipa()
    {
        Console.WriteLine($"{Nume} - Rezervările echipei:");
        // Iterează prin fiecare angajat din echipă și afișează rezervările acestuia.
        foreach (var angajat in Angajati)
        {
            angajat.AfiseazaRezervari(); // Utilizează metoda din clasa Angajat.
        }
    }

    // Metoda ModificaRezervareEchipa permite managerului să modifice o rezervare a unui angajat.
    // Parametri:
    // - idLoc: ID-ul locului de rezervare care trebuie modificat.
    // - esteRezervat: Noua stare de rezervare (true pentru rezervat, false pentru eliberat).
    // - numeNou: Noul nume asociat locului.
    public void ModificaRezervareEchipa(int idLoc, bool esteRezervat, string numeNou)
    {
        // Caută rezervarea în lista de rezervări a fiecărui angajat.
        foreach (var angajat in Angajati)
        {
            var loc = angajat.Rezervari.FirstOrDefault(l => l.Id == idLoc);
            if (loc != null) // Dacă rezervarea este găsită:
            {
                loc.EsteRezervat = esteRezervat; // Actualizează starea rezervării.
                loc.Nume = numeNou; // Actualizează numele locului.
                Console.WriteLine($"Rezervarea pentru locul {idLoc} a fost modificată.");
                return; // Termină metoda după modificare.
            }
        }
        // Dacă rezervarea nu este găsită:
        Console.WriteLine("Rezervarea nu a fost găsită.");
    }

    // Metoda StergeRezervareEchipa permite managerului să șteargă o rezervare a unui angajat.
    // Parametri:
    // - idLoc: ID-ul locului de rezervare care trebuie șters.
    public void StergeRezervareEchipa(int idLoc)
    {
        // Caută rezervarea în lista de rezervări a fiecărui angajat.
        foreach (var angajat in Angajati)
        {
            var loc = angajat.Rezervari.FirstOrDefault(l => l.Id == idLoc);
            if (loc != null) // Dacă rezervarea este găsită:
            {
                angajat.Rezervari.Remove(loc); // Elimină locul din lista de rezervări.
                Console.WriteLine($"Rezervarea pentru locul {idLoc} a fost ștearsă.");
                return; // Termină metoda după ștergere.
            }
        }
        // Dacă rezervarea nu este găsită:
        Console.WriteLine("Rezervarea nu a fost găsită.");
    }
}
