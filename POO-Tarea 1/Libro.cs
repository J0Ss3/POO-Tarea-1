using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{
    internal class Libro:Publicacion
    {
        public int numeroPaginas {get; set;}    
        public int añoPublicacion { get; set;}
        public void mostrarDatos()
        {
            Console.WriteLine(base.ToString() + "\n Tipo:Libro \n Numero de Paginas:" + numeroPaginas+"\n Año de Publicacion:"+añoPublicacion);
        }

        public Libro(string Titulo,float Precio,int Numeropaginas,int Añopublicacion)
        {
            titulo = Titulo;
            precio = Precio;
            numeroPaginas= Numeropaginas;
            añoPublicacion = Añopublicacion;
        }
    }
}
