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

/*
Integrantes-Grupo 5
Numero de Cuenta-Nombre
20172430034-Jhonny Javier Hernández 
20191007299-Giancarlo Villars Reyes
20201000460-Andrea Sofía Casco Medina 
20201004846-Pablo César Flores
20221001175-Jose Francisco Vargas
*/
