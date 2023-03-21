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
        protected int b;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else if (value < 0)
                {
                    a = value * -1;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else if (value < 0)
                {
                    b = value * -1;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public abstract int Pole();
        public abstract int Obwod();

        public Figura(int a, int b )
        {
            this.A = a;
            this.B = b;
        }
        public Figura(int a) 
        {
            this.A = a;
        }
    }
}
