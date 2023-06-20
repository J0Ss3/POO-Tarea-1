using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{
    internal abstract class Persona
    {
        public string nombre { get; set; }
        public string direccion { get; set; }


        public abstract void divertirse();
        public abstract void mostrarDatos();
    }
}
