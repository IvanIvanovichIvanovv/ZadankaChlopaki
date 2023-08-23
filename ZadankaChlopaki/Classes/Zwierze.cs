namespace ZadankaChlopaki.Classes
{
    public abstract class Zwierze : IComparable
    {
        private int iloscLap = 4;
        private int wiek;
        public string imie;

        public int IloscLap { get { return iloscLap; } set { if (value >= 0 && value <= 4) { iloscLap = value; } } }
        public int Wiek { get { return wiek; } set { if (value > 0) { wiek = value; } } }

        public Zwierze()
        {
            wiek = 1;
            imie = "Pimpek";
        }
        public Zwierze(int wiek, string imie)
        {
            this.Wiek = wiek;
            this.imie = imie;
        }
        public virtual void WydajDzwiek()
        {
            Console.Write("{0} wydaje dzwiek:", imie);
        }
        public abstract void CzymJestZwierzak();

        public int CompareTo(object obj)
        {
            Zwierze zwierzak = obj as Zwierze;
            if (this.wiek != zwierzak.wiek)
            {
                return this.wiek - zwierzak.wiek;
            }
            else
            {
                return this.imie.Length - zwierzak.imie.Length;
            }
        }
        public override string ToString()
        {
            string result = $"{this.imie} ma {this.wiek} lat";
            return result;
        }

    }
}
