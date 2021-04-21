using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class Rector
    {
        private string nombres;
        private string apellidos;
        private string dni;
        private DateTime fechaNacimiento;
        private string experiencia;
        private string titulo;
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
        public string Titulo
        {
            get { return titulo; }
            set { this.titulo = value; }
        }
        public string Dirigir()
        {
            return "No se ha implementado el método dirigir";
        }
        public string Administrar()
        {
            return "No se ha implementado el método administrar";
        }
        public string Representar()
        {
            return "No se ha implementado el método representar";
        }
        public string AprobarTrámites()
        {
            return "No se ha implementado el método aprobar trámites";
        }
        public string DesaprobarTrámites()
        {
            return "No se ha implementado el método desaprobar trámites";
        }
    }
}
