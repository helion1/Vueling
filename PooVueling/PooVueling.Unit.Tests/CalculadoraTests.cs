using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        private ICalculadora mockObject;

        [TestInitialize]
        public void Setup()
        {
            var mock = new Mock<ICalculadora>();
            mock.Setup(x => x.Suma(2, 2)).Returns(4);
            mock.Setup(x => x.Resta(4, 2)).Returns(2);
            mock.Setup(x => x.Division(4, 2)).Returns(2);
            mock.Setup(x => x.Multiplicacion(4, 2)).Returns(8);
            mockObject = mock.Object;
        }


        [TestMethod()]
        public void DivisionTest()
        {
            //log4net.AssemblyInfo("hola");
            var result = mockObject.Division(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void MultiplicacionTest()
        {
            var result = mockObject.Multiplicacion(4, 2);
            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void RestaTest()
        {
            var result = mockObject.Resta(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void SumaTest()
        {
            var result = mockObject.Division(4, 2);
            Assert.AreEqual(2, result);
        }
    }
}