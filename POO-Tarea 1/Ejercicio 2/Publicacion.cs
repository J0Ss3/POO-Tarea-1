using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Integrantes-Grupo 5
Numero de Cuenta-Nombre
20172430034-Jhonny Javier Hernández 
20191007299-Giancarlo Villars Reyes
20201000460-Andrea Sofía Casco Medina 
20201004846-Pablo César Flores
20221001175-Jose Francisco Vargas
*/
namespace POO_Tarea_1
{
    internal class Publicacion
    {
        public string titulo { get; set; }  
        public float precio { get; set; }

        public override string ToString()
        {
            return $"Titulo: {titulo}\nPrecio: {precio}";
        }


    }
}
