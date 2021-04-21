using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class PPP
    {
        private string especialidad;
        private string empresa;
        private string jefe;
        private string practicantes;
        private int creditos;
        private DateTime fecha;
        public string Especialidad
        {
            get { return especialidad; }
            set { this.especialidad = value; }
        }
        public string Empresa
        {
            get { return empresa; }
            set { this.empresa = value; }
        }
        public string Jefe
        {
            get { return jefe; }
            set { this.jefe = value; }
        }
        public string Practicantes
        {
            get { return practicantes; }
            set { this.practicantes = value; }
        }
        public int Creditos
        {
            get { return creditos; }
            set { this.creditos = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { this.fecha = value; }
        }
        public string Practicar()
        {
            return "No se ha implementado el método practicar";
        }
        public string Aprender()
        {
            return "No se ha implementado el método aprender";
        }
        public string Reforzar()
        {
            return "No se ha implementado el método reforzar";
        }
        public string AdquirirExperiencia()
        {
            return "No se ha implementado el método adquirir experiencia";
        }
    }
}
