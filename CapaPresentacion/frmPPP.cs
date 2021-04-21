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
    public partial class frmPPP : Form
    {
        public frmPPP()
        {
            InitializeComponent();
        }
        capa_negocio.PPP ppp1 = new capa_negocio.PPP();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string especialidad = txtEspecialidad.Text;
            string empresa = txtEmpresa.Text;
            string jefe = txtJefe.Text;
            string practicantes = txtPracticantes.Text;
            int creditos = int.Parse(txtCreditos.Text);
            DateTime fecha = dteFecha.Value;
            ppp1.Especialidad = especialidad;
            ppp1.Empresa = empresa;
            ppp1.Jefe = jefe;
            ppp1.Practicantes = practicantes;
            ppp1.Creditos = creditos;
            ppp1.Fecha = fecha;
            MessageBox.Show("Se han registrado correctamente los datos de la práctica pre profesional 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string especialidad = ppp1.Especialidad;
            string empresa = ppp1.Empresa;
            string jefe = ppp1.Empresa;
            string practicantes = ppp1.Practicantes;
            int creditos = ppp1.Creditos;
            DateTime fecha = ppp1.Fecha;
            MessageBox.Show("Especialidad: " + especialidad + "\nEmpresa: " + empresa + "\nJefe: " + jefe + "\nPracticantes: " + practicantes + "\nCréditos: " + creditos + "\nFecha: " + fecha);
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Practicar());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Aprender());
        }

        private void btnReforzar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Reforzar());
        }

        private void btnAdquirirExperiencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.AdquirirExperiencia());
        }
    }
}
