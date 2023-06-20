using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    internal class Camion
    {
        private string _marca;
        private string _modelo;
        private Color _color;
        private Motor _motor;
        private Chassis _chassis;

        public Camion(string Marca,string Modelo,Color colorCamion,int numMotor,double potencia,int numeroChassis,double pesoChassis)
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
        public void mostrarDatos()
        {
            Console.Write("Marca: {0} \nModelo: {1} \n{2} \n{3} \nColor:{4}", _marca, _modelo, _motor.ToString(), _chassis.ToString(),_color);
        }

    }
}
