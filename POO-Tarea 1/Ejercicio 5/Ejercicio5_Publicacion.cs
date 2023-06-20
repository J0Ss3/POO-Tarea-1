using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1.Ejercicio_5
{
    internal class Ejercicio5_Publicacion
    {
        protected string titulo { get; set; }
        protected float precio { get; set; }

        public override string ToString()
        {
            return $"Titulo: {titulo}\nPrecio: {precio}";
        }

    }
}
