using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral.modelo
{
    public class TipoSolicitud
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public TipoSolicitud(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
