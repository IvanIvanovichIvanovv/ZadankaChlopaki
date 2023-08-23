namespace ZadankaChlopaki.Classes
{
    public class Kwadrat : Figura
    {
        public Kwadrat(int a) : base(a)
        {

        }

        public override int Pole()
        {
            return this.a * this.h;
        }
        public override int Obwod()
        {
            return this.a * 2 + this.h * 2;
        }
    }
}
