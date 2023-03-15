using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadankaChlopaki.Classes
{
    public class Prostokat:Figura
    {
        public Prostokat(int a,int b):base(a,b)
        {
            
        }
        public override int Obwod() 
        {
            return 2 * a + 2 * h;
        }
        public override int Pole()
        {
            return a * h;
        }
        public int[] GetDimensions() 
        {
            return new int[2] { this.a, this.h };
        }
        public void ChangeA(int x) 
        {
            if (x != 0) 
            {
                this.a = Math.Abs(x);
            }
        }
        public void ChangeB(int x)
        {
            if (x != 0)
            {
                this.h = Math.Abs(x);
            }
        }
        public void ChangeDimensions(int x,int y) 
        {
            this.ChangeA(x);
            this.ChangeB(y);
        }
    }
}
