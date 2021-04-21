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
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }

        capa_negocio.JefePractica jefepractica1 = new capa_negocio.JefePractica();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string dni = txtDni.Text;
            DateTime fechaNacimiento = dteFechaNacimiento.Value;
            string experiencia = txtExperiencia.Text;
            string especialidad = txtEspecialidad.Text;
            jefepractica1.Nombres = nombres;
            jefepractica1.Apellidos = apellidos;
            jefepractica1.Dni = dni;
            jefepractica1.FechaNacimiento = fechaNacimiento;
            jefepractica1.Experiencia = experiencia;
            jefepractica1.Especialidad = especialidad;
            MessageBox.Show("Se han registrado correctamente los datos del jefe de práctica 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = jefepractica1.Nombres;
            string apellidos = jefepractica1.Apellidos;
            string dni = jefepractica1.Dni;
            DateTime fechaNacimiento = jefepractica1.FechaNacimiento;
            string experiencia = jefepractica1.Experiencia;
            string especialidad = jefepractica1.Especialidad;
            MessageBox.Show("Nombres: " + nombres + "\nApellidos: " + apellidos + "\nDNI: " + dni + "\nFecha de nacimiento: " + fechaNacimiento + "\nExperiencia: " + experiencia + "\nEspecialidad: " + especialidad);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Enseñar());
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Calificar());
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Corregir());
        }

        private void btnInstruir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Instruir());
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefepractica1.Verificar());
        }
    }
}
