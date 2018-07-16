using CovalcoWebApiClient.Controller;
using CovalcoWebApiClient.Forms;
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

namespace CovalcoWebApiClient {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Console.WriteLine(Resource.MensajeInicio);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            List<AlumnoViewModel> alumnos = new List<AlumnoViewModel>();
            alumnos = HTTPApiController.GetCall().Result;
            dataGridView1.DataSource = alumnos;
            dataGridView1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtId.Text)) {
                MessageBox.Show(Resource.CampoVacio);
            } else {
                AlumnoViewModel alumno = new AlumnoViewModel();
                alumno = HTTPApiController.GetAlumnoById(Convert.ToInt16(txtId.Text)).Result;
                List<AlumnoViewModel> lista = new List<AlumnoViewModel>();
                lista.Add(alumno);
                dataGridView1.DataSource = lista;
                dataGridView1.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
