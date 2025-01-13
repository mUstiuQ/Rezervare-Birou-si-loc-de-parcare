// Clasa Loc reprezintă un loc într-un spațiu de coworking.
// Fiecare loc are un ID unic, un tip (de exemplu, birou, sală de conferințe),
// un nume, un statut de rezervare și, opțional, o taxă asociată.
public class Loc
{
    // Proprietatea Id reprezintă identificatorul unic al locului.
    public int Id { get; set; }

    // Proprietatea Tip specifică tipul locului (ex. "Birou", "Sala conferinte").
    public string Tip { get; set; }

    // Proprietatea Nume reprezintă numele locului.
    public string Nume { get; set; }

    // Proprietatea EsteRezervat indică dacă locul este rezervat (true) sau nu (false).
    public bool EsteRezervat { get; set; }

    // Proprietatea Taxa reprezintă costul rezervării locului.
    // Este opțională și poate fi null pentru locurile de tip birou.
    public decimal? Taxa { get; set; }

    // Constructorul inițializează un loc cu valorile specificate.
    // Parametri:
    // - id: ID-ul unic al locului.
    // - tip: Tipul locului.
    // - nume: Numele locului.
    // - taxa: (opțional) Taxa asociată locului (implicit null).
    public Loc(int id, string tip, string nume, decimal? taxa = null)
    {
        Id = id;
        Tip = tip;
        Nume = nume;
        EsteRezervat = false; // Inițial, locul este liber.
        Taxa = taxa;
    }

    // Metoda Rezervat marchează locul ca rezervat dacă acesta este disponibil.
    // Returnează true dacă locul a fost rezervat cu succes, altfel false.
    public bool Rezervat()
    {
        if (!EsteRezervat) // Verifică dacă locul nu este deja rezervat.
        {
            EsteRezervat = true; // Marchează locul ca rezervat.
            return true; // Rezervarea a avut succes.
        }
        return false; // Locul era deja rezervat.
    }

    // Metoda Elibereaza marchează locul ca fiind disponibil (ne-rezervat).
    public void Elibereaza()
    {
        EsteRezervat = false; // Locul este eliberat.
    }

    // Suprascrie metoda ToString pentru a returna o reprezentare clară a locului.
    // Exemplu: "Loc1 (Birou) - Disponibil" sau "Loc2 (Sala conferinte) - Rezervat".
    public override string ToString()
    {
        return $"{Nume} ({Tip}) - {(EsteRezervat ? "Rezervat" : "Disponibil")}";
    }
}
