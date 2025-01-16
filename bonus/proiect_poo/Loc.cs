namespace ProiectPOO
{
    public class Loc
    {
        private int Numar;

        public int numar
        {
            get { return Numar; }
            set { Numar = value; }
        }
        private bool EsteRezervat;

        public bool esteRezervat
        {
            get { return EsteRezervat; }
            set { EsteRezervat = value; }
        }

        public Loc(int numar)
        {
            Numar = numar;
            EsteRezervat = false;
        }

        public virtual void Rezerva()
        {
            if (!EsteRezervat)
            {
                EsteRezervat = true;
                Console.WriteLine($"Locul {Numar} a fost rezervat.");
            }
            else
            {
                Console.WriteLine($"Locul {Numar} este deja rezervat.");
            }
        }

        public virtual void Elibereaza()
        {
            if (EsteRezervat)
            {
                EsteRezervat = false;
                Console.WriteLine($"Locul {Numar} a fost eliberat.");
            }
            else
            {
                Console.WriteLine($"Locul {Numar} nu este rezervat.");
            }
        }
    }

    public class LocBirou : Loc
    {
        private string TipBirou; // ex: Individual, Sala conferințe etc.

        public string tipBirou
        {
            get { return TipBirou; }
            set { TipBirou = value; }
        }
        public LocBirou(int numar, string tipBirou) : base(numar)
        {
            TipBirou = tipBirou;
        }

        public override void Rezerva()
        {
            base.Rezerva();
            Console.WriteLine($"Rezervare efectuata pentru un birou de tip {TipBirou}.");
        }
    }

    public class LocParcare : Loc
    {
        private string TipParcare; // ex: Standard, Electric, Premium etc.

        public string tipParcare
        {
            get { return TipParcare; }
            set { TipParcare = value; }
        }
        public LocParcare(int numar, string tipParcare) : base(numar)
        {
            TipParcare = tipParcare;
        }

        public override void Rezerva()
        {
            base.Rezerva();
            Console.WriteLine($"Rezervare efectuata pentru o parcare de tip {TipParcare}.");
        }
    }
}
