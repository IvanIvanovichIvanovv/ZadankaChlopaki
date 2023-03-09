using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZadankaChlopaki;

namespace Testy
{
    [TestClass]
    public class Figury
    {
        Program _program=new Program();
        #region Metody
        [TestMethod]
        public void Pole_Kwadratu_4x4_metoda()
        {
            int result = 0; //_program.PoleKwadratu(4, 4);

            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void Pole_Prostokata_6x9_metoda()
        {
            int result = 0;

            Assert.AreEqual(54, result);
        }
        [TestMethod]
        public void Pole_Trojkata_2x8_metoda()
        {
            int result = 0;

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Obwod_Kwadratu_4x4_Metoda() 
        {
            int result = 0;

            Assert.AreEqual(16,result);
        }
        [TestMethod]
        public void Obwod_Prostokata_6x9_Metoda()
        {
            int result = 0;

            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void Obwod_Trojkata_3x4x5_Metoda()
        {
            int result = 0;

            Assert.AreEqual(12, result);
        }
        [TestMethod]
        public void Czy_Trojkat_Istnieje_3x4x5() 
        {
            bool result = false;

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Czy_Trojkat_Istnieje_1x4x5()
        {
            bool result = false;

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Czy_trojkat_ma_wieksze_pole_od_drugiego() 
        {
            int a1 = 5;
            int h1 = 6;
            int a2 = 4;
            int h2 = 7;

            bool result = true;

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Pole_Kwadratu_m2_metoda() 
        {
            int result = 0;

            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void Pole_Kwadratu_0_metoda()
        {
            int result = 0;

            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void Obwod_Kwadratu_m3() 
        {
            int result = 0;

            Assert.AreEqual(result, 12);
        }
        [TestMethod]
        public void Obwod_Kwadratu_0()
        {
            int result = 0;

            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void Pole_Prostokata_m2_5_metoda()
        {
            int result = 0;

            Assert.AreEqual(result, 10);
        }
        [TestMethod]
        public void Pole_Prostokata_m2_0_metoda()
        {
            int result = 0;

            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void Obwod_Prostokata_m2_5() 
        {
            int result = 0;

            Assert.AreEqual(result, 14);
        }
        [TestMethod]
        public void Obwod_Prostokata_0_5()
        {
            int result = 0;

            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void Pole_Trojkata_m2_4() 
        {
            int result = 0;

            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void Pole_Trojkata_0_4()
        {
            int result = 0;

            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void Obwod_Trojkata_3_m4_5() 
        {
            int result = 0;

            Assert.AreEqual(result, 12);
        }
        [TestMethod]
        public void Obwod_Trojkata_3_0_5()
        {
            int result = 0;

            Assert.AreEqual(result, -1);
        }


        #endregion

        #region klasa
        [TestMethod]
        public void Pole_Kwadratu_4x4_klasa()
        {
            int result = 0;

            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void Pole_Prostokata_6x9_klasa()
        {
            int result = 0;

            Assert.AreEqual(54, result);
        }
        [TestMethod]
        public void Pole_Trojkata_2x8_klasa()
        {
            int result = 0;

            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void Obwod_Kwadratu_4x4_klasa()
        {
            int result = 0;

            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void Obwod_Prostokata_6x9_klasa()
        {
            int result = 0;

            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void Obwod_Trojkata_3x4x5_klasa()
        {
            int result = 0;

            Assert.AreEqual(12, result);
        }
        #endregion
    }
}