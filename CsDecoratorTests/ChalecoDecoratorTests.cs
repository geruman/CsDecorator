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
    public class ChalecoDecoratorTests
    {
        private Personaje hobbit;
        [TestInitialize()]
        public void Initialize()
        {
            hobbit = new Hobbit();
            hobbit = new ChalecoDecorator(hobbit);
        }
        [TestMethod()]
        public void GetDescripcionTest()
        {
            Assert.AreEqual(hobbit.GetDescripcion().Contains("bajo un hermoso chaleco hay "), true);
        }
        [TestMethod()]
        public void GetArmaduraTest()
        {
            Assert.AreEqual(hobbit.GetArmadura(), 4);
        }
    }
}