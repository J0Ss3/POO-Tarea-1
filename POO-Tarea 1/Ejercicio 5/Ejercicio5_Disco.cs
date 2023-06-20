using System;
using System.Collections.Generic;
using System.Linq;
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
