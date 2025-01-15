namespace proiect_poo
{
    // Clasa Rezervare reprezintă o rezervare pentru un loc de muncă sau un loc de parcare.
    public class Rezervare
    {
        public int IdLoc { get; set; }
        
        public string NumeAngajat { get; set; }
        
        public DateTime DataRezervarii { get; set; }
        
        public bool EsteLocParcare { get; set; } 
    }
}