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

        /*
        Integrantes-Grupo 5
        Numero de Cuenta-Nombre
        20172430034-Jhonny Javier Hernández 
        20191007299-Giancarlo Villars Reyes
        20201000460-Andrea Sofía Casco Medina 
        20201004846-Pablo César Flores
        20221001175-Jose Francisco Vargas
        */
        public void mostrarCentro()
        {
            Console.WriteLine("El centro de la figura es X={0} Y={1}", centroX, centroY);
        }
        public Ejercicio4_ObjetoGeometrico(){}
        public Ejercicio4_ObjetoGeometrico(int centroX, int centroY)
        {
            this.centroX = centroX;
            this.centroY = centroY;
        }
    }
}
