using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{
    internal class Publicacion
    {
        public string titulo { get; set; }  
        public float precio { get; set; }

        public override string ToString()
        {
            return $"Titulo: {titulo}\nPrecio: {precio}";
        }


    }
}
