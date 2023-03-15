using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ZadankaChlopaki.Classes
{
    public class Trojkat:Figura
    {
        private int b,c;

        public Trojkat(int a, int b) : base(a, b)
        {
        }
        public Trojkat(int a,int b ,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override int Pole()
        {
            return (this.a*this.h)/2;
        }
        public override int Obwod()
        {
            return a + b + c;
        }
    }
}
