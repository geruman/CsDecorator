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
    public class HobbitTests
    {
        private Personaje hobbit;
        [TestInitialize()]
        public void Initialize()
        {
            hobbit = new Hobbit();
        }
        [TestMethod()]
        public void GetArmaduraTest()
        {
            Assert.AreEqual(hobbit.GetArmadura(), 0);
        }
        [TestMethod()]
        public void GetDescripcionTest()
        {
            Assert.AreEqual(hobbit.GetDescripcion(), "Un hobbit");
        }
    }
}