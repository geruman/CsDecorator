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
    public class BotasDecoratorTests
    {
        private Personaje elfo;
        [TestInitialize()]
        public void Initialize()
        {
            elfo = new Elfo();
            elfo = new BotasDecorator(elfo);
        }
        [TestMethod()]
        public void GetDescripcionTest()
        {
            Assert.AreEqual(elfo.GetDescripcion().Contains("con botas"), true);
        }
        [TestMethod()]
        public void GetArmaduraTest()
        {
            Assert.AreEqual(elfo.GetArmadura(), 1);
        }
    }
}