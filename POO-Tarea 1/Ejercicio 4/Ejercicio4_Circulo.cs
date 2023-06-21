using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Integrantes-Grupo 5
Numero de Cuenta-Nombre
20172430034-Jhonny Javier Hernández 
20191007299-Giancarlo Villars Reyes
20201000460-Andrea Sofía Casco Medina 
20201004846-Pablo César Flores
20221001175-Jose Francisco Vargas
*/
namespace POO_Tarea_1.Ejercicio_4
{
    internal class Ejercicio4_Circulo : Ejercicio4_ObjetoGeometrico
    {


        private int radio { get; set; }
        private double area { get; set; }

        public void CalcularArea()
        {
            area = radio * radio * Math.PI;
        }
        public void mostrarArea()
        {
            Console.WriteLine("El area del Circulo es:" + area);
        }

        public Ejercicio4_Circulo(){}
        //Constructor llamando al constructor de su clase base
        public Ejercicio4_Circulo(int centroX,int centroY,int radio):base(centroX,centroY)
        {
            this.radio = radio;
            //El area es dependiente de las dimensiones de las figuras es por eso que no se puede declarar
            this.area = radio*radio*Math.PI;
        }
    }
}
