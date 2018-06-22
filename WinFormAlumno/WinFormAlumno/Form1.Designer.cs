namespace WinFormAlumno {
    public partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dnijson = new System.Windows.Forms.TextBox();
            this.apellidosjson = new System.Windows.Forms.TextBox();
            this.nombrejson = new System.Windows.Forms.TextBox();
            this.idjson = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.jsonLiteral = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Guardar.Location = new System.Drawing.Point(409, 393);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(121, 45);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(60, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(60, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(60, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(60, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "DNI";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id.Location = new System.Drawing.Point(177, 109);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(250, 30);
            this.id.TabIndex = 5;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nombre.Location = new System.Drawing.Point(177, 177);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(250, 30);
            this.nombre.TabIndex = 6;
            // 
            // apellidos
            // 
            this.apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.apellidos.Location = new System.Drawing.Point(177, 242);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(250, 30);
            this.apellidos.TabIndex = 7;
            // 
            // dni
            // 
            this.dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dni.Location = new System.Drawing.Point(177, 314);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(250, 30);
            this.dni.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label5.Location = new System.Drawing.Point(152, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 67);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alumno";
            // 
            // dnijson
            // 
            this.dnijson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dnijson.Location = new System.Drawing.Point(630, 313);
            this.dnijson.Name = "dnijson";
            this.dnijson.Size = new System.Drawing.Size(250, 30);
            this.dnijson.TabIndex = 17;
            // 
            // apellidosjson
            // 
            this.apellidosjson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.apellidosjson.Location = new System.Drawing.Point(630, 241);
            this.apellidosjson.Name = "apellidosjson";
            this.apellidosjson.Size = new System.Drawing.Size(250, 30);
            this.apellidosjson.TabIndex = 16;
            // 
            // nombrejson
            // 
            this.nombrejson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nombrejson.Location = new System.Drawing.Point(630, 176);
            this.nombrejson.Name = "nombrejson";
            this.nombrejson.Size = new System.Drawing.Size(250, 30);
            this.nombrejson.TabIndex = 15;
            // 
            // idjson
            // 
            this.idjson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idjson.Location = new System.Drawing.Point(630, 108);
            this.idjson.Name = "idjson";
            this.idjson.Size = new System.Drawing.Size(250, 30);
            this.idjson.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(513, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(513, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Apellidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(513, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(513, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label10.Location = new System.Drawing.Point(636, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 67);
            this.label10.TabIndex = 18;
            this.label10.Text = "json";
            // 
            // jsonLiteral
            // 
            this.jsonLiteral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jsonLiteral.Location = new System.Drawing.Point(630, 406);
            this.jsonLiteral.Multiline = true;
            this.jsonLiteral.Name = "jsonLiteral";
            this.jsonLiteral.Size = new System.Drawing.Size(250, 111);
            this.jsonLiteral.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(704, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Json literal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 529);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.jsonLiteral);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dnijson);
            this.Controls.Add(this.apellidosjson);
            this.Controls.Add(this.nombrejson);
            this.Controls.Add(this.idjson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dnijson;
        private System.Windows.Forms.TextBox apellidosjson;
        private System.Windows.Forms.TextBox nombrejson;
        private System.Windows.Forms.TextBox idjson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox jsonLiteral;
        private System.Windows.Forms.Label label11;
    }
}

