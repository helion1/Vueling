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
using Newtonsoft.Json;
using System.Configuration;
using System.Collections.Specialized;

namespace WinFormAlumno {
    public partial class Form1 : Form {
        string path = ConfigurationManager.AppSettings.Get("pathJsonAlumno");
        
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            RepositoryAlumno repositoryAlumno = new RepositoryAlumno();

            //MONTO EL OBJETO ALUMNO CON LOS DATOS DEL FORM
            Alumno alumno = new Alumno(Convert.ToInt32(id.Text),
                                                nombre.Text,
                                                apellidos.Text,
                                                dni.Text);

            //CREAMOS FICHERO alumno.json
            repositoryAlumno.AddAlumno(alumno, path);

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
                path = ConfigurationManager.AppSettings.Get("pathJsonAlumno");
            }

        }

        private void variableEntornoToolStripMenuItem_Click(object sender, EventArgs e) {
            if (path != Environment.GetEnvironmentVariable("ruta")) {
                path = Environment.GetEnvironmentVariable("ruta");
            }
        }
    }
}
