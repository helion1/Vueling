using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace WinFormAlumno.Integratios.Tests{

    [TestClass]
    public class TestAlumnoJson{
        Herramienta herramienta = new Herramienta();
        Alumno alumnoTest = new Alumno();
               
        [TestInitialize]
        public void Inicializacion() {
            alumnoTest.id = 1;
            alumnoTest.nombre = "Carlos";
            alumnoTest.apellidos = "Lopez Santamaria";
            alumnoTest.dni = "45787156k";
            
            herramienta.AddAlumno(alumnoTest);
            herramienta.alumno = herramienta.LoadAlumno();
        }


        [TestMethod]
        public void TestAlumno(){
            Assert.AreEqual(alumnoTest.id, herramienta.alumno.id);
            Assert.AreEqual(alumnoTest.nombre, herramienta.alumno.nombre);
            Assert.AreEqual(alumnoTest.apellidos, herramienta.alumno.apellidos);
            Assert.AreEqual(alumnoTest.dni, herramienta.alumno.dni);
            Assert.AreEqual(alumnoTest, herramienta.alumno);
        }

    }
}
