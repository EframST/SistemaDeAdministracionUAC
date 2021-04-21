using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class JefePractica
    {
        private string nombres;
        private string apellidos;
        private string dni;
        private DateTime fechaNacimiento;
        private string experiencia;
        private string especialidad;
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
        public string Experiencia
        {
            get { return experiencia; }
            set { this.experiencia = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { this.especialidad = value; }
        }
        public string Enseñar()
        {
            return ("No se ha implementado el método enseñar");
        }
        public string Calificar()
        {
            return ("No se ha implementado el método calificar");
        }
        public string Corregir()
        {
            return ("No se ha implementado el método corregir");
        }
        public string Instruir()
        {
            return ("No se ha implementado el método instruir");
        }
        public string Verificar()
        {
            return ("No se ha implementado el método verificar");
        }
    }
}
