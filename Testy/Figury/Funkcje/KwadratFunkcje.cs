using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZadankaChlopaki.Classes;
using ZadankaChlopaki;

namespace Testy
{
    [TestClass]
    public class KwadratFunkcje
    {
        static Program _program = new Program();
        [TestMethod]
        public void Pole_Kwadratu_4x4_metoda()
        {
            int result = Program.PoleKwadratu(4);

            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void Obwod_Kwadratu_4x4_Metoda()
        {
            int result = Program.ObwodKwadratu(4);

            Assert.AreEqual(16, result);
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
    }
}
