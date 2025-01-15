// Clasa Loc reprezintă un loc într-un spațiu de coworking.
// Fiecare loc are un ID unic, un tip (de exemplu, birou, sală de conferințe),
// un nume, un statut de rezervare și, opțional, o taxă asociată.
public class Loc
{
    public int Id { get; set; }
    public string Tip { get; set; }
    public string Nume { get; set; }
    public bool EsteRezervat { get; set; }

    // Proprietatea Taxa reprezintă costul rezervării locului.
    // Este opțională și poate fi null pentru locurile de tip birou.
    public decimal? Taxa { get; set; }
    
    public Loc(int id, string tip, string nume, decimal? taxa = null)
    {
        Id = id;
        Tip = tip;
        Nume = nume;
        EsteRezervat = false;
        Taxa = taxa;
    }

    // Metoda Rezervat marchează locul ca rezervat dacă acesta este disponibil.
    // Returnează true dacă locul a fost rezervat cu succes, altfel false.
    public bool Rezervat()
    {
        if (!EsteRezervat) // Verifică dacă locul nu este deja rezervat.
        {
            EsteRezervat = true; 
            return true; 
        }
        return false; 
    }

    // Metoda Elibereaza marchează locul ca fiind disponibil.
    public void Elibereaza()
    {
        EsteRezervat = false; // 
    }

    // Suprascrie metoda ToString pentru a returna o reprezentare clară a locului.
    public override string ToString()
    {
        return $"{Nume} ({Tip}) - {(EsteRezervat ? "Rezervat" : "Disponibil")}";
    }
}
