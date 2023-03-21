using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadankaChlopaki.Classes
{
    public class Prostokat:Figura
    {
        public Prostokat(int a, int b) : base(a, b)
        {

        }

        public override int Pole() 
        {
            return this.a * this.b;
        }
        public override int Obwod()
        {
            return this.a * 2 + this.b * 2;
        }

        public int[] GetDimensions()
        {
            int[] dimensions = new int[2] {a, b };
            return dimensions;
        }

        public int[] ChangeDimensions(int a, int b)
        {
            this.A = a;
            this.B = b;
            int[] dimensions = new int[2] {this.a, this.b };
            return dimensions;
        }
    }
}
