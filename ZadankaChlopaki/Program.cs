
﻿using System;
using ZadankaChlopaki.Classes;


namespace ZadankaChlopaki // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Trojkat trojkat = new Trojkat(5, 4);
            Console.WriteLine(trojkat.Pole());
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
        public static int Modulo(int a, int b)
        {
            int c = b / a;
            return b - (a * c);
        }
        public static int[] Miejsca_Zerowe(int x2, int x, int c)
        {
            int[] result = new int[2];

            int delta = Potega(x, 2) - (4 * x2 * c);
            result[1] = (-x - Pierwiastek(delta, 2)) / (2 * x2);
            result[0] = (-x + Pierwiastek(delta, 2)) / (2 * x2);

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
        public static int Pierwiastek(int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                if (Potega(i, b) == a) return i;
            }
            return -1;
        }
        public static bool Czy_pierwszy_wiekszy_od_drugiego(int a1, int h1, int a2, int h2)
        {
            if (PoleTrojkata(a1, h1) > PoleTrojkata(a2, h2))
            {
                return true;
            }
            return false;
        }
        public static string Tylko_Parzyste_Litery(string wyraz)
        {
            char[] znaki = wyraz.ToCharArray();
            string result = "";
            for (int i = 0; i < znaki.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += znaki[i];
                }
            }
            return result;
        }
        public static string Odwroc_Napis(string wyraz)
        {
            char[] znaki = wyraz.ToCharArray();
            string result = "";
            for (int i = znaki.Length - 1; i >= 0; i--)
            {
                result += znaki[i];
            }
            return result;
        }
        public static int Fibonacci(int n)
        {
            int number = n - 1;
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }
        public static List<int> LiczbyPierwsze(int start, int koniec)
        {
            int counter = 0;
            List<int> result = new List<int>();

            for(int i =start; i <= koniec; i++) 
            {
                for(int j=1;j <= koniec; j++) 
                {
                    if (i % j == 0) 
                    {
                        counter++;
                    }
                }
                if (counter == 2) 
                {
                    result.Add(i);
                }
                counter = 0;
            }
            return result;
        }
        public static int NWW(int a,int b) 
        {
            int x = a * b;
            int w = 0;

            while (b != 0) 
            {
                w = a % b;
                a = b;
                b = w;
            }
            return x / a;
        }
        public static int NWD(int a,int b) 
        {
            int w = 0;

            while (b != 0)
            {
                w = a % b;
                a = b;
                b = w;
            }
            return a;
        }
        public static List<int> Czynniki_pierwsze(int x) 
        {
            int i = 2;
            List<int> result= new List<int>();  
            while (i <= x)
            {
                while ((x % i) == 0)
                {
                    x /= i;
                    result.Add(i);
                }
                i++;
            }
            return result;
        }
        public static int ND(int a) 
        {
            for (int i = a-1; i > a; i--) 
            {
                if ((a % i) == 0) 
                {
                    return i;
                }
            }
            return -1;
        }
    }
}