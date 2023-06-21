using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{

    /*
    Integrantes-Grupo 5
    Numero de Cuenta-Nombre
    20172430034-Jhonny Javier Hernández 
    20191007299-Giancarlo Villars Reyes
    20201000460-Andrea Sofía Casco Medina 
    20201004846-Pablo César Flores
    20221001175-Jose Francisco Vargas
    */
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
