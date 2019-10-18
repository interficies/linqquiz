using System;
using System.Collections.Generic;
using Modelo;
using System.Linq;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = LigaDAO.Instance.Equipos;
            List<Jugador> jugadores = LigaDAO.Instance.Jugadores;
            List<Partido> partidos = LigaDAO.Instance.Partidos;

            //Ejercicio 1

            Console.WriteLine("Equipos :");
            equipos.ForEach(Console.WriteLine);

            Console.WriteLine("Jugadores :");
            jugadores.ForEach(Console.WriteLine);

            Console.WriteLine("Partidos:");
            partidos.ForEach(Console.WriteLine);

            //Ejercicio 2



            Console.ReadLine();

        }
    }
}
