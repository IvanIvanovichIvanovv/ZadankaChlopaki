using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadankaChlopaki.Classes
{
    public class Samochod
    {
        private int iloscKol,iloscDrzwi;
        public string Marka;

        public int IloscKol 
        { 
            get 
            { 
                return iloscKol;
            }
            set 
            {
                if (value > 0) 
                {
                    iloscKol = value;
                }else throw new ArgumentOutOfRangeException();
            }
        }
        public int IloscDrzwi
        {
            get
            {
                return iloscDrzwi;
            }
            set
            {
                if (value != 0)
                {
                    iloscDrzwi = Math.Abs(value);
                }
                else throw new ArgumentOutOfRangeException();
            }
        }

        public void Brum() 
        {
            Console.WriteLine("{0} robi brum brum",this.Marka);
        }

        public void Brum(int count) 
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0} robi brum", this.Marka);
            }
        }

        public Samochod(string Marka,int iloscKol,int iloscDrzwi)
        {
            this.Marka = Marka;
            this.IloscKol= iloscKol;
            this.IloscDrzwi= iloscDrzwi;
        }
        public Samochod(int iloscKol, int iloscDrzwi)
        {
            this.Marka = "Audi";
            this.IloscKol = iloscKol;
            this.IloscDrzwi = iloscDrzwi;
        }
        public Samochod() 
        {
            this.Marka = "Fiat";
            this.iloscDrzwi = 4;
            this.iloscKol = 4;
        }
    }
}
