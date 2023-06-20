using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1.Ejercicio_5
{
    internal class Ejercicio5_Libro : Ejercicio5_Publicacion
    {
        private int numeroPaginas { get; set; }
        private int añoPublicacion { get; set; }

        public void mostrarDatos()
        {
            Console.WriteLine(base.ToString() + "\nTipo: Libro \nNumero de Paginas: " + numeroPaginas + "\nAño de Publicacion: " + añoPublicacion);
        }

        public Ejercicio5_Libro(string Titulo, float Precio, int Numeropaginas, int Añopublicacion)
        {
            titulo = Titulo;
            precio = Precio;
            numeroPaginas = Numeropaginas;
            añoPublicacion = Añopublicacion;
        }

        public Ejercicio5_Libro()
        {
            titulo = "Titulo por defecto";
            precio = 0.0f;
            numeroPaginas = 0;
            añoPublicacion = 0;
        }
    }
}
