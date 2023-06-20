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

    }
}
