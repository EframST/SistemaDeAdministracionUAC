using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class Laboratorio
    {
        private string asignatura;
        private string instrumentos;
        private DateTime siguientePractica;
        private string encargado;
        private int aforo;
        public string Asignatura
        {
            get { return asignatura; }
            set { this.asignatura = value; }
        }
        public string Instrumentos
        {
            get { return instrumentos; }
            set { this.instrumentos = value; }
        }
        public DateTime SiguientePractica
        {
            get { return siguientePractica; }
            set { this.siguientePractica = value; }
        }
        public string Encargado
        {
            get { return encargado; }
            set { this.encargado = value; }
        }
        public int Aforo
        {
            get { return aforo; }
            set { this.aforo = value; }
        }
        public string Investigar()
        {
            return ("No se ha implementado el método investigar");
        }
        public string Aprender()
        {
            return ("No se ha implementado el método aprender");
        }
        public string Experimentar()
        {
            return ("No se ha implementado el método experimentar");
        }
        public string Concluir()
        {
            return ("No se ha implementado el método concluir");
        }
    }
}
