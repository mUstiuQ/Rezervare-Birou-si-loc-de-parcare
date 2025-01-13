namespace proiect_poo
{
    // Clasa Rezervare reprezintă o rezervare pentru un loc de muncă sau un loc de parcare.
    public class Rezervare
    {
        // Proprietatea IdLoc este ID-ul locului rezervat (poate fi un loc de muncă sau de parcare).
        public int IdLoc { get; set; }
        
        // Proprietatea NumeAngajat reprezintă numele angajatului care a efectuat rezervarea.
        public string NumeAngajat { get; set; }
        
        // Proprietatea DataRezervarii reprezintă data și ora la care a fost realizată rezervarea.
        public DateTime DataRezervarii { get; set; }
        
        // Proprietatea EsteLocParcare indică dacă locul rezervat este un loc de parcare.
        public bool EsteLocParcare { get; set; } 
    }
}