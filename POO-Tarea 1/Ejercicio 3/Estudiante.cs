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
