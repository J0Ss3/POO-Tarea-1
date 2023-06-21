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
namespace POO_Tarea_1.Ejercicio_6
{
    enum Color
    {
        Rojo,
        Verde,
        Azul,
        Negro,
        Amarillo,
        Gris
       
    }
    internal class Ejercicio7_Camion
    {
        private string _marca;
        private string _modelo;
        private Color _color;
        private Motor _motor;
        private Chassis _chassis;

        public Ejercicio7_Camion(string Marca,string Modelo,Color colorCamion,int numMotor,double potencia,int numeroChassis,double pesoChassis)
        {
            _motor = new Motor();
            _chassis= new Chassis();
            this._marca = Marca;
            this._modelo = Modelo;
            this._color = colorCamion;
            _motor.numero = numMotor;
            _motor.potencia= potencia;
            _chassis.numero = numeroChassis;
            _chassis.peso= pesoChassis;
        }
        public void imprimirDatos()
        {
            Console.Write("Marca: {0} \nModelo: {1} \n{2} \n{3} \nColor:{4}", _marca, _modelo, _motor.ToString(), _chassis.ToString(),_color);
        }

    }
}
