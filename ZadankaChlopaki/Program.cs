using System;
using System.Collections.Generic;

namespace ZadankaChlopaki // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 16;
            int b = 2;

            List<int> czynniki = List_Sort(Czynniki_pierwsze(a));
            List<int> czynniki_result = new List<int>();

            if (b == 2)
            {
                for (int i = 0; i < czynniki.Count / 2; i++)
                {
                    if (czynniki[i] == czynniki[i + 1])
                    {
                        czynniki_result.Add(czynniki[i]);
                    }
                    i++;
                }
            }


            int result = 1;

            for (int i = 0; i < czynniki_result.Count; i++)
            {
                result *= czynniki_result[i];
            }

            Console.WriteLine(czynniki[0]);
            Console.WriteLine(czynniki[1]);
            Console.WriteLine(czynniki[2]);
            Console.WriteLine(czynniki[3]);
            Console.WriteLine("dupa");
            Console.WriteLine(czynniki_result[0]);
            Console.WriteLine(czynniki_result[1]);

            Console.WriteLine(result);

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
        
        public static List<int> LiczbyPierwsze(int a, int b)
        {
            List<int> result = new List<int>();
            int number = a;
            for (int i = 0; i <= b - a; i++)
            {
                if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
                {
                    number++;
                }
                else
                {
                    int j = 7;
                    while (number % j != 0)
                    {
                        j++;
                    }
                    if (number == j)
                    {
                        result.Add(j);
                    }
                    number++;
                }
            }
            return result;
        }
        public static string Odwroc_Napis(string a)
        {
            char[] letters = a.ToCharArray();
            int length = letters.Length;
            char[] result_letters = new char[length];

            for (int i = 0; i < length; i++)
            {
                result_letters[i] = letters[length - 1 - i];
            }

            string result = new string(result_letters);
            return result;
        }

        public static string Tylko_Parzyste_Litery(string a)
        {
            char[] letters = a.ToCharArray();
            List<char> list = new List<char>();
            list.AddRange(letters);
            int length = list.Count;
            int j = 0;

            for (int i = 0; i < length; i++)
            {
                if (i % 2 != 0)
                {
                    list.Remove(list[j]);
                    j -= 1;
                }
                j += 1;
            }

            char[] result_letters = list.ToArray();
            string result = new string(result_letters);
            return result;
        }

        public static int Pierwiastek(int a, int b)
        {
            List<int> czynniki = List_Sort(Czynniki_pierwsze(a));
            List<int> czynniki_result = new List<int>();

            if (b == 2)
            {
                for (int i = 0; i <= czynniki.Count / 2; i++)
                {
                    if (czynniki[i] == czynniki[i + 1])
                    {
                        czynniki_result.Add(czynniki[i]);
                    }
                    i++;
                }
            }
            

            int result = 1;

            for (int i = 0; i < czynniki_result.Count; i++)
            {
                result *= czynniki_result[i];
            }

            return result;
        }

        /*public static int[] Miejsca_Zerowe(int a, int b, int c)
        {
            if (a == 0)
            {
                int x = -c / b;
                int[] miejsca_zerowe = new int[1] { x };
                return miejsca_zerowe;
            }
            int delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                int x1 = (-b + Pierwiastek(delta)) / 2 * a;
                int x2 = (-b - Pierwiastek(delta)) / 2 * a;
                int[] miejsca_zerowe = new int[2] { x1, x2 };
                return miejsca_zerowe;
            }
            else if (delta == 0)
            {
                int x = -b / 2 * a;
                int[] miejsca_zerowe = new int[1] { x };
                return miejsca_zerowe;
            }
            else
            {
                return;
            }
        }*/
        public static int Modulo(int a, int b)
        {
            int whole = b / a;
            int multiplication = whole * a;
            int result = b - multiplication;

            return result;
        }

        public static List<int> Czynniki_pierwsze(int a)
        {
            List<int> result = new List<int>();
            while (a != 1)
            {
                if (a % 2 == 0)
                {
                    a /= 2;
                    result.Add(2);
                }
                else if (a % 3 == 0)
                {
                    a /= 3;
                    result.Add(3);
                }
                else if (a % 5 == 0)
                {
                    a /= 5;
                    result.Add(5);
                }
                else
                {
                    int i = 7;
                    while (a % i != 0)
                    {
                        i++;
                    }
                    a /= i;
                    result.Add(i);
                }
            }
            return result;
        }
        public static int Potega(int a, int b)
        {
            int result = a;

            if (b < 0 || (a == 0 && b == 0))
            {
                return -1;
            }
            if (b == 0)
            {
                return 1;
            }
            for (int i = 0; i < b - 1; i++)
            {
                result *= a;
            }

            return result;
        }
    }
}