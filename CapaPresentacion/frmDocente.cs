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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        capa_negocio.Docente docente1 = new capa_negocio.Docente();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string dni = txtDni.Text;
            string apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = dteFechaNacimiento.Value;
            string profesion = txtProfesion.Text;
            docente1.Nombres = nombres;
            docente1.Dni = dni;
            docente1.Apellidos = apellidos;
            docente1.FechaNacimiento = fechaNacimiento;
            docente1.Profesion = profesion;
            MessageBox.Show("Se han registrado correctamente los datos del docente 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = docente1.Nombres;
            string dni = docente1.Dni;
            string apellidos = docente1.Apellidos;
            DateTime fechaNacimiento = docente1.FechaNacimiento;
            string profesion = docente1.Profesion;
            MessageBox.Show("Nombres: " + nombres + "\nApellidos: " + apellidos + "\nDNI: " + dni + "\nFecha de Nacimiento: " + fechaNacimiento + "\nProfesion: " + profesion);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Enseñar());
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Matricular());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Desaprobar());
        }
    }
}
