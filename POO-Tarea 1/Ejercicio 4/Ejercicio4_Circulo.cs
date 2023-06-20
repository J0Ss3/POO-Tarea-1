using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
