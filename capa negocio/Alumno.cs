using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class Alumno
    {
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimiento;
        public string Apellidos
        {
            get { return apellidos; }
            set { this.apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { this.nombres = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { this.edad = value; }
        }
        public string LugarNacimiento
        {
            get { return lugarNacimiento; }
            set { this.lugarNacimiento = value; }
        }
        public string Estudiar()
        {
            return "No se ha implementado el método estudiar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el método trabajar";
        }
        public string AprobarExamen()
        {
            return "No se ha implementado el método aprobar examen";
        }
        public string PresentarTarea()
        {
            return "No se ha implementado el método presentar tarea";
        }
    }
}
