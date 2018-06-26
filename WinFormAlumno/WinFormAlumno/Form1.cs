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

namespace WinFormAlumno {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            RepositoryAlumno herramienta = new RepositoryAlumno();

            //MONTO EL OBJETO ALUMNO CON LOS DATOS DEL FORM
            Alumno alumno = new Alumno( Convert.ToInt32(id.Text),
                                                nombre.Text,
                                                apellidos.Text,
                                                dni.Text);

            //CREAMOS FICHERO alumno.json
            herramienta.AddAlumno(alumno);

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void id_TextChanged(object sender, EventArgs e) {

        }
    }
}
