using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{
    internal class Cuadrado:ObjetoGeometrico
    {
        private int Lado;
        public int lado
        {
            get { return Lado; }
            set { Lado = value;
                calcularArea();
            }
        }
        public int area { get; private set; }

        private void calcularArea()
        {
            area = Lado * Lado;
        }
        public void mostrarArea()
        {
            Console.WriteLine("El area del Cuadrado es:"+area);
        }

        /*
        Integrantes-Grupo 5
        Numero de Cuenta-Nombre
        20172430034-Jhonny Javier Hernández 
        20191007299-Giancarlo Villars Reyes
        20201000460-Andrea Sofía Casco Medina 
        20201004846-Pablo César Flores
        20221001175-Jose Francisco Vargas
        */

    }
}
