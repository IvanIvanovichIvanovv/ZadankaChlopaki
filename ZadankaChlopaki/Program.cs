using System;

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
            return PoleProstokata(a, a);
        }
        public static int PoleProstokata(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return -1;
            }
            return Math.Abs(a * b);
        }
        public static int ObwodKwadratu(int a)
        {
            return ObwodProstokata(a, a);
        }
        public static int ObwodProstokata(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return -1;
            }
            return Math.Abs(2 * a) + Math.Abs(2 * b);
        }
        public static bool TrojkatIstnieje(int a, int b, int c)
        {
            int newA = Math.Abs(a);
            int newB = Math.Abs(b);
            int newC = Math.Abs(c);
            if (newA + newB > newC && newA + newC > newB && newB + newC > newA)
            {
                return true;
            }
            return false;
        }
        public static int ObwodTrojkata(int a, int b, int c)
        {
            if (TrojkatIstnieje(a, b, c))
            {
                return Math.Abs(a) + Math.Abs(b) + Math.Abs(c);
            }
            return -1;
        }
        public static int PoleTrojkata(int a, int h)
        {//
            if (a == 0 || h == 0)
            {
                return -1;
            }
            return Math.Abs((a * h) / 2);
        }
        public static int[] Zamiana(int a, int b)
        {
            int[] values = new int[2] { a, b };
            values[0] += values[1];
            values[1] = values[0] - values[1];
            values[0] -= values[1];
            return values;
        }
    }
}