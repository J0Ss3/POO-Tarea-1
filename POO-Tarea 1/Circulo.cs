using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{
    internal class Circulo : ObjetoGeometrico
    {
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
