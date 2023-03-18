using System;
using ZadankaChlopaki.Classes;

namespace ZadankaChlopaki // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
        }
        public static int PoleKwadratu(int a)
        {
            if (a != 0)
            {
                return a * a;
            }
            return -1;
        }

        public static int PoleProstokata(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return -1;
            }
            if (a < 0)
            {
                return -a * b;
            }
            if (b < 0)
            {
                return -b * a;
            }
            else
                return a *b;
        }

        public static int PoleTrojkata(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return -1;
            }
            if (a < 0)
            {
                return -a * b/2;
            }
            if (b < 0)
            {
                return -b * a/2;
            }
            else
                return a * b/2;
        }

        public static int ObwodKwadratu(int a)
        {
            if (a > 0)
            {
                return 4 * a;
            }
            if (a == 0)
            {
                return -1;
            }
            return 4 * -a;
        }

        public static int ObwodProstokata(int a, int b)
        {

            if (a == 0 || b == 0)
            {
                return -1;
            }
            if (a < 0 )
            {
                return 2 * (-a + b);
            }
            if (b < 0)
            {
                return 2 * (-b + a);
            }
            return 2 * (a + b);
        }

        public static int ObwodTrojkata(int a, int b, int c)
        {
            if (a == 0 || b == 0)
            {
                return -1;
            }
            if (a < 0)
            {
                return -a + b + c;
            }
            if (b < 0)
            {
                return a + -b + c;
            }
            if (c < 0)
            {
                return a + b + -c;
            }
            return 2 * (a + b);
        }

        public static bool TrojkatIstnieje(int a, int b, int c)
        {
            if (a + b <= c || b + c <= a || c + a <= b)
            {
                return false;
            }
            return true;
        }

        public static bool Czy_pierwszy_wiekszy_od_drugiego(int a1, int h1, int a2, int h2)
        {
            if (a1 * h1 > a2 *h2)
            {
                return true;
            }
            return false;
        }
    }
}