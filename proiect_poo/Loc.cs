public class Loc
{
    public int Id { get; set; }
    public string Tip { get; set; }
    public string Nume { get; set; }
    public bool EsteRezervat { get; set; }
    
    public decimal? Taxa { get; set; } // taxa poate sa fie nula pt locurile de birou

    public Loc(int id, string tip, string nume, decimal? taxa = null)
    {
        Id = id;
        Tip = tip;
        Nume = nume;
        EsteRezervat = false;
        Taxa = taxa;
    }

    public bool Rezervat()
    {
        if (!EsteRezervat)
        {
            EsteRezervat = true;
            return true;
        }
        return false;
        
    }

    public void Elibereaza()
    {
        EsteRezervat = false;
    }

    public override string ToString()
    {
        return $"{Nume} ({Tip}) - {(EsteRezervat ? "Rezervat" : "Disponibil")}";
    }
}