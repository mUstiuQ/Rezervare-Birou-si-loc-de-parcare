public class Manager : Angajat
{
    public List<Angajat> Angajati { get; set; }

    public Manager(string nume, List<Angajat> angajati) : base(nume)
    {
        Angajati = angajati;
    }

    public void VizualizeazaRezervariEchipa()
    {
        Console.WriteLine($"{Nume} - Rezervarile echipei:");
        foreach (var angajat in Angajati)
        {
            angajat.AfiseazaRezervari();
        }
    }

    public void ModificaRezervareEchipa(int idLoc, bool esteRezervat, string numeNou)
    {
        foreach (var angajat in Angajati)
        {
            var loc = angajat.Rezervari.FirstOrDefault(l => l.Id == idLoc); 
            if (loc != null) 
            { 
                loc.EsteRezervat = esteRezervat; loc.Nume = numeNou; 
                Console.WriteLine($"Rezervarea pentru locul {idLoc} a fost modificată."); 
                return; 
            }
        } 
        Console.WriteLine("Rezervarea nu a fost găsită.");
    } 
        
    public void StergeRezervareEchipa(int idLoc)
    {
        foreach (var angajat in Angajati)
        {
            var loc = angajat.Rezervari.FirstOrDefault(l => l.Id == idLoc); 
            if (loc != null) 
            { 
                angajat.Rezervari.Remove(loc); 
                Console.WriteLine($"Rezervarea pentru locul {idLoc} a fost ștearsă."); 
                return; 
            }
        }
        Console.WriteLine("Rezervarea nu a fost găsită.");
    }
}