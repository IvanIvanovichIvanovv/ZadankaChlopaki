using System;
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
            ///
        }
        
        public static int[] Zamiana(int a, int b) 
        {
            a = a - b;
            b = a + b;
            a = b - a;

            return new int[] { a, b };

        }
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
    }
}