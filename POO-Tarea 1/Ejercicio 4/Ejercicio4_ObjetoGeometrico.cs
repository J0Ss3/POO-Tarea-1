using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1.Ejercicio_4
{
    internal class Ejercicio4_ObjetoGeometrico
    {
        private int centroX { get; set; }
        private int centroY { get; set; }
        public void mostrarCentro()
        {
            Console.WriteLine("El centro de la figura es X={" + centroX + "} Y={" + centroY + "}");
        }
        public Ejercicio4_ObjetoGeometrico(){}
        public Ejercicio4_ObjetoGeometrico(int centroX, int centroY)
        {
            this.centroX = centroX;
            this.centroY = centroY;
        }
    }
}
