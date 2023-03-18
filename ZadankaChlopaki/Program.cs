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
            return a * b;
        }

        public static int PoleTrojkata(int a, int b)
        {
            return a * b / 2;
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
            return 2 * (a + b);
        }

        public static int ObwodTrojkata(int a, int b, int c)
        {
            return a + b + c;
        }

        public static bool CzyTrojkatIstnieje(int a, int b, int c)
        {
            if (a + b <= c || b + c <= a || c + a <= b)
            {
                return false;
            }
            return true;
        }
    }
}