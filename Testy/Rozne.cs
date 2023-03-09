using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZadankaChlopaki;

namespace Testy
{
    [TestClass]
    public class Rozne
    {
        Program _program = new Program();
        [TestMethod]
        public void Zamiana_A_i_B_bez_trzeciej_zmiennej()
        {
            int a = 5;
            int b = 10;
             //test


            Assert.AreEqual(10, a);
            Assert.AreEqual(5, b);
        }
        [TestMethod]
        public void Posortuj_liste_od_min_do_max()
        {
            List<int> list = new List<int>() { 10, 1, 13, 2, 6, 9, 6, 7, 8, 9, 12, 4, -5 };
            //test 2
            List<int> result = new();

            CollectionAssert.AreEqual(new List<int>() { -5, 1, 2, 4, 6, 6, 7, 8, 9, 9, 10, 12, 13 }, result);
        }
        [TestMethod]
        public void Wybierz_z_listy_tylko_parzyste()
        {
            List<int> list = new List<int>() { 0, 3, 1, 7, 8, 148, 69 };

            List<int> result = new();

            CollectionAssert.AreEqual(new List<int>() { 0, 8, 148 }, result);
        }
        [TestMethod]
        public void Wybierz_z_listy_tylko_dodatnie()
        {
            List<int> list = new List<int>() { 0, -18, 12, -46, 223, 12, 1, -53, 45 };

            List<int> result = new();

            CollectionAssert.AreEqual(new List<int>() { 12, 223, 12, 1, 45 }, result);
        }
        [TestMethod]
        public void Wybierz_z_listy_dodatnie_parzyste_liczby_i_posortuj_min_max()
        {
            List<int> list = new List<int>() { 321, 123, 0, -34, 33, 89, 3, -69, 69, 12, 56, 32, 11 };

            List<int> result = new();

            CollectionAssert.AreEqual(new List<int>() { 12, 32, 56 }, result);
        }
        [TestMethod]
        public void Fibonacci_10()
        {
            int result = 0;

            Assert.AreEqual(34, result);
        }
        [TestMethod]
        public void Liczby_pierwsze_z_przedzialu_100_200()
        {
            List<int> result = new();

            CollectionAssert.AreEqual(new List<int>() { 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199 }, result);
        }
        [TestMethod]
        public void Odwroc_napis()
        {
            string zadanka = "zadanka";
            string result = "";

            Assert.AreEqual("aknadaz", result);
        }
        [TestMethod]
        public void Wytnij_parzyste_litery()
        {
            string zadanko = "DlugieSlowo";
            string result = "";

            Assert.AreEqual("DuiSoo", result);
        }
        [TestMethod]
        public void Miejsca_zerowe_x2_30x_m180()
        {
            int result1 = 0;
            int result2 = 0;

            Assert.AreEqual(30, result1);
            Assert.AreEqual(-60, result2);
        }
        [TestMethod]
        public void Reszta_z_dzielenia_przez_69_420() 
        {
            int result = 0;

            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void NWW_42_91() 
        {
            int result = 0;

            Assert.AreEqual(546,result);
        }
        [TestMethod]
        public void NWD_42_91() 
        {
            int result = 0;

            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void Rozklad_na_czynniki_pierwsze() 
        {
            List<int> result = new List<int>();

            CollectionAssert.AreEqual(new List<int>() { 2,3,7}, result);
        }
        [TestMethod]
        public void Potega() 
        {
            int number = 0;
            int power = 0;

            int result = 0;
            Assert.AreEqual(Math.Pow(number, power), result);
        }

    }
}
