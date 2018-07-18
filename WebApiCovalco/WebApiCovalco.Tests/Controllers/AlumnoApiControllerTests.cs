using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiCovalco.Controllers;
using WebApiCovalco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace WebApiCovalco.Controllers.Tests {
    [TestClass()]
    public class AlumnoApiControllerTests {
        [TestMethod()]
        public void GetAlumnoTest() {
            AlumnoApiController controller = new AlumnoApiController();
            IQueryable<Alumno> alumnos = controller.GetAlumno();
            Assert.IsTrue(alumnos.Count<Alumno>() > 0);
        }

        [TestMethod()]
        public void GetAlumnoById() {
            AlumnoApiController controller = new AlumnoApiController();
            IHttpActionResult actionResult = controller.GetAlumno(1);

            var contentResult = actionResult as
                OkNegotiatedContentResult<Alumno>;
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(1, contentResult.Content.Id);

        }

        [TestMethod()]
        public void PutAlumnoTest() {
            AlumnoApiController controller = new AlumnoApiController();
            IHttpActionResult actionResult = controller.PutAlumno(1,
                new
                Alumno { Id = 1, Nombre = "Ferran", Apellidos = "Ferrer", Dni = "23423434X" });
            Assert.IsNotNull(actionResult);
        }

        [TestMethod()]
        public void PostAlumnoTest() {
            AlumnoApiController controller = new AlumnoApiController();
            IHttpActionResult actionResult =
                controller.PostAlumno(
                    new Alumno {
                        Nombre = "Ferran",
                        Apellidos = "Ferrer", Dni = "23112314z"});

            var contentResult =
                actionResult as
                CreatedAtRouteNegotiatedContentResult<Alumno>;
            Assert.IsNotNull(actionResult);
            Assert.IsTrue(contentResult.RouteName == "DefaultApi");
        }

        [TestMethod()]
        public void DeleteAlumnoTest() {
            AlumnoApiController controller = new AlumnoApiController();
            IHttpActionResult actionResult =
                controller.PostAlumno(
                    new Alumno { Nombre = "Ferran",
                        Apellidos = "Ferrer", Dni = "23112314z"});

            var contentResult = actionResult as
                CreatedAtRouteNegotiatedContentResult<Alumno>;

            IHttpActionResult actionDeleteResult =
                controller.DeleteAlumno(contentResult.Content.Id);

            var contentDeleteResult = actionDeleteResult as
                OkNegotiatedContentResult<Alumno>;

            Assert.IsNotNull(contentDeleteResult);
            Assert.IsNotNull(contentDeleteResult.Content);
            Assert.IsTrue(contentDeleteResult.Content.Id == contentResult.Content.Id);


        }
    }
}