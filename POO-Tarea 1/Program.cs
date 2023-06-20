using POO_Tarea_1.Ejercicio_4;
using POO_Tarea_1.Ejercicio_5;
using POO_Tarea_1.Ejercicio_6;
using System;
using System.Collections.Generic;
using System.ComponentModel;

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
                Console.WriteLine("1)Ejercicio 1\n2)Ejercicio 2\n3)Ejercicio 3\n4)Ejercicio 4\n5)Ejercicio 5\n6)Ejercicio 6\n7)Ejercicio 7");
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
            Console.WriteLine("Ingrese el largo del radio del Circulo");
            circulo.radio = Convert.ToInt32(Console.ReadLine());

            //Area y centro del cuadrado
            Console.WriteLine("\nCuadrado:");
            cuadrado.mostrarCentro();
            cuadrado.mostrarArea();

            //Area y centro del circulo
            Console.WriteLine("\nCirculo:");
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
            //Declaracion de variables necesarias
            int centroX_Cuadrado=1, centroY_Cuadrado=1,ladoCuadrado = 1;
            int centroX_Circulo=2, centroY_Circulo=2, radioCirculo=2;

            //Declaracion del centro del cuadrado
            Console.WriteLine("Ingrese la coordenada x del centro del Cuadrado");
            centroX_Cuadrado= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del centro del Cuadrado");
            centroY_Cuadrado = Convert.ToInt32(Console.ReadLine());

            //Largo del Lado del Cuadrado
            Console.WriteLine("Ingrese el largo de un lado del cuadrado");
            ladoCuadrado= Convert.ToInt32(Console.ReadLine());

            //Declaracion del centro del circulo
            Console.WriteLine("Ingrese la coordenada x del centro del Circulo");
            centroX_Circulo= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la coordenada y del centro del Circulo");
            centroY_Circulo= Convert.ToInt32(Console.ReadLine());

            //Radio del Circulo
            Console.WriteLine("Ingrese el largo del radio del Circulo");
            radioCirculo= Convert.ToInt32(Console.ReadLine());

            //Creacion del los Objeto Cuadrado y Circulo
            Ejercicio4_Cuadrado cuadrado = new Ejercicio4_Cuadrado(centroX_Cuadrado, centroY_Cuadrado, ladoCuadrado);
            Ejercicio4_Circulo circulo = new Ejercicio4_Circulo(centroX_Circulo, centroY_Circulo, radioCirculo);

            //Area y centro del cuadrado
            Console.WriteLine("\nCuadrado:");
            cuadrado.mostrarCentro();
            cuadrado.mostrarArea();

            //Area y centro del circulo
            Console.WriteLine("\nCirculo:");
            circulo.mostrarCentro();
            circulo.mostrarArea();

           
            
        }

        static void Ejercicio5()
        {
            //Constructores con Todos los Parametros
            Ejercicio5_Disco disco1 = new Ejercicio5_Disco("Titulo del disco", 10.99f, 45.0);
            Ejercicio5_Libro libro1 = new Ejercicio5_Libro("Titulo del libro", 12.99f, 300, 2021);

            //Constructores sin ningun parametro
            Ejercicio5_Disco disco2 = new Ejercicio5_Disco();
            Ejercicio5_Libro libro2 = new Ejercicio5_Libro();

            Console.WriteLine("Datos de los constructores con Todos los Parametros");
            disco1.mostrarDatos();
            Console.WriteLine("\n");
            libro1 .mostrarDatos();

            Console.WriteLine("\n Datos de los constructores con sin ningun parametro");
            disco2.mostrarDatos();
            Console.WriteLine("\n");
            libro2.mostrarDatos();

        }


        static void Ejercicio6()
        {
            Camion camion1 = new Camion("Mercedes", "B2-101", "Rojo", 426, 5000, 7912, 800);
            Console.WriteLine("Ejemplo de los datos de un camion");
            camion1.imprimirDatos();

            Console.WriteLine("\n\nIngrese la Marca del Camion");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese el Modelo del Camion");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese el Color del Camion \n1)Rojo\n2)Verde\n3)Azul\n4)Negro\n5)Amarillo\n6)Gris");
            string color=Console.ReadLine();    
            

            Console.WriteLine("Ingrese el numero de motor");
            int numMotor = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la potencia del motor");
            double potenciaMotor = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de chassis");
            int numeroChassis = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el peso del chassis (kg)");
            double pesoChassis = double.Parse(Console.ReadLine());

            Camion camion2 = new Camion(marca, modelo, color, numMotor, potenciaMotor, numeroChassis, pesoChassis);
            Console.WriteLine("\nDatos del Camion\n");
            camion2.imprimirDatos();
        }
        static void Ejercicio7()
        {
            Ejercicio7_Camion camion1 = new Ejercicio7_Camion("Motorola","PA-065",Color.Gris,366,420,720,96);
            Console.WriteLine("Ejemplo de los datos de un camion");
            camion1.imprimirDatos();

            Console.WriteLine("\n\nIngrese la Marca del Camion");
            string marca=Console.ReadLine();
            Console.WriteLine("Ingrese el Modelo del Camion");
            string modelo=Console.ReadLine();
            Console.WriteLine("Ingrese el Color del Camion \n1)Rojo\n2)Verde\n3)Azul\n4)Negro\n5)Amarillo\n6)Gris");
            int opcion=int.Parse(Console.ReadLine());
            //Valor por defecto Color
            Color color=Color.Rojo;
            switch (opcion)
            {
                case 1:
                    color=Color.Rojo; 
                    break;
                case 2:
                    color=Color.Verde;
                    break;
                case 3:
                    color=Color.Azul;
                    break;
                case 4:
                    color=Color.Negro;
                    break;
                case 5:
                    color = Color.Amarillo;
                    break;
                case 6:
                    color= Color.Gris;
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

            Console.WriteLine("Ingrese el numero de motor");
            int numMotor=int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la potencia del motor");
            double potenciaMotor=double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de chassis");
            int numeroChassis = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el peso del chassis (kg)");
            double pesoChassis = double.Parse(Console.ReadLine());

            Ejercicio7_Camion camion2 = new Ejercicio7_Camion(marca, modelo, color, numMotor, potenciaMotor, numeroChassis, pesoChassis);
            Console.WriteLine("\nDatos del Camion\n");
            camion2.imprimirDatos();

        }

        

       

    }


}
