using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZadankaChlopaki;

namespace Testy
{
    [TestClass]
    public class ProstokatFunkcje
    {
        static Program _program = new Program();
        [TestMethod]
        public void Pole_Prostokata_6x9_metoda()
        {
            int result = Program.PoleProstokata(6, 9);

            Assert.AreEqual(54, result);
        }
        [TestMethod]
        public void Obwod_Prostokata_6x9_Metoda()
        {
            int result = Program.ObwodProstokata(6, 9);

            Assert.AreEqual(30, result);
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
    }
}
