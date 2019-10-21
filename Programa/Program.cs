using System;
using System.Collections.Generic;
using Modelo;
using System.Linq;
using System.Text;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = LigaDAO.Instance.Equipos;
            List<Jugador> jugadores = LigaDAO.Instance.Jugadores;
            List<Partido> partidos = LigaDAO.Instance.Partidos;

            //Ejercicio 1.1

            Console.WriteLine("Equipos :");
            equipos.ForEach(Console.WriteLine);

            Console.WriteLine("Jugadores :");
            jugadores.ForEach(Console.WriteLine);

            Console.WriteLine("Partidos:");
            partidos.ForEach(Console.WriteLine);

            //Ejercicio 2.2
            
            Console.WriteLine("Muéstrame los jugadores del equipo Regal Barcelona Ciudad ordenados según su fecha de alta en el equipo");
            equipos.Where( e => e.Nombre == "Regal Barcelona").First().Jugadores.OrderBy(x=>x.FechaAlta).ToList().ForEach(Console.WriteLine);

            //Ejercicio 2.3
            Console.WriteLine("Ordena por Apellidos los jugadores del Gran Canaria");
            equipos.Where( e => e.Nombre == "Gran Canaria").First().Jugadores.OrderBy(x=>x.Apellido).ToList().ForEach(Console.WriteLine);

            //Ejercicio 2.4
            Console.WriteLine("¿Qué jugadores juegan de pivot en la liga? ");
            jugadores.Where((j)=> j.Posicion.ToUpper() == "PIVOT").ToList().ForEach(Console.WriteLine);

            //Ejercicio 3.1
            Console.WriteLine("¿Quien es el equipo que tiene un jugador con el salario más alto?");
            Console.WriteLine(jugadores.OrderBy( (j)=>-j.Salario).First().Equipo);

            //Ejercicio 3.2
            Console.WriteLine("¿Qué jugadores hay que midan más de dos metros?");
            var masDosMetros = from j in jugadores 
                               where j.Altura > 2
                               select j;
            masDosMetros.ToList().ForEach(Console.WriteLine);

            //Ejercicio 3.3
            Console.WriteLine("¿Quienes son los capitanes del equipo?");
            jugadores.Where( (j)=> j.Capitan?.Id == j.Id).ToList().ForEach(Console.WriteLine);

            //Ejercicio 
            Console.WriteLine("El rey me ha encomendado que elabore una lista de strings que incluya los nombres, apellidos y equipo al que pertenece cada jugador");
            List<string> listado = jugadores.Select( (Jugador j)=>
                 j.Nombre + " " + j.Apellido + " equipo: " + j.Equipo.Nombre
             ).ToList();
            listado.ForEach(Console.WriteLine);

            // Ejercicio 2.2
            Console.WriteLine("Me ha encargado también la ardua tarea de que le diga qué equipo ha sido el que más victorias ha tenido");

            Dictionary<Equipo,int> equipo_victorias = new Dictionary<Equipo, int>();

            equipos.ForEach( (e) =>  equipo_victorias[e] = 0);

            partidos.ForEach((p) =>{

                int local = 0;
                int visitante = 0;
                
                String[] resultados = p.Resultado.Split("-");

                if (resultados.Length == 2) 
                {
                    local = int.Parse(resultados[0]);
                    visitante = int.Parse(resultados[1]);
                }

                if (local > visitante){
                    equipo_victorias[p.Local]+=1;
                } 
                else if (visitante > local)
                {
                    equipo_victorias[p.Visitante]+=1;
                }

            } );

            foreach (var v in equipo_victorias)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Equipo: {0} victorias:{1}",v.Key.Nombre,v.Value);
                Console.WriteLine(sb.ToString());
            }
            
            Console.WriteLine(equipo_victorias.OrderBy( (e)=>-e.Value).First());
            
        }
    }
}
