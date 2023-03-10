using System;
using System.Security.Cryptography.X509Certificates;

namespace ZadankaChlopaki // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] result = Miejsca_Zerowe(4, 12, -16);
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
        public static List<int> List_Sort(List<int> list)
        {

            for (int j = 0; j < list.Count; j++)
            {
                int index = 0;
                int max = list[0];
                for (int i = 0; i < list.Count - j; i++)
                {
                    if (list[i] >= max)
                    {
                        max = list[i];
                        index = i;
                    }
                }
                SwapListElement(list, index, list.Count - 1 - j);
            }
            return list;
        }
        public static void SwapListElement(List<int> list, int a, int b)
        {
            int c = list[a];
            list[a] = list[b];
            list[b] = c;
        }
        public static List<int> TylkoParzyste(List<int> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
            return list;
        }
        public static List<int> TylkoDodatnie(List<int> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] <= 0)
                {
                    list.RemoveAt(i);
                }
            }
            return list;
        }
        public static List<int> Dodatnie_Parzyste_Sort(List<int> list)
        {
            TylkoParzyste(list);
            TylkoDodatnie(list);
            List_Sort(list);
            return list;
        }
        public static int Modulo(int a,int b) 
        {
            int c = b / a;
            return b - (a * c);
        }
        public static int[] Miejsca_Zerowe(int x2,int x,int c) 
        {
            int[] result= new int[2];

            int delta = Potega(x, 2) - (4 * x2 * c);
            result[1] = (-x - Pierwiastek(delta, 2)) / (2*x2);
            result[0] = (-x + Pierwiastek(delta, 2)) / (2*x2);

            return result;
        }
        public static int Potega(int liczba, int potega)
        {
            int result = 1;

            for (int i = 0; i < potega; i++) 
            {
                result *= liczba;
            }

            return result;
        }
        public static int Pierwiastek(int a ,int b) 
        {
            for(int i = 0; i < a; i++) 
            {
                if(Potega(i,b)==a) return i;
            }
            return -1;
        }
    }
}