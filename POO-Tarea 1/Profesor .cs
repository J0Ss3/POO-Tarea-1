using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{
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
