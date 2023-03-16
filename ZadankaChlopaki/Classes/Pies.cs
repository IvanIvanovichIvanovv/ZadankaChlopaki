using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadankaChlopaki.Classes
{
    public class Pies:Zwierze
    {
        public override void CzymJestZwierzak()
        {
            Console.WriteLine("{0} jest psem.", this.imie);
        }
        public override void WydajDzwiek()
        {
            base.WydajDzwiek();
            Console.WriteLine("Hau");
        }
        public Pies(int wiek,string imie):base(wiek,imie)
        {
            
        }
        public Pies() : base() { }

        public override string ToString()
        {
            return $"{this.imie} umie szczekac";
        }
    }
}
