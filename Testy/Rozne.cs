using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZadankaChlopaki;

namespace Testy
{
    [TestClass]
    public class Rozne
    {
        static Program _program = new Program();
        [TestMethod]
        public void Zamiana_A_i_B_bez_trzeciej_zmiennej()
        {
            int[] values = new int[2] { 5, 10 };
            int[] result = Program.Zamiana(values[0], values[1]);

            Assert.AreEqual(result[0], 10);
            Assert.AreEqual(result[1], 5);
        }
        [TestMethod]
        public void Posortuj_liste_od_min_do_max()
        {
            List<int> list = new List<int>() { 10, 1, 13, 2, 6, 9, 6, 7, 8, 9, 12, 4, -5 };
            //test 2
            List<int> result = Program.List_Sort(list);

            CollectionAssert.AreEqual(new List<int>() { -5, 1, 2, 4, 6, 6, 7, 8, 9, 9, 10, 12, 13 }, result);
        }
        [TestMethod]
        public void Wybierz_z_listy_tylko_parzyste()
        {
            List<int> list = new List<int>() { 0, 3, 1, 7, 8, 148, 69 };

            List<int> result = Program.TylkoParzyste(list);

            CollectionAssert.AreEqual(new List<int>() { 0, 8, 148 }, result);
        }
        [TestMethod]
        public void Wybierz_z_listy_tylko_dodatnie()
        {
            List<int> list = new List<int>() { 0, -18, 12, -46, 223, 12, 1, -53, 45 };

            List<int> result = Program.TylkoDodatnie(list);

            CollectionAssert.AreEqual(new List<int>() { 12, 223, 12, 1, 45 }, result);
        }
        [TestMethod]
        public void Wybierz_z_listy_dodatnie_parzyste_liczby_i_posortuj_min_max()
        {
            List<int> list = new List<int>() { 321, 123, 0, -34, 33, 89, 3, -69, 69, 12, 56, 32, 11 };

            List<int> result = Program.Dodatnie_Parzyste_Sort(list);

            CollectionAssert.AreEqual(new List<int>() { 12, 32, 56 }, result);
        }
        [TestMethod]
        public void Fibonacci_10()
        {
            int result = Program.Fibonacci(10);

            Assert.AreEqual(34, result);
        }
        [TestMethod]
        public void Liczby_pierwsze_z_przedzialu_100_200()
        {
            List<int> result = Program.LiczbyPierwsze(100, 200);

            CollectionAssert.AreEqual(new List<int>() { 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199 }, result);
        }
        [TestMethod]
        public void Odwroc_napis()
        {
            string zadanka = "zadanka";
            string result = Program.Odwroc_Napis(zadanka);

            Assert.AreEqual("aknadaz", result);
        }
        [TestMethod]
        public void Wytnij_parzyste_litery()
        {
            string zadanko = "DlugieSlowo";
            char[] charArray = zadanko.ToCharArray(); //podpowiadajka
            string result = Program.Tylko_Parzyste_Litery(zadanko);

            Assert.AreEqual("DuiSoo", result);
        }
        [TestMethod]
        public void Miejsca_zerowe_x2_30x_m180()
        {
            int[] miejsca_zerowe = Program.Miejsca_Zerowe(2, 30, -180);

            Assert.AreEqual(30, miejsca_zerowe[0]);
            Assert.AreEqual(-60, miejsca_zerowe[1]);
        }
        [TestMethod]
        public void Reszta_z_dzielenia_przez_69_420()
        {
            int result = Program.Modulo(69, 420);

            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void NWW_42_91()
        {
            int result = Program.NWW(42, 91);

            Assert.AreEqual(546, result);
        }
        [TestMethod]
        public void NWD_42_91()
        {
            int result = Program.NWD(42, 91);

            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void Rozklad_na_czynniki_pierwsze_42()
        {
            List<int> result = Program.Czynniki_pierwsze(42);

            CollectionAssert.AreEqual(new List<int>() { 2, 3, 7 }, result);
        }
        [TestMethod]
        public void Potega()
        {
            int number = 0;
            int power = 0;

            int result = Program.Potega(number, power);
            Assert.AreEqual(Math.Pow(number, power), result);
        }

    }
}
