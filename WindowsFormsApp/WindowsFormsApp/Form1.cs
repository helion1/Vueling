using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp {
    public partial class Form1 : Form {

        public delegate int Operacion(int a, int b);
        Operacion sum = null;
        Operacion res = null;
        Operacion mul = null;
        Operacion div = null;
        Operacion sumLambda = null;

        Calculadora calculadora = null;

        public Form1() {
            InitializeComponent();
            calculadora = new Calculadora();
            sum = new Operacion(calculadora.Suma);
            res = new Operacion(calculadora.Resta);
            mul = new Operacion(calculadora.Multiplicacion);
            div = new Operacion(calculadora.Division);

            //Equivalent to Suma without a class. Only with Lambda Expresion.
            sumLambda = (x, y) => (x + y);



        }

        private void button1_Click(object sender, EventArgs e) {
            int resSum = sum(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
            int resRes = res(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
            int resMul = mul(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
            int resDiv = div(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));


            MessageBox.Show(new StringBuilder()
                .Append(resSum.ToString())
                .Append(" , ")
                .Append(resRes.ToString())
                .Append(" , ")
                .Append(resMul.ToString())
                .Append(" , ")
                .Append(resDiv.ToString())
                .ToString());
        }
    }
}
