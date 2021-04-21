
namespace CapaPresentacion
{
    partial class frmNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.btnMedir = new System.Windows.Forms.Button();
            this.btnComprobarRendimiento = new System.Windows.Forms.Button();
            this.btnDesaprobar = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(535, 84);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(130, 53);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(535, 158);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(130, 53);
            this.btnEscribir.TabIndex = 1;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(284, 99);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(166, 22);
            this.txtAlumno.TabIndex = 2;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(284, 274);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(166, 22);
            this.txtPeso.TabIndex = 3;
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Location = new System.Drawing.Point(284, 228);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(166, 22);
            this.txtAsignatura.TabIndex = 4;
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(284, 186);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(166, 22);
            this.txtDocente.TabIndex = 5;
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Location = new System.Drawing.Point(284, 144);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(166, 22);
            this.txtPuntaje.TabIndex = 6;
            // 
            // btnMedir
            // 
            this.btnMedir.Location = new System.Drawing.Point(640, 339);
            this.btnMedir.Name = "btnMedir";
            this.btnMedir.Size = new System.Drawing.Size(130, 53);
            this.btnMedir.TabIndex = 7;
            this.btnMedir.Text = "Medir";
            this.btnMedir.UseVisualStyleBackColor = true;
            this.btnMedir.Click += new System.EventHandler(this.btnMedir_Click);
            // 
            // btnComprobarRendimiento
            // 
            this.btnComprobarRendimiento.Location = new System.Drawing.Point(492, 339);
            this.btnComprobarRendimiento.Name = "btnComprobarRendimiento";
            this.btnComprobarRendimiento.Size = new System.Drawing.Size(130, 53);
            this.btnComprobarRendimiento.TabIndex = 8;
            this.btnComprobarRendimiento.Text = "Comprobar rendimiento";
            this.btnComprobarRendimiento.UseVisualStyleBackColor = true;
            this.btnComprobarRendimiento.Click += new System.EventHandler(this.btnComprobarRendimiento_Click);
            // 
            // btnDesaprobar
            // 
            this.btnDesaprobar.Location = new System.Drawing.Point(336, 339);
            this.btnDesaprobar.Name = "btnDesaprobar";
            this.btnDesaprobar.Size = new System.Drawing.Size(130, 53);
            this.btnDesaprobar.TabIndex = 9;
            this.btnDesaprobar.Text = "Desaprobar";
            this.btnDesaprobar.UseVisualStyleBackColor = true;
            this.btnDesaprobar.Click += new System.EventHandler(this.btnDesaprobar_Click);
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(188, 339);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(130, 53);
            this.btnAprobar.TabIndex = 10;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(37, 339);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(130, 53);
            this.btnCalificar.TabIndex = 11;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(151, 104);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(59, 17);
            this.lblAlumno.TabIndex = 12;
            this.lblAlumno.Text = "Alumno:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(151, 279);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(44, 17);
            this.lblPeso.TabIndex = 13;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(151, 233);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(80, 17);
            this.lblAsignatura.TabIndex = 14;
            this.lblAsignatura.Text = "Asignatura:";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(151, 189);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(65, 17);
            this.lblDocente.TabIndex = 15;
            this.lblDocente.Text = "Docente:";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(151, 147);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(60, 17);
            this.lblPuntaje.TabIndex = 16;
            this.lblPuntaje.Text = "Puntaje:";
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.btnDesaprobar);
            this.Controls.Add(this.btnComprobarRendimiento);
            this.Controls.Add(this.btnMedir);
            this.Controls.Add(this.txtPuntaje);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.txtAsignatura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Name = "frmNotas";
            this.Text = "Clase Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.Button btnMedir;
        private System.Windows.Forms.Button btnComprobarRendimiento;
        private System.Windows.Forms.Button btnDesaprobar;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblPuntaje;
    }
}