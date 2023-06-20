using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


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
                        break
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
            Console.WriteLine("Hola Mundo");
        }

    }
}
