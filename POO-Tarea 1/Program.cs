﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            ObjetoGeometrico objetoGeometrico = new ObjetoGeometrico();
            objetoGeometrico.centroY = a;
            Console.WriteLine(objetoGeometrico.centroY);
            Console.ReadLine(); 
        }
    }
}
