public class Loc
{
    public int Id { get; set; }
    public string Tip { get; set; }
    public string Nume { get; set; }
    public string Nume2 { get; set; }
    public bool EsteRezervat { get; set; }

    public Loc(int id, string tip, string nume)
    {
        Id = id;
        Tip = tip;
        Nume = nume;
        EsteRezervat = false;
    }
    

    public override string ToString()
    {
        return $"{Nume} ({Tip}) - {(EsteRezervat ? "Rezervat" : "Disponibil")}";
    }
}