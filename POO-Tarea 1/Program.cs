using System;
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
            Circulo circulo = new Circulo();
            circulo.radio = a;

            Console.WriteLine(circulo.area);
            Console.ReadLine(); 
        }
    }
}
