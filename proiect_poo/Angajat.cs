public class Angajat
{
    // Proprietatea Nume ține evidența numelui angajatului.
    public string Nume { get; set; }

    // Lista Rezervari va conține toate locurile rezervate de angajat.
    public List<Loc> Rezervari { get; set; } = new List<Loc>();

    // Constructorul clasei Angajat, care inițializează numele angajatului.
    public Angajat(string nume)
    {
        Nume = nume;
    }

    // Metoda AddRezervare adaugă un loc în lista de rezervări ale angajatului.
    public void AddRezervare(Loc loc)
    {
        Rezervari.Add(loc);  // Adăugăm locul în lista de rezervări
    }

    // Metoda AfiseazaRezervari afișează toate rezervările efectuate de angajat.
    public void AfiseazaRezervari()
    {
        // Afișăm un mesaj care indică numele angajatului și o listă a rezervărilor sale
        Console.WriteLine($"{Nume} - Rezervările tale:");
        
        // Dacă angajatul nu are nicio rezervare, afișăm un mesaj corespunzător
        if (Rezervari.Count == 0)
        {
            Console.WriteLine("Nu ai nicio rezervare.");
        }
        else
        {
            // Dacă angajatul are rezervări, le afișăm pe toate
            foreach (var rezervare in Rezervari)
            {
                Console.WriteLine(rezervare);  // Afișăm fiecare rezervare (folosind metoda ToString a clasei Loc)
            }
        }
    }
}