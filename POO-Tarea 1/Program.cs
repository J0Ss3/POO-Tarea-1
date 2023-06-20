using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



namespace POO_Tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Boolean finEjecucion = false;

            do
            {
                //Seleccion de Ejercicio
                Console.WriteLine("Seleccione el ejercicio");      
                Console.WriteLine("1)Diseñar y programar las clases Circulo y Cuadrado derivadas de ObjetoGeometrico ");
                Console.WriteLine("2)Una editorial de libros desea crear un sistema ");
                Console.WriteLine("3)Implemente una clase abstracta Persona ");
                Console.WriteLine("0)Salir");
                Console.WriteLine("Ingrese un número:");
                int numeroEjercicio = Convert.ToInt32(Console.ReadLine());

                //Switch para determinar la ejecucion de cada ejercicio
                switch (numeroEjercicio)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2: 
                        Ejercicio2();   
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Ejercicio4();
                        break;
                    case 5:
                        Ejercicio5();
                        break;
                    case 6:
                        Ejercicio6();
                        break;
                    case 7:
                        Ejercicio7();
                        break;
                    default:
                        finEjecucion = true;
                        break;
                }
                Console.ReadLine();

            }while(!finEjecucion);   
        }

        static void Ejercicio1()
        {
            Circulo circulo = new Circulo();
            Cuadrado cuadrado = new Cuadrado();

            //Declaracion del centro del cuadrado
            Console.WriteLine("Ingrese la coordenada x del centro del Cuadrado");
            cuadrado.centroX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del centro del Cuadrado");
            cuadrado.centroY = Convert.ToInt32(Console.ReadLine());

            //Largo del Lado del Cuadrado
            Console.WriteLine("Ingrese el largo de un lado del cuadrado");
            cuadrado.lado = Convert.ToInt32(Console.ReadLine());

            //Declaracion del centro del circulo
            Console.WriteLine("Ingrese la coordenada x del centro del Circulo");
            circulo.centroX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del centro del Circulo");
            circulo.centroY = Convert.ToInt32(Console.ReadLine());

            //Radio del Circulo
            Console.WriteLine("Ingrese el largo de un lado del cuadrado");
            circulo.radio = Convert.ToInt32(Console.ReadLine());

            //Area y centro del cuadrado
            Console.WriteLine("Cuadrado:");
            cuadrado.mostrarCentro();
            cuadrado.mostrarArea();

            //Area y centro del circulo
            Console.WriteLine("Circulo:");
            circulo.mostrarCentro();
            circulo.mostrarArea();
        }


        static void Ejercicio2()
        {
            //Declararcion de las variables y objetos necesarios
            int tipoPublicacion,numeroPaginas,añoPublicacion,opcion;
            float precio;
            string nombre;
            double minutos;
            Boolean bucleSalida = false;
            //LinkedList para no tener un limite
            LinkedList<Libro> listaLibros= new LinkedList<Libro>();
            LinkedList<Disco> listaDiscos= new LinkedList<Disco>();

            //Inicio del Ciclo
            do
            {
                Console.WriteLine("Agregar Publicacion");
                //Nombre de la Publicacion
                Console.WriteLine("Nombre:");
                nombre= Console.ReadLine();

                //Precio de la Publicacion
                Console.WriteLine("Precio:");
                precio =float.Parse(Console.ReadLine());

                //Tipo de Publicacion
                Console.WriteLine("Tipo de Publicacion \n 1)Libro \n 2)Disco \n");
                tipoPublicacion = Convert.ToInt32(Console.ReadLine());

                if (tipoPublicacion == 1)
                {
                    //Numero de Paginas del Libro
                    Console.WriteLine("Numero de Paginas:");
                    numeroPaginas = Convert.ToInt32(Console.ReadLine());

                    //Año de Publicacion del Libro
                    Console.WriteLine("Año de publicacion:");
                    añoPublicacion= Convert.ToInt32(Console.ReadLine());

                    //Crear el objeto y agregarlo a la lista
                    Libro libro = new Libro(nombre, precio, numeroPaginas, añoPublicacion);
                    listaLibros.AddLast(libro);

                }
                else
                {
                    //Minutos del disco
                    Console.WriteLine("Duracion en Minutos:");
                    minutos=double.Parse(Console.ReadLine());   

                    //Crear el objeto y agregarlo a la lista
                    Disco disco= new Disco(nombre,precio,minutos);
                    listaDiscos.AddLast(disco);
                }

                Console.WriteLine("Continuar \n 1)Si \n 2)No");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion !=1) { bucleSalida = true; }


            } while (!bucleSalida);

            //Impresion de los datos
            Console.WriteLine("Libros:");
            foreach (Libro libro in listaLibros)
            { 
                Console.WriteLine("\n");
                libro.mostrarDatos();
            }
            Console.WriteLine("Discos:");
            foreach (Disco disco in listaDiscos)
            {
                Console.WriteLine("\n");
                disco.mostrarDatos();
            }

        }

        static void Ejercicio3()
        {
            Jornada jornada = Jornada.Matutina;
            
            int tipoJornada=1;
            //Nombre del Estudiante
            Console.WriteLine("Ingrese el Nombre del Estudiante:");
            string nombre_Estudiante=Console.ReadLine();

            //Direccion del Estudiante
            Console.WriteLine("Ingrese la Direccion del Estudiante:");
            string direccion_Estudiante = Console.ReadLine();

            //Numero de Cuenta del Estudiante
            Console.WriteLine("Ingrese el numero de cuenta del Estudiante:");
            int numeroCuenta_Estudiante = int.Parse(Console.ReadLine());

            //Indice Academico del Estudiante
            Console.WriteLine("Ingrese el indice academico del Estudiante:");
            int indiceAcademico_Estudiante = int.Parse(Console.ReadLine());

            //Creacion del Objeto Estudiante
            Estudiante estudiante = new Estudiante(nombre_Estudiante,direccion_Estudiante,numeroCuenta_Estudiante,indiceAcademico_Estudiante);

            //Nombre del Profesor
            Console.WriteLine("Ingrese el Nombre del Profesor:");
            string nombre_Profesor = Console.ReadLine();

            //Direccion del Profesor
            Console.WriteLine("Ingrese la Direccion del Profesor:");
            string direccion_Profesor = Console.ReadLine();

            //Numero de Cuenta del Profesor
            Console.WriteLine("Ingrese el numero de empleado del Profesor:");
            int numeroEmpleado_Profesor = int.Parse(Console.ReadLine());

            //Tipo de Jornada del Profesor
            Console.WriteLine("Seleccione el tipo de Jornada del Profesor \n1)Matutina \n2)Vespertina");
            tipoJornada = int.Parse(Console.ReadLine());
            if (tipoJornada == 1)
            {
                jornada = Jornada.Matutina;

            }
            else
            {
                jornada = Jornada.Vespertina;

            }
            Profesor profesor = new Profesor(nombre_Profesor, direccion_Profesor, numeroEmpleado_Profesor,jornada);

            Console.WriteLine("En el raro caso de que ambos se esten diviertiendo esto estara pasando\n");
            Console.Write("Estudiante:");
            estudiante.divertirse();
            Console.Write("\nProfesor:");
            profesor.divertirse();
            
            Console.WriteLine("\nDatos del Estudiante:");
            estudiante.mostrarDatos();
            Console.WriteLine("\nDatos del Profesor:");
            profesor.mostrarDatos();
        }






        static void Ejercicio4()
        {
            Console.WriteLine("Hola Mundo");
        }
        static void Ejercicio5()
        {
            Console.WriteLine("Hola Mundo");
        }
        static void Ejercicio6()
        {
            Console.WriteLine("Hola Mundo");
        }
        static void Ejercicio7()
        {
            Console.WriteLine("Hola Mundo");
        }
       

    }


}
