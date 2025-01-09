public class SistemRezervare
{
    public List<Loc> Locuri { get; set; } = new List<Loc>();

    public void AdaugaLoc(Loc loc)
    {
        Locuri.Add(loc);
        Console.WriteLine($"Locul {loc.Nume} a fost adaugat cu succes.");
    }

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
                Console.WriteLine(loc.ToString());
            }
        }
    }


    public bool RezervaLoc(int idLoc, Angajat angajat)
    {
        var loc = Locuri.FirstOrDefault(l => l.Id == idLoc);
        if (loc != null && !loc.EsteRezervat)
        {
            loc.EsteRezervat = true;
            angajat.AddRezervare(loc);  // Adaugă locul la rezervările angajatului
            return true;
        }
        return false;
    }


    public bool ModificaLoc(int idLoc, bool esteRezervat, string numeNou)
    {
        var loc = Locuri.FirstOrDefault(l => l.Id == idLoc);
        if (loc != null)
        {
            loc.EsteRezervat = esteRezervat;
            loc.Nume = numeNou;
            return true;
        }
        return false;
    }

}