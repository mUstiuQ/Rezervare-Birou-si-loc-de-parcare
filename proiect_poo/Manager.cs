// Clasa Manager mosteneste funcționalitățile clasei Angajat.
public class Manager : Angajat
{
    public List<Angajat> Angajati { get; set; }
    
    public Manager(string nume, List<Angajat> angajati) : base(nume)
    {
        Angajati = angajati;
    }

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
        Console.WriteLine("Rezervarea nu a fost găsită.");
    }

    // Metoda StergeRezervareEchipa permite managerului să șteargă o rezervare a unui angajat.
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
        Console.WriteLine("Rezervarea nu a fost găsită.");
    }
}
