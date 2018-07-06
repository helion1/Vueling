using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using FileServer.Common.Model;
using FileServer.Infrastructure.Respository.Repositories;

namespace WinFormAlumno {
    public partial class Form1 : Form {
        string path = ConfigurationManager.AppSettings.Get("pathJsonAlumno");
        
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            AlumnoRepository repositoryAlumno = new AlumnoRepository();

            //MONTO EL OBJETO ALUMNO CON LOS DATOS DEL FORM
            try {
                Alumno alumno = new Alumno(Convert.ToInt32(id.Text),
                                                nombre.Text,
                                                apellidos.Text,
                                                dni.Text);
                //CREAMOS FICHERO alumno.json
                try {
                    repositoryAlumno.Add(alumno, path);
                }catch (FileLoadException) {
                    Console.WriteLine("{0} roblemas al cargar el archivo .json.", e); 
                }
            } catch (ArgumentException){
                throw new Exception("Hay algún campo vacío");
            }

            

        }


        private void label2_Click(object sender, EventArgs e) {

        }

        private void id_TextChanged(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void rutaGuardadoToolStripMenuItem_Click(object sender, EventArgs e) {

        }
       

        private void appconfigToolStripMenuItem_Click(object sender, EventArgs e) {
            if (path != ConfigurationManager.AppSettings.Get("pathJsonAlumno")) {
                try {
                    path = ConfigurationManager.AppSettings.Get("pathJsonAlumno");
                } catch (ArgumentException) {
                    throw new Exception("Variable de AppSettings no configurada");
                }
            }

        }

        private void variableEntornoToolStripMenuItem_Click(object sender, EventArgs e) {
            if (path != Environment.GetEnvironmentVariable("vueling_home")) {
                try {
                    path = Environment.GetEnvironmentVariable("vueling_home");
                } catch (ArgumentException) {
                    throw new Exception("Variable de entorno 'vueling_home' no configurada");
                }
            }
        }
    }
}
