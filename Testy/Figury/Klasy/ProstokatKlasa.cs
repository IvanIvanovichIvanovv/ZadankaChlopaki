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
    public class ProstokatKlasa
    {
        static Program _program = new Program();
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
        public void Obwod_Prostokata_6x9_klasa()
        {
            Prostokat prostokat = new Prostokat(6, 9);
            int result = prostokat.Obwod();

            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void Obwod_Prostokata_m6x9_klasa()
        {
            Prostokat prostokat = new Prostokat(-6, 9);
            int result = prostokat.Obwod();

            Assert.AreEqual(30, result);
        }
    }
}
