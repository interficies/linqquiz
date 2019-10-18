using System;
using Modelo;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equipos :");
            foreach (var e in LigaDAO.Instance.Equipos)
            {
                Console.WriteLine("\t" + e);
            }

            Console.WriteLine("Jugadores:");
            foreach (var j in LigaDAO.Instance.Jugadores)
            {
                Console.WriteLine("\t" + j);
            }

            Console.WriteLine("Partidos:");
            foreach (var p in LigaDAO.Instance.Partidos)
            {
                Console.WriteLine("\t" + p);
            }

            Console.ReadLine();

        }
    }
}
