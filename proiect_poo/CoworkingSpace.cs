public class CoworkingSpace : SistemRezervare
{
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