using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadankaChlopaki.Classes
{
    public class Kot : Zwierze
    {
        public string rasa;
        public override void CzymJestZwierzak()
        {
            Console.WriteLine("{0} jest kotem.", this.imie);
        }
        public override void WydajDzwiek()
        {
            base.WydajDzwiek();
            Console.WriteLine("Miau");
        }
        public Kot(int wiek, string imie) : base(wiek, imie)
        {

        }
        public Kot(int wiek, string imie, string rasa) : base(wiek, imie)
        {
            this.rasa = rasa;
        }
        public Kot() : base() { }

        public override string ToString()
        {
            return base.ToString() + " i jest kotem";
        }
    }
}
