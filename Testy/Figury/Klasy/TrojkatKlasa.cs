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
    public class TrojkatKlasa
    {
        static Program _program = new Program();
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
        [TestMethod]
        public void Utworz_trojkat_3_4_5_h4() 
        {
            Trojkat trojkat = new Trojkat(3, 4, 5, 4);
            int[] result = trojkat.GetDimensions();

            CollectionAssert.AreEqual(new int[4] {3,4,5,4},result);
        }
        [TestMethod]
        public void Utworz_trojkat_3_m4_5_mh4()
        {
            Trojkat trojkat = new Trojkat(3,-4, 5,-4);
            int[] result = trojkat.GetDimensions();

            CollectionAssert.AreEqual(new int[4] { 3, 4, 5, 4 }, result);
        }
    }
}
