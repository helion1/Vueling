using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace WinFormAlumno.Integratios.Tests{

    [TestClass]
    public class RepositoryAlumnoIntegrationTest{
        RepositoryAlumno repository = new RepositoryAlumno();
        Alumno alumnoTest = new Alumno();
               
        [TestInitialize]
        public void Inicializacion() {
            alumnoTest.Id = 1;
            alumnoTest.Nombre = "Carlos";
            alumnoTest.Apellidos = "Lopez Santamaria";
            alumnoTest.Dni = "45787156k";
            
            repository.AddAlumno(alumnoTest);
        }


        [TestMethod]
        public void TestAlumno(){
            //Assert.IsTrue(repository.Alumno.Equals(alumnoTest));
            Assert.AreEqual(alumnoTest.Nombre, repository.Alumno.Nombre);
            Assert.AreEqual(alumnoTest.Apellidos, repository.Alumno.Apellidos);
            Assert.AreEqual(alumnoTest.Dni, repository.Alumno.Dni);
            Assert.AreEqual(alumnoTest, repository.Alumno);
        }

    }
}
