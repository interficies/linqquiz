using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Jugador
    {
        public int Id { get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Posicion { get; }
        public Jugador Capitan { get; set; }
        public DateTime FechaAlta { get; }
        public int Salario { get; }
        public Equipo Equipo { get; }
        public double Altura { get; }

       private Jugador(int id, string nombre, string apellido, string posicion, Jugador capitan, DateTime fechaAlta, int salario, Equipo equipo, double altura)
            : this (id,nombre,apellido,posicion,fechaAlta,salario,equipo,altura)
        {
            Capitan = capitan;
        }

        private Jugador(int id, string nombre, string apellido, string posicion, DateTime fechaAlta, int salario, Equipo equipo, double altura)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Posicion = posicion;
            Capitan = this;
            FechaAlta = fechaAlta;
            Salario = salario;
            Equipo = equipo;
            Altura = altura;
        }

        public static Jugador CreateJugador(int id, string nombre, string apellido, string posicion, Jugador capitan, DateTime fechaAlta, int salario, Equipo equipo, double altura)
        {

            return new Jugador(id, nombre, apellido, posicion, capitan, fechaAlta, salario, equipo, altura);
        }

        public static Jugador CreateJugador(int id, string nombre, string apellido, string posicion, DateTime fechaAlta, int salario, Equipo equipo, double altura)
        {

            return new Jugador(id, nombre, apellido, posicion,  fechaAlta, salario, equipo, altura);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("ID: {0} Nombre: {1} Apellidos: {2} Posición: {3} " 
                + " FechaAlta: {4} Salario: {5} Equipo: {6} Altura: {7}" ,Id,Nombre,Apellido,Posicion,
                FechaAlta,Salario,null!=Equipo?Equipo.Nombre:"Ninguno",Altura);
            return sb.ToString();
        }
    }
}
