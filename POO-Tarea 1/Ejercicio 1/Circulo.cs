using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{
    internal class Circulo : ObjetoGeometrico
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
        private int radio1;

        public int radio
        {
            get { return radio1; }
            set
            {
                radio1 = value;
                CalcularArea();
            }
        }

        //El area depende del radio
        public double area { get; private set; }

        private void CalcularArea()
        {
            area = radio1 * radio1 * Math.PI;
        }
        public void mostrarArea()
        {
            Console.WriteLine("El area del Circulo es:" + area);
        }
    }
}
