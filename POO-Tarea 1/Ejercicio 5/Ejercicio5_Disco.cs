using System;
using System.Collections.Generic;
using System.Linq;

/*
Integrantes-Grupo 5
Numero de Cuenta-Nombre
20172430034-Jhonny Javier Hernández 
20191007299-Giancarlo Villars Reyes
20201000460-Andrea Sofía Casco Medina 
20201004846-Pablo César Flores
20221001175-Jose Francisco Vargas
*/
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1.Ejercicio_5
{
    internal class Ejercicio5_Disco : Ejercicio5_Publicacion
    {
        private double minutos { get; set; }

        public void mostrarDatos()
        {
            Console.WriteLine(base.ToString() + "\nTipo: Disco \nMinutos: " + minutos);
        }

        public Ejercicio5_Disco(string Titulo, float Precio, double Minutos)
        {
            titulo = Titulo;
            precio = Precio;
            minutos = Minutos;
        }

        public Ejercicio5_Disco()
        {
            titulo = "Titulo por defecto";
            precio = 0.0f;
            minutos = 0.0;
        }
    }
}
