using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadankaChlopaki.Classes
{
    public class Trojkat:Figura
    {
        protected int c;
        protected int h;

        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else if (value < 0)
                {
                    c = value * -1;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int H
        {
            get
            {
                return h;
            }
            set
            {
                if (value > 0)
                {
                    h = value;
                }
                else if (value < 0)
                {
                    h = value * -1;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Trojkat(int a, int b, int c, int h) : base(a, b)
        {
            this.C = c; 
            this.H = h;
        }

        public Trojkat(int a, int h) : base(a)
        {
            this.H = h;
        }

        public Trojkat(int a, int b, int c) : base(a, b)
        {
            this.C = c;
        }

        public override int Pole()
        {
            return this.a * this.h / 2;
        }
        public override int Obwod()
        {
            return this.a + this.b + this.c;
        }

        public int[] GetDimensions()
        {
            int[] dimensions = new int[4] { a, b, c, h };
            return dimensions;
        }
    }
}
