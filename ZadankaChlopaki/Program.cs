using System.Security.Cryptography.X509Certificates;
using ZadankaChlopaki.Classes;

namespace ZadankaChlopaki // Note: actual namespace depends on the project name.
{
    public class Program
    {
        /*/ @@@@@@@@@@@@@@@@@@ RÓŻNE @@@@@@@@@@@@@@@@@@ */
        public static void Main(string[] args)
        {
            Trojkat trojkat = new Trojkat(5, 4);
            Console.WriteLine(trojkat.Pole());
            Console.ReadLine();
            ///
        }

        public static int[] Zamiana(int a, int b)
        {
            a = a - b;
            b = a + b;
            a = b - a;

            return new int[] { a, b };

        }/*
        public static List<int> List_Sort(List<int> list)


        {
            List = list;
            list.Sort();


            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            return new List<int> { };
        }
        */
        /*/ @@@@@@@@@@@@@@@@@@ KWADRAT FUNKCJE @@@@@@@@@@@@@@@@@@ */

        public static int PoleKwadratu(int k)
        {
          if (k == 0) 
            {
                return -1;
            }

            return k * k;
        }
        public static int ObwodKwadratu(int a) 

        {
            if (a < 0)
            {
                a *= -1;
            }
            if (a == 0) 
            {
                return -1;
            }


            return a * 4;
        }
        /*/ @@@@@@@@@@@@@@@@@@ PROSTOKAT FUNKCJE @@@@@@@@@@@@@@@@@@ */

        public static int PoleProstokata(int a, int b)
        {
            if (a < 0)
            {
                a *= -1;
            }
            if (b < 0)
            {
                b *= -1;
            }
            if (a == 0)
            {
                return -1;
            }
            if (b == 0)
            {
                return -1;
            }

            return a * b;
        }
        public static int ObwodProstokata(int a, int b)
        {
            if (a <= 0) 
            {
                a *= -1;
            }
            if (b <= 0) 
            {
                b *= -1;
            }
            if (a == 0)
            {
                return -1;
            }
            if (b == 0)
            {
                return -1;
            }

            return a * 2 + 2 * b ;
        }
        /*/ @@@@@@@@@@@@@@@@@@ TROJKAT FUNKCJE @@@@@@@@@@@@@@@@@@ */

        public static int PoleTrojkata(int a, int b) 
        {
            return (a * b) / 2;
        }
        public static int ObwodTrojkata(int a, int b, int c)
        {
            return a + b + c;
        }
        public static bool TrojkatIstnieje(int a, int b, int c)
        {
            
            if (a + b > c && a + c > b && c + b > a)
            {
                return true;
            }
            return false;


        }


    }
}
