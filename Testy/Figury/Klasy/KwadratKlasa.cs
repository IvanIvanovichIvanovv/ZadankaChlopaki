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
    public class KwadratKlasa
    {
        static Program _program = new Program();
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
    }
}
