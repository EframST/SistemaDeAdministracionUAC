using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class Notas
    {
        private string alumno;
        private int puntaje;
        private string docente;
        private string asignatura;
        private string peso;
        public string Alumno
        {
            get { return alumno; }
            set { this.alumno = value; }
        }
        public int Puntaje
        {
            get { return puntaje; }
            set { this.puntaje = value; }
        }
        public string Docente
        {
            get { return docente; }
            set { this.docente = value; }
        }
        public string Asignatura
        {
            get { return asignatura; }
            set { this.asignatura = value; }
        }
        public string Peso
        {
            get { return peso; }
            set { this.peso = value; }
        }
        public string Calificar()
        {
            return "No se ha implementado el método calificar";
        }
        public string Aprobar()
        {
            return "No se ha implementado el método aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el método desaprobar";
        }
        public string ComprobarRendimiento()
        {
            return "No se ha implementado el método comprobar rendimiento";
        }
        public string Medir()
        {
            return "No se ha implementado el método medir";
        }
    }
}
