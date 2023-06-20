using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1.Ejercicio_6
{
    internal class Chassis
    {
        private int _numero;
        private double _peso;
        public int numero { get; set; }
        public double peso { get; set; }

        public override string ToString()
        {
            return $"Numero del Chassis: {numero} \nPeso: {peso}";
        }

    }
}
