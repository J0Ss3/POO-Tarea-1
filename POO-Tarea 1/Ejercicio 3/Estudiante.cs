using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{
    internal class Estudiante:Persona
    {
        public int numeroCuenta { get; set; }

        /*
        Integrantes-Grupo 5
        Numero de Cuenta-Nombre
        20172430034-Jhonny Javier Hernández 
        20191007299-Giancarlo Villars Reyes
        20201000460-Andrea Sofía Casco Medina 
        20201004846-Pablo César Flores
        20221001175-Jose Francisco Vargas
        */
        public int indiceAcademico { get; set; }


        // Metodos heredados
        public override void divertirse() {
            Console.WriteLine("El estudiante esta apostando la mesada en el billar");
        }
        public override void mostrarDatos() {
            Console.WriteLine("Nombre:"+nombre+
                "\nDireccion:"+direccion
                +"\nNumero de Cuenta:"+numeroCuenta
                +"\nIndice Academico:"+indiceAcademico);
        }

        //Constructor
        public Estudiante(string Nombre,string Direccion,int Numerocuenta,int Indiceacademico) {
            nombre = Nombre;
            direccion = Direccion;
            numeroCuenta= Numerocuenta;
            indiceAcademico= Indiceacademico;  
        }
    }
}
