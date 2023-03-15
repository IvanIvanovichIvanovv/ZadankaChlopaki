using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZadankaChlopaki;
using ZadankaChlopaki.Classes;

namespace Testy
{
    [TestClass]
    public class TrojkatFunkcje
    {
        static Program _program = new Program();
        [TestMethod]
        public void Pole_Trojkata_2x8_metoda()
        {
            int result = Program.PoleTrojkata(2, 8);

            Assert.AreEqual(8, result);
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
        
    }
}
