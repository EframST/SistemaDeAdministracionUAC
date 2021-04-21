using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class Docente
    {
        //atributos
        private string nombres;
        private string apellidos; 
        private string dni;
        private DateTime fechaNacimiento;
        private string profesion;
        //propiedades
        public string Nombres
        {
            get { return nombres; }
            set { this.nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { this.apellidos = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { this.dni = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { this.profesion = value; }
        }
        //métodos
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string Matricular()
        {
            return "No se ha implementado el metodo matricular";
        }
        public string Aprobar()
        {
            return "No se ha implementado el metodo aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el metodo desaprobar";
        }
    }
}
