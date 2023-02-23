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