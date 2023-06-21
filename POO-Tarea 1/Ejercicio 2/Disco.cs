using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{
    internal class Disco:Publicacion
    {
        public double minutos {  get; set; }    

        public void mostrarDatos()
        {
            Console.WriteLine(base.ToString()+"\n Tipo:Disco \n Minutos:"+minutos);
        }

        public Disco(string Titulo, float Precio,double Minutos)
        {
            titulo = Titulo;
            precio = Precio;
            minutos= Minutos;
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
}
