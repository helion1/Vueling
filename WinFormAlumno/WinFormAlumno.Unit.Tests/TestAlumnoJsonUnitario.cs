using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace WinFormAlumno.Unit.Tests
{
    [TestClass]
    public class TestAlumnoJsonUnitario{
        private IHerramienta mockiHerramienta;
        private Alumno alumno;
        string json = "{\"id\":1,\"nombre\":\"Carlos\",\"apellidos\":\"Lopez Santamaria\",\"dni\":\"45787156k\"}";

        [TestInitialize]
        public void Setup() {
            var mockHer = new Mock<IHerramienta>();

            mockHer.Setup(x => x.AddAlumno(It.IsAny<Alumno>())).Returns(json);
            mockHer.Setup(x => x.LoadAlumno()).Returns(It.IsAny<Alumno>());
            //mockHer.Setup(x => x.AddAlumno(alumno)).Returns(json);
            //mockHer.Setup(x => x.LoadAlumno()).Returns(alumno);
            mockiHerramienta = mockHer.Object;
        }

        [TestCategory("Add")]
        [TestMethod]
        public void TestAddAlumno(){
            var result = mockiHerramienta.AddAlumno(alumno);
            Assert.AreEqual(result, json);
        }

        [TestCategory("Load")]
        [TestMethod]
        public void TestLoadAlumno() {
            var result = mockiHerramienta.LoadAlumno();
            Assert.AreEqual(result, alumno);
        }

    }
}
