using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral.modelo
{
    public class NivelPrioridad
    {
        public int Id { get; set; }
        public string Nivel { get; set; }

        public NivelPrioridad(int id, string nivel)
        {
            Id = id;
            Nivel = nivel;
        }

        public override string ToString()
        {
            return Nivel;
        }
    }
}
