using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadankaChlopaki.Classes
{
    public class Kwadrat:Figura
    {
        public Kwadrat(int a):base(a)
        {
            
        }

        public override int Pole() 
        {
            return this.a * this.h;
        }
        public override int Obwod()
        {
            return this.a * 2 + this.h * 2;
        }
        public int GetA() 
        {
            return this.a;
        }
        public void SetA(int x) 
        {
            if (x != 0) 
            {
                this.a = Math.Abs(x);
            }
        }
    }
}
