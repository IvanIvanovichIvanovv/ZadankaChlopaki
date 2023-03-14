using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadankaChlopaki.Classes
{
    public abstract class Figura
    {
        protected int a;
        protected int h;

        public abstract int Pole();
        public abstract int Obwod();
        public Figura(int a, int b )
        {
            this.a = a;
            this.h = b;
        }
    }
}
