using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadankaChlopaki.Classes
{
    public class Samochod
    {
        private int iloscKol, iloscKoni;
        private string kolor;
        private int mnoznik = 3;

        private string[] kolory = new string[4] { "czerowny", "zielony", "czarny", "niebieski" };

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
                }
                else throw new ArgumentOutOfRangeException();
            }
        }

        public int IloscKoni
        {
            get
            {
                return iloscKoni;
            }
            set
            {
                if (value > 0)
                {
                    iloscKoni = value;
                }
                else throw new ArgumentOutOfRangeException();
            }
        }

        public string Kolor
        {
            get
            {
                return kolor;
            }
            set
            {
                if (kolory.Contains(value))
                {
                    kolor = value;
                }
                else kolor = "czarny";
            }
        }

        public Samochod()
        {
            iloscKol = 4;
            iloscKoni = 120;
            kolor = "czarny";
        }

        public Samochod(int iloscKol, int iloscKoni, string kolor)
        {
            this.IloscKol = iloscKol;
            this.IloscKoni = iloscKoni;
            this.Kolor = kolor;
        }

        public int ilosckilowatow(int a)
        {
            return a * mnoznik;
        }

        public int ilosckilowatow()
        {
            return iloscKoni * mnoznik;
        }

    }
}
