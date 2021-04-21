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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        capa_negocio.Notas notas1 = new capa_negocio.Notas();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string alumno = txtAlumno.Text;
            int puntaje = int.Parse(txtPuntaje.Text);
            string docente = txtDocente.Text;
            string asignatura = txtAsignatura.Text;
            string peso = txtPeso.Text;
            notas1.Alumno = alumno;
            notas1.Puntaje = puntaje;
            notas1.Docente = docente;
            notas1.Asignatura = asignatura;
            notas1.Peso = peso;
            MessageBox.Show("Se han registrado correctamente los datos de las notas 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string alumno = notas1.Alumno;
            int puntaje = notas1.Puntaje;
            string docente = notas1.Docente;
            string asignatura = notas1.Asignatura;
            string peso = notas1.Peso;
            MessageBox.Show("Alumno: " + alumno + "\nPuntaje: " + puntaje + "\nDocente: " + docente + "\nAsignatura: " + asignatura + "\nPeso: " + peso);
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Calificar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Desaprobar());
        }

        private void btnComprobarRendimiento_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.ComprobarRendimiento());
        }

        private void btnMedir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Medir());
        }
    }
}
