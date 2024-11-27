using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral.modelo
{
    internal class FinAtencion
    {
        public String fechaFin;
        public String horaFin;

        public FinAtencion(string fechaFin, string horaFin)
        {
            this.fechaFin = fechaFin;
            this.horaFin = horaFin;
        }

        public String FechaFin { get { return fechaFin; } set { fechaFin = value; } }
        public String HoraFin { get { return horaFin; } set { horaFin = value; } }
    }
}
