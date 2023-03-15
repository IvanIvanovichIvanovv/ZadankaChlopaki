using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZadankaChlopaki;
using ZadankaChlopaki.Classes;

namespace Testy
{
    [TestClass]
    public class Figury
    {
        static Program _program = new Program();
        #region Metody
        [TestMethod]
        public void Pole_Kwadratu_4x4_metoda()
        {

            int result = Program.PoleKwadratu(4) ; //Program.PoleKwadratu(4, 4);

            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void Pole_Prostokata_6x9_metoda()
        {
            int result = Program.PoleProstokata(6, 9);

            Assert.AreEqual(54, result);
        }
        [TestMethod]
        public void Pole_Trojkata_2x8_metoda()
        {
            int result = Program.PoleTrojkata(2, 8);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Obwod_Kwadratu_4x4_Metoda()
        {
            int result = Program.ObwodKwadratu(4);

            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void Obwod_Prostokata_6x9_Metoda()
        {
            int result = Program.ObwodProstokata(6, 9);

            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void Obwod_Trojkata_3x4x5_Metoda()
        {
            int result = Program.ObwodTrojkata(3, 4, 5);

            Assert.AreEqual(12, result);
        }
        [TestMethod]
        public void Czy_Trojkat_Istnieje_3x4x5()
        {
            bool result = Program.TrojkatIstnieje(3, 4, 5);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Czy_Trojkat_Istnieje_1x4x5()
        {
            bool result = Program.TrojkatIstnieje(1, 4, 5);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Czy_trojkat_ma_wieksze_pole_od_drugiego()
        {
            int a1 = 5;
            int h1 = 6;
            int a2 = 4;
            int h2 = 7;

            bool result = Program.Czy_pierwszy_wiekszy_od_drugiego(5, 6, 4, 7);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Pole_Kwadratu_m2_metoda()
        {
            int result = Program.PoleKwadratu(-2);

            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void Pole_Kwadratu_0_metoda()
        {
            int result = Program.PoleKwadratu(0);

            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void Obwod_Kwadratu_m3()
        {
            int result = Program.ObwodKwadratu(-3);

            Assert.AreEqual(result, 12);
        }
        [TestMethod]
        public void Obwod_Kwadratu_0()
        {
            int result = Program.ObwodKwadratu(0);

            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void Pole_Prostokata_m2_5_metoda()
        {
            int result = Program.PoleProstokata(-2, 5);

            Assert.AreEqual(result, 10);
        }
        [TestMethod]
        public void Pole_Prostokata_m2_0_metoda()
        {
            int result = Program.PoleProstokata(-2, 0);

            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void Obwod_Prostokata_m2_5()
        {
            int result = Program.ObwodProstokata(-2, 5);

            Assert.AreEqual(result, 14);
        }
        [TestMethod]
        public void Obwod_Prostokata_0_5()
        {
            int result = Program.ObwodProstokata(0, 5);

            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void Pole_Trojkata_m2_4()
        {
            int result = Program.PoleTrojkata(-2, 4);

            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void Pole_Trojkata_0_4()
        {
            int result = Program.PoleTrojkata(0, 4);

            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void Obwod_Trojkata_3_m4_5()
        {
            int result = Program.ObwodTrojkata(3, -4, 5);

            Assert.AreEqual(result, 12);
        }
        [TestMethod]
        public void Obwod_Trojkata_3_0_5()
        {
            int result = Program.ObwodTrojkata(3, 0, 5);

            Assert.AreEqual(result, -1);
        }


        #endregion

        #region klasa
        [TestMethod]
        public void Pole_Kwadratu_4x4_klasa()
        {
            Kwadrat kwadrat = new Kwadrat(4);
            int result = kwadrat.Pole();

            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void Pole_Kwadratu_m4xm4_klasa()
        {
            Kwadrat kwadrat = new Kwadrat(-4);
            int result = kwadrat.Pole();

            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void Pole_Prostokata_6x9_klasa()
        {
            Prostokat prostokat = new Prostokat(6, 9);
            int result = prostokat.Pole();

            Assert.AreEqual(54, result);
        }
        [TestMethod]
        public void Pole_Prostokata_m6x9_klasa()
        {
            Prostokat prostokat = new Prostokat(-6, 9);
            int result = prostokat.Pole();

            Assert.AreEqual(54, result);
        }
        [TestMethod]
        public void Pole_Trojkata_2x8_klasa()
        {
            Trojkat trojkat = new Trojkat(2, 8);
            int result = trojkat.Pole();

            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void Pole_Trojkata_m2x8_klasa()
        {
            Trojkat trojkat = new Trojkat(2, 8);
            int result = trojkat.Pole();

            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void Obwod_Kwadratu_4x4_klasa()
        {
            Kwadrat kwadrat = new Kwadrat(4);
            int result = kwadrat.Obwod();

            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void Obwod_Kwadratu_m4xm4_klasa()
        {
            Kwadrat kwadrat = new Kwadrat(-4);
            int result = kwadrat.Obwod();

            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void Obwod_Prostokata_6x9_klasa()
        {
            Prostokat prostokat = new Prostokat(6, 9);
            int result = prostokat.Obwod(6,9);

            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void Obwod_Prostokata_m6x9_klasa()
        {
            Prostokat prostokat = new Prostokat(-6, 9);
            int result = prostokat.Obwod();

            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void Obwod_Trojkata_3x4x5_klasa()
        {
            Trojkat trojkat = new Trojkat(3, 4, 5);
            int result = trojkat.Obwod();

            Assert.AreEqual(12, result);
        }
        [TestMethod]
        public void Obwod_Trojkata_m3x4x5_klasa()
        {
            Trojkat trojkat = new Trojkat(-3, 4, 5);
            int result = trojkat.Obwod();

            Assert.AreEqual(12, result);
        }
        #endregion
    }
}