using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CovalcoWebApii.Models;

namespace CovalcoWebApii.Controllers
{
    public class AlumnoApiController : ApiController
    {
        private CovalcoEntities db = new CovalcoEntities();

        // GET: api/AlumnoApi
        public IQueryable<Alumno> GetAlumno()
        {
            return db.Alumno;
        }

        // GET: api/AlumnoApi/5
        [ResponseType(typeof(Alumno))]
        public IHttpActionResult GetAlumno(int id)
        {
            Alumno alumno = db.Alumno.Find(id);
            if (alumno == null)
            {
                return NotFound();
            }

            return Ok(alumno);
        }

        // PUT: api/AlumnoApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAlumno(int id, Alumno alumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != alumno.Id)
            {
                return BadRequest();
            }

            db.Entry(alumno).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AlumnoApi
        [ResponseType(typeof(Alumno))]
        public IHttpActionResult PostAlumno(Alumno alumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Alumno.Add(alumno);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = alumno.Id }, alumno);
        }

        // DELETE: api/AlumnoApi/5
        [ResponseType(typeof(Alumno))]
        public IHttpActionResult DeleteAlumno(int id)
        {
            Alumno alumno = db.Alumno.Find(id);
            if (alumno == null)
            {
                return NotFound();
            }

            db.Alumno.Remove(alumno);
            db.SaveChanges();

            return Ok(alumno);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AlumnoExists(int id)
        {
            return db.Alumno.Count(e => e.Id == id) > 0;
        }
    }
}