public class CoworkingSpace : SistemRezervare
{
    public bool RezervaLocCoworking(int idLoc, Angajat angajat, HartaLocuri hartaLocuri)
    {
        var loc = Locuri.FirstOrDefault(l=>l.Id == idLoc && l.Tip == "Birou");
        if (loc != null && !loc.EsteRezervat)
        {
            loc.EsteRezervat = true;
            angajat.AddRezervare(loc);
            
            // actualizeaza harta locurilor
            int linie = (idLoc - 1) / hartaLocuri.GetNrColoane();
            int coloana = (idLoc - 1) % hartaLocuri.GetNrColoane();
            hartaLocuri.RezervaLoc(linie, coloana);
            return true;
        }

        Console.WriteLine($"Locul {idLoc} nu este disponibil pentru rezervare.");
        return false;
    }
    
    
    public void AfiseazaHartaLocuri(HartaLocuri hartaLocuri)
    {
        Console.WriteLine("=== Harta locurilor de coworking ===");
        hartaLocuri.AfiseazaHarta();
    }

    public bool RezervaLocCoworking(int idLoc, Angajat angajat)
    {
        return RezervaLoc(idLoc, angajat);
    }
}