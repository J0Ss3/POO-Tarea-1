using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{
    internal class ObjetoGeometrico
    {
        public int centroX { get; set; }
        public int centroY { get; set; }
        public void mostrarCentro()
        {
            Console.WriteLine("El centro de la figura es X={0} Y={1}", centroX, centroY);
        }
    }
}
