using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadankaChlopaki.Classes
{
    public abstract class Figura //klasa bazowa
    {
        protected int a;
        protected int h;

        public abstract int Pole();
        public abstract int Obwod();
        public Figura(int a, int b )
        {
            this.a = a;
            h = b;
        }
        public Figura(int a) 
        {
            this.a = a;
            h = a;
        }
    }
}
