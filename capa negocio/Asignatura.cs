using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class Asignatura
    {
        private string nombre;
        private DateTime siguienteClase;
        private string aula;
        private string carreraProfesional;
        private int creditos;
        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
        public DateTime SiguienteClase
        {
            get { return siguienteClase; }
            set { this.siguienteClase = value; }
        }
        public string Aula
        {
            get { return aula; }
            set { this.aula = value; }
        }
        public string CarreraProfesional
        {
            get { return carreraProfesional; }
            set { this.carreraProfesional = value; }
        }
        public int Creditos
        {
            get { return creditos; }
            set { this.creditos = value; }
        }
        public string Aprender()
        {
            return ("No se ha implementado el método aprender");
        }
        public string Enseñar()
        {
            return ("No se ha implementado el método enseñar");
        }
        public string Investigar()
        {
            return ("No se ha implementado el método investigar");
        }
        public string Corregir()
        {
            return ("No se ha implementado el método corregir");
        }
        public string Practicar()
        {
            return ("No se ha implementado el método practicar");
        }
    }
}
