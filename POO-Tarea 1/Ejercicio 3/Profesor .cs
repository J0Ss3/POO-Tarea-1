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
    enum Jornada
    {
        Matutina,
        Vespertina
    }

    internal class Profesor:Persona
    {
        public int numeroEmpleado { get; set; }
        public Jornada jornada { get; set; }


        // Metodos heredados
        public override void divertirse()
        {
            Console.WriteLine("Ganandole la mesada al estudiante en el billar");
        }
        public override void mostrarDatos()
        {
            Console.WriteLine("Nombre:" + nombre +
               "\nDireccion:" + direccion
               + "\nNumero de Empleado:" + numeroEmpleado
               + "\nJornada:" + jornada);
        }

        //Constructor
        public Profesor(string Nombre, string Direccion, int Numeroempleado, Jornada jornada_Dato)
        {
            nombre = Nombre;
            direccion = Direccion;
            numeroEmpleado = Numeroempleado;
            jornada= jornada_Dato;
        }
        public Profesor(){}
    }
}
