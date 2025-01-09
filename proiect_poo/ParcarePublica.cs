public class ParcarePublica : SistemRezervare
{
   // public decimal TaxaParcare { get; set; }

    public bool RezervaLocCuTaxa(int idLoc, Angajat angajat, HartaLocuri hartaLocuri)
    {
        var loc = Locuri.FirstOrDefault(l => l.Id == idLoc && l.Tip == "Parcare");
        if (loc != null && !loc.EsteRezervat) 
        {
            loc.EsteRezervat = true;
            angajat.AddRezervare(loc);
            Console.WriteLine($"Locul {loc.Nume} a fost rezervat. Taxa de parcare este {loc.Taxa} lei.");
            //actualizeaza harta locurilor
            
           // var loc = Locuri.FirstOrDefault(l => l.Id == idLoc);

           int linie = (idLoc - 1) / hartaLocuri.GetNrColoane();
           int coloana = (idLoc - 1) % hartaLocuri.GetNrColoane();
           hartaLocuri.RezervaLoc(linie, coloana);
            return true;
        }

        Console.WriteLine($"Locul {idLoc} nu este disponibil pentru rezervare.");
        return false;
    }
    
    
    // public bool RezervaLocCoworking(int idLoc, Angajat angajat, HartaLocuri hartaLocuri)
    // {
       //  if (RezervaLoc(idLoc, angajat))
       // {
         //   var loc = Locuri.FirstOrDefault(l => l.Id == idLoc); 
           // if (loc != null) 
            // {
               // int linie = (idLoc - 1) / hartaLocuri.GetNrColoane(); 
                // int coloana = (idLoc - 1) % hartaLocuri.GetNrColoane(); hartaLocuri.RezervaLoc(linie, coloana); 
           // } 
            //return true;
            
        //} return false;
   // }

    public void AfiseazaHartaLocuri(HartaLocuri hartaLocuri)
    {
        Console.WriteLine("=== Harta locurilor de parcare ===");
        hartaLocuri.AfiseazaHarta();
    }
}