using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDecorator.Tests
{
    [TestClass()]
    public class CapaDecoratorTests
    {
        private Personaje personaje;
        [TestInitialize()]
        public void Initialize()
        {
            personaje = new Hobbit();
            personaje = new CapaDecorator(personaje);
        }
        [TestCleanup()]
        public void Cleanup()
        {
            personaje = null;
        }
        [TestMethod()]
        public void GetArmaduraTest()
        {
            Assert.AreEqual(personaje.GetArmadura(), 1);
        }
        [TestMethod()]
        public void GetDescripcionTest()
        {
            Assert.AreEqual(personaje.GetDescripcion(), "Un hobbit y usa capa");
        }

    }
}