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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 529);
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
    }
}

