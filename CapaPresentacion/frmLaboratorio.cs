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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }

        capa_negocio.Laboratorio laboratorio1 = new capa_negocio.Laboratorio();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string asignatura = txtAsignatura.Text;
            string instrumentos = txtInstrumentos.Text;
            DateTime siguientePractica = dteSiguientePractica.Value;
            string encargado = txtEncargado.Text;
            int aforo = int.Parse(txtAforo.Text);
            laboratorio1.Asignatura = asignatura;
            laboratorio1.Instrumentos = instrumentos;
            laboratorio1.SiguientePractica = siguientePractica;
            laboratorio1.Encargado = encargado;
            laboratorio1.Aforo = aforo;
            MessageBox.Show("Se han registrado correctamente los datos del laboratorio 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string asignatura = laboratorio1.Asignatura;
            string instrumentos = laboratorio1.Instrumentos;
            DateTime siguientePractica = laboratorio1.SiguientePractica;
            string encargado = laboratorio1.Encargado;
            int aforo = laboratorio1.Aforo;
            MessageBox.Show("Asignatura: " + asignatura + "\nInstrumentos: " + instrumentos + "\nSiguiente práctica: " + siguientePractica + "\nEncargado: " + encargado + "\nAforo: " + aforo);
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Investigar());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Aprender());
        }

        private void btnExperimentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Experimentar());
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Concluir());
        }
    }
}
