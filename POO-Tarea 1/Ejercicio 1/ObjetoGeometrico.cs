using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{

    /*
    Integrantes-Grupo 5
    Numero de Cuenta-Nombre
    20172430034-Jhonny Javier Hernández 
    20191007299-Giancarlo Villars Reyes
    20201000460-Andrea Sofía Casco Medina 
    20201004846-Pablo César Flores
    20221001175-Jose Francisco Vargas
    */
    internal class ObjetoGeometrico
    {
        public int centroX { get; set; }
        public int centroY { get; set; }
        public void mostrarCentro()
        {
            Console.WriteLine("El centro de la figura es X={0} Y={1}",centroX,centroY);
        }
    }
}
