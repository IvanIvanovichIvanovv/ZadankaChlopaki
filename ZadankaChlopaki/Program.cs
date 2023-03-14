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
        }
    }
}