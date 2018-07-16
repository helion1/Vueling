using CovalcoWebApiClient.Controller;
using CovalcoWebApiClient.ViewModel;
using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovalcoWebApiClient.Forms {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtActualId.Text) && String.IsNullOrEmpty(txtNuevoNombre.Text)
                && String.IsNullOrEmpty(txtNuevoApellido.Text) && String.IsNullOrEmpty(txtNuevoDni.Text)) {

                MessageBox.Show(Resource.CampoVacio);
            } else {
                AlumnoViewModel alumno = new AlumnoViewModel(Convert.ToInt16(txtActualId.Text), txtNuevoNombre.Text, txtNuevoApellido.Text, txtNuevoDni.Text);
                HTTPApiController.PutAlumnoById(Convert.ToInt16(txtActualId.Text), alumno);
                this.Hide();
            }
        }
    }
}
