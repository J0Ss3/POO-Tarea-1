using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1.Ejercicio_4
{
    internal class Ejercicio4_Cuadrado:Ejercicio4_ObjetoGeometrico
    {
        private int lado { get; set; }
        private int area { get; set; }

        public void calcularArea()
        {
            area = lado * lado;
        }
        public void mostrarArea()
        {
            Console.WriteLine("El area del Cuadrado es:" + area);
        }

        public Ejercicio4_Cuadrado() { }
        //Constructor llamando al constructor de su clase base
        public Ejercicio4_Cuadrado(int centroX, int centroY,int lado) : base(centroX,centroY)
        {
            this.lado = lado;
            //El area es dependiente de las dimensiones de las figuras es por eso que no se puede declarar
            this.area = lado*lado;
        }
    }
}
