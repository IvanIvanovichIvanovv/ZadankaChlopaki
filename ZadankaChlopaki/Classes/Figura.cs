using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadankaChlopaki;

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
            if (a != 0 && b != 0)
            {
                this.a = Math.Abs(a);
                h = Math.Abs(b);
            }else throw new ArgumentOutOfRangeException();
        }
        public Figura(int a) 
        {
            if (a != 0)
            {
                this.a = Math.Abs(a);
                h = Math.Abs(a);
            }
            else throw new ArgumentOutOfRangeException();
        }
        public Figura()
        {
            
        }
    }
}
