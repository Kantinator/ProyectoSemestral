using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral.modelo
{
    internal class Estatus
    {
        public String descripcion;

        public Estatus(String descripcion)
        {
            this.descripcion = descripcion;
        }
        public string Descripcion {  get { return descripcion; } set { descripcion = value; } }
    }
}
