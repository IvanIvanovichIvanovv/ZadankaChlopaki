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
            return a * a;
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
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }

        public static bool Czy_pierwszy_wiekszy_od_drugiego(int a1, int h1, int a2, int h2)
        {
            if (PoleTrojkata(a1, h1) > PoleTrojkata(a2, h2))
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

        public static List<int> List_Sort(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int[] values = Zamiana(list[j], list[j + 1]);
                        list[j] = values[0];
                        list[j + 1] = values[1];
                    }
                }
            }
            return list;
        }

        public static List<int> TylkoParzyste(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    list.Remove(list[i]);
                    i -= 1;
                }
            }
            return list;
        }
        public static List<int> TylkoDodatnie(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= 0)
                {
                    list.Remove(list[i]);
                    i -= 1;
                }
            }
            return list;
        }
        public static List<int> Dodatnie_Parzyste_Sort(List<int> list)
        {
            list = TylkoDodatnie(TylkoParzyste(List_Sort(list)));
            return list;
        }
        public static int Fibonacci(int a)
        {
            if (a == 0)
            {
                return 0;
            }
            if (a == 1)
            {
                return 1;
            }
            if (a > 1)
            {
                List<int> result = new List<int>() {0, 1};
                for (int i = 0; i < a - 1; i++)
                {
                    result.Add(result[i] + result[i + 1]);
                }
                return result[a - 1];
            }
            return -1;
        }
    }
}