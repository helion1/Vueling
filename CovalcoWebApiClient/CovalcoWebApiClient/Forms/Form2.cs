using CovalcoWebApiClient.Controller;
using CovalcoWebApiClient.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovalcoWebApiClient.Forms {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            Console.WriteLine(Resource.MensajeInicio);
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtApellidos.Text) && !String.IsNullOrEmpty(txtDni.Text)) {
                AlumnoViewModel alumno = new AlumnoViewModel(txtNombre.Text, txtApellidos.Text, txtDni.Text);
                HTTPApiController.PostCreateAlumno(alumno);
                this.Hide();
            } else {
                MessageBox.Show(Resource.CampoVacio);
            }
        }

        
    }
}
