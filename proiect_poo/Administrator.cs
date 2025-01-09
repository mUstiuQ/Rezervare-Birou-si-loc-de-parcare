public class Administrator
{
    public void VizualizeazaToateLocurile(SistemRezervare sistem)
    {
        Console.WriteLine("=== Vizualizare toate locurile ===");
        sistem.AfiseazaLocuri();
        Console.WriteLine("Apasa orice tasta pentru a continua...");
        Console.ReadKey();
    }

    public void EditareLoc(SistemRezervare sistem, int idLoc, string numeNou, bool esteRezervat)
    {
        var loc = sistem.Locuri.FirstOrDefault(l => l.Id == idLoc);
        if (loc != null)
        {
            loc.Nume = numeNou;
            loc.EsteRezervat = esteRezervat;
            Console.WriteLine($"Locul {idLoc} a fost modificat.");
        }
        else
        {
            Console.WriteLine("Locul nu a fost gasit.");
        }

        Console.WriteLine("Apasa orice tasta pentru a continua...");
        Console.ReadKey();
    }
    
}

