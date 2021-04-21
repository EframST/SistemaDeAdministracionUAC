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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        capa_negocio.Rector rector1 = new capa_negocio.Rector();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string dni = txtDni.Text;
            DateTime fechaNacimiento = dteFechaNacimiento.Value;
            string experiencia = txtExperiencia.Text;
            string titulo = txtTitulo.Text;
            rector1.Nombres = nombres;
            rector1.Apellidos = apellidos;
            rector1.Dni = dni;
            rector1.FechaNacimiento = fechaNacimiento;
            rector1.Experiencia = experiencia;
            rector1.Titulo = titulo;
            MessageBox.Show("Se han registrado correctamente los datos del rector 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = rector1.Nombres;
            string apellidos = rector1.Apellidos;
            string dni = rector1.Dni;
            DateTime fechaNacimiento = rector1.FechaNacimiento;
            string experiencia = rector1.Experiencia;
            string titulo = rector1.Titulo;
            MessageBox.Show("Nombres: " + nombres + "\nApellidos: " + apellidos + "\nDNI: " + dni + "\nFecha de nacimiento: " + fechaNacimiento + "\nExperiencia: " + experiencia + "\nTítulo: " + titulo);
        }

        private void btnDirigir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Dirigir());
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Administrar());
        }

        private void btnRepresentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Representar());
        }

        private void btnAprobarTramites_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.AprobarTrámites());
        }

        private void btnDesaprobarTramites_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.DesaprobarTrámites());
        }
    }
}
