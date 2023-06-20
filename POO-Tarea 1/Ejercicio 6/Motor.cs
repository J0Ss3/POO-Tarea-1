using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1.Ejercicio_6
{
    internal class Motor
    {
        private int _numero;
        private double _potencia;
        public int numero { get; set; }
        public double potencia { get; set; }
        public override string ToString()
{
        return $"Numero del Motor: {numero} \nPotencia: {potencia}";
}

    }
}
