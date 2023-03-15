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
    }
}
