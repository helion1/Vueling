using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace WinFormAlumno.Unit.Tests
{
    [TestClass]
    public class RepositoryAlumnoUnitTests{
        private IRepositoryAlumno mockObject;
        private Alumno alumno;

        [TestInitialize]
        public void Setup() {
            var mockIRepository = new Mock<IRepositoryAlumno>();
            alumno = new Alumno(1, "Carlos", "Lopez", "45787156K");
            //mockIRepository.Setup(x => x.AddAlumno(It.IsAny<Alumno>())).Returns(alumno);
            mockIRepository.Setup(x => x.AddAlumno(alumno)).Returns(alumno);
            mockObject = mockIRepository.Object;
        }

        [TestCategory("Add")]
        [TestMethod]
        public void TestAddAlumno(){
            var result = mockObject.AddAlumno(alumno);
            Assert.AreEqual(result, alumno);
        }

    }
}
