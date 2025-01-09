public class Angajat
{
    public string Nume { get; set; }
    public List<Loc> Rezervari { get; set; } = new List<Loc>();

    public Angajat(string nume)
    {
        Nume = nume;
    }

    public void AddRezervare(Loc loc)
    {
        Rezervari.Add(loc);
    }

    public void AfiseazaRezervari()
    {
        Console.WriteLine($"{Nume} - Rezervările tale:");
        if (Rezervari.Count == 0)
        {
            Console.WriteLine("Nu ai nicio rezervare.");
        }
        else
        {
            foreach (var rezervare in Rezervari)
            {
                Console.WriteLine(rezervare);
            }
        }
    }
}