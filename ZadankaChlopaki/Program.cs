using System;

namespace ZadankaChlopaki // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.ReadLine();
        }
        public static int modul(int a)
        {
            if (a < 0)
            {
                return a * -1;
            }
            return a;
        }

        public static int PoleKwadratu(int a)
        {
            if (a == 0)
            {
                return -1;
            }
            return modul(a) * modul(a);
        }

        public static int PoleProstokata(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return -1;
            }
            return modul(a) * modul(b);
        }

        public static int PoleTrojkata(int a, int h)
        {
            if (a == 0 || h == 0)
            {
                return -1;
            }
            return modul(a) * modul(h) / 2;
        }

        public static int ObwodKwadratu(int a)
        {
            if (a == 0)
            {
                return -1;
            }
            return 4 * modul(a);
        }

        public static int ObwodProstokata(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return -1;
            }
            return 2 * modul(a) + 2 * modul(b);
        }

        public static int ObwodTrojkata(int a, int b, int c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                return -1;
            }
            return modul(a) + modul(b) + modul(c);
        }

        public static bool TrojkatIstnieje(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            if (a > b && a > c && a < b + c)
            {
                return true;
            }
            else if (b > a && b > c && b < a + c)
            {
                return true;
            }
            else if (c > a && c > b && c < a + b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Czy_pierwszy_wiekszy_od_drugiego(int a1, int h1, int a2, int h2)
        {
            if (a1 == 0 || h1 == 0 || a2 == 0 || h2 == 0)
            {
                return false;
            }
            if (modul(a1) * modul(h1) > modul(a2) * modul(h2))
            {
                return true;
            }
            return false;
        }
        
        public static int[] Zamiana(int a, int b)
        {
            b = a + b;
            a = b - a;
            b = b - a;

            int[] values = new int[2] {a, b};

            return values;
        }

        /*public static int List_Sort(List<int>)
        {
            return List<int>;
        }*/
    }
}