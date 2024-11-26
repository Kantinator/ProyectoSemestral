using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral.modelo
{
    public class AperturaTiquete
    {
        public int NumeroTiquete { get; set; }
        public int IdTipoSolicitud { get; set; }
        public string DescripcionSolicitud { get; set; }
        public DateTime FechaTiquete { get; set; }
        public TimeSpan HoraApertura { get; set; }
        public int IdPrioridad { get; set; }
        public string NombreUsuario { get; set; }
        public string AreaTrabajo { get; set; }
        public int IdEstatus { get; set; }

        // Constructor
        public AperturaTiquete(int idTipoSolicitud, string descripcionSolicitud, int idPrioridad, string nombreUsuario, string areaTrabajo, int idEstatus = 1)
        {
            IdTipoSolicitud = idTipoSolicitud;
            DescripcionSolicitud = descripcionSolicitud;
            FechaTiquete = DateTime.Now;
            HoraApertura = DateTime.Now.TimeOfDay;
            IdPrioridad = idPrioridad;
            NombreUsuario = nombreUsuario;
            AreaTrabajo = areaTrabajo;
            IdEstatus = idEstatus;
        }
    }
}
