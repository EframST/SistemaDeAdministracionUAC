using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }

        capa_negocio.Asignatura asignatura1 = new capa_negocio.Asignatura();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime siguienteClase = dteSiguienteClase.Value;
            string aula = txtAula.Text;
            string carreraProfesional = txtCarreraProfesional.Text;
            int creditos = int.Parse(txtCreditos.Text);
            asignatura1.Nombre = nombre;
            asignatura1.SiguienteClase = siguienteClase;
            asignatura1.Aula = aula;
            asignatura1.CarreraProfesional = carreraProfesional;
            asignatura1.Creditos = creditos;
            MessageBox.Show("Se han registrado correctamente los datos de la asignatura 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombre = asignatura1.Nombre;
            DateTime siguienteClase = asignatura1.SiguienteClase;
            string aula = asignatura1.Aula;
            string carreraProfesional = asignatura1.CarreraProfesional;
            int creditos = asignatura1.Creditos;
            MessageBox.Show("Nombre: " + nombre + "\nSiguiente clase: " + siguienteClase + "\nAula: " + aula + "\nCarrera profesional: " + carreraProfesional + "\nCréditos: " + creditos);
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Aprender());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Enseñar());
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Investigar());
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Corregir());
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Practicar());
        }
    }
}
