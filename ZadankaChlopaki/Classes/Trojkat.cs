namespace ZadankaChlopaki.Classes
{
    public class Trojkat : Figura
    {
        public Trojkat(int a, int b) : base(a, b)
        {
        }

        public override int Pole()
        {
            return (this.a * this.h) / 2;
        }
        public override int Obwod()
        {
            return 0;
        }
    }
}
