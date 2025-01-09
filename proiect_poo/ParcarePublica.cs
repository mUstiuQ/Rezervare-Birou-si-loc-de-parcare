public class ParcarePublica : SistemRezervare
{
    public decimal TaxaParcare { get; set; }

    public bool RezervaLocCuTaxa(int idLoc, Angajat angajat)
    {
        if (RezervaLoc(idLoc, angajat))
        {
            Console.WriteLine($"Locul a fost rezervat. Taxa de parcare este {TaxaParcare} lei.");
            return true;
        }
        return false;
    }

    public void AfiseazaHartaLocuri(HartaLocuri hartaLocuri)
    {
        Console.WriteLine("=== Harta locurilor de parcare ===");
        hartaLocuri.AfiseazaHarta();
    }
}