using CovalcoWebApiClient.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Net.Http.Headers;

namespace CovalcoWebApiClient.Controller {
    public class HTTPApiController {
        static HttpClient client;

        public HTTPApiController() { }
        static HTTPApiController() {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52924/");
        }
     


        public static async Task<List<AlumnoViewModel>> GetCall() {
            IEnumerable<AlumnoViewModel> listaAlumnos = new List<AlumnoViewModel>();
            try {
                HttpResponseMessage response = client.GetAsync(Resource.pathGetAllAlumnos).Result;
                if (response.IsSuccessStatusCode) {
                    Console.WriteLine("Response message information:- \n\n" + response.RequestMessage + "\n");
                    Console.WriteLine("Response message Header:- \n\n" + response.Content.Headers + "\n");
                    //GET THE RESPONSE
                    var alumnoJsonString = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Your response data is: " + alumnoJsonString);
                    var deserialized = JsonConvert.DeserializeObject<IEnumerable<AlumnoViewModel>>(alumnoJsonString);
                    listaAlumnos = deserialized;
                }

            }catch (Exception e) {
                Console.WriteLine(Resource.MensajeError);
                throw e;
                
            }
            return listaAlumnos.ToList();
        }

        public static async void PostCreateAlumno(AlumnoViewModel alumno) {
            try {
                var contenido = JsonConvert.SerializeObject(alumno);
                var buffer = Encoding.UTF8.GetBytes(contenido);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = await client.PostAsync(Resource.pathPostAddAlumno, byteContent);
            } catch (Exception ex) {
                Console.WriteLine(Resource.MensajeError);
                throw ex;
            }
        }

        public static async Task<AlumnoViewModel> GetAlumnoById(int id) {
            AlumnoViewModel alumno = new AlumnoViewModel();
            try {
                HttpResponseMessage response = client.GetAsync(Resource.pathGetAlumnoById + id).Result;
                if (response.IsSuccessStatusCode) {
                    var alumnoJsonString = await response.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<AlumnoViewModel>(alumnoJsonString);
                    alumno = deserialized;
                }

            } catch (Exception e) {
                Console.WriteLine(Resource.MensajeError);
                throw e;
            }
            return alumno;
        }

        public static async void PutAlumnoById(int id, AlumnoViewModel alumno) {
            try {
                var contenido = JsonConvert.SerializeObject(alumno);
                var buffer = Encoding.UTF8.GetBytes(contenido);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = await client.PutAsync(Resource.pathPutAlumnoById + id, byteContent);
            } catch (Exception ex) {
                Console.WriteLine(Resource.MensajeError);
                throw ex;
            }
        }

        public static async void DeleteAlumnoById(int id) {
            AlumnoViewModel alumno = new AlumnoViewModel();
            try {
                HttpResponseMessage response = client.DeleteAsync(Resource.pathDeleteAlumnoById + id).Result;
                if (response.IsSuccessStatusCode) {
                    var alumnoJsonString = await response.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<AlumnoViewModel>(alumnoJsonString);
                    alumno = deserialized;
                }
            } catch (Exception e) {
                Console.WriteLine(Resource.MensajeError);
                throw e;
            }
        }

    }
}
