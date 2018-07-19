using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.Facade.Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Application.Dto;

namespace Vueling.Facade.Api.Controllers.Tests {
    [TestClass()]
    public class AlumnoApiControllerTests {
        [TestMethod()]
        public void AlumnoApiControllerTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void AlumnoApiControllerTest1() {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTest() {
            AlumnoApiController controller = new AlumnoApiController();
            List<AlumnoDto> alumnos = controller.Get();
            Assert.IsTrue(alumnos.Count<AlumnoDto>() > 0);
        }

        [TestMethod()]
        public void GetTest1() {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void PutTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest() {
            Assert.Fail();
        }
    }
}