// Rezervare.cs - Modificat pentru integrarea cu meniul
using System;

namespace proiect_poo
{
    public class Rezervare
    {
        private int IdLoc;
        private DateTime DataRezervare;
        private string TipLoc; // Ex.: "Parcare", "Birou"
        private string Locatie;
        private bool Rezervat;

        public Rezervare(int idLoc, DateTime dataRezervare, string tipLoc, string locatie, bool rezervat)
        {
            IdLoc = idLoc;
            DataRezervare = dataRezervare;
            TipLoc = tipLoc;
            Locatie = locatie;
            Rezervat = rezervat;
        }

        public override string ToString()
        {
            return $"ID: {IdLoc}, Data: {DataRezervare.ToShortDateString()}, Tip: {TipLoc}, Locatie: {Locatie}, Rezervat: {(Rezervat ? "Da" : "Nu")}";
        }
    }
}
