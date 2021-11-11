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
    public class ElfoTests
    {
        private Personaje elfo;
        [TestInitialize()]
        public void Initialize()
        {
            elfo = new Elfo();
        }
        [TestCleanup()]
        public void CleanUp()
        {
            elfo = null;
        }
        [TestMethod()]
        public void GetDescripcionTest()
        {
            Assert.AreEqual(elfo.GetDescripcion(), "Un elfo");
        }

        [TestMethod()]
        public void GetArmaduraTest()
        {
            Assert.AreEqual(elfo.GetArmadura(), 0);
        }
    }
}