using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral.modelo
{
    internal class InicioAtencion
    {
        public String fechaInicio;
        public String horaInicio;
        public String diagnostico;

        public InicioAtencion(string fechaInicio, string horaInicio, string diagnostico)
        {
            this.fechaInicio = fechaInicio;
            this.horaInicio = horaInicio;
            this.diagnostico = diagnostico;
        }
        
        public String FechaInicio {  get { return fechaInicio; } set { fechaInicio = value; } }
        public String HoraInicio { get {return horaInicio; } set { horaInicio = value; } }
        public String Diagnostico { get { return diagnostico; } set { diagnostico = value; } }
    }
}
