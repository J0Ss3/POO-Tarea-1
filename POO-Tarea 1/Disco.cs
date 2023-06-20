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
}
