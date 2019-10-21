using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Partido
    {
        public int Id { get; }
        public Equipo Local { get; }
        public Equipo Visitante { get; }
        public string Resultado { get; }
        public DateTime Fecha { get; }
        public string Arbitro { get; }

        private Partido(int id, Equipo local, Equipo visitante, string resultado, DateTime fecha, string arbitro)
        {
            Id = id;
            Local = local;
            Visitante = visitante;
            Resultado = resultado;
            Fecha = fecha;
            Arbitro = arbitro;
        }

        public static Partido CreatePartido(int id, Equipo local, Equipo visitante, string resultado, DateTime fecha, string arbitro)
        {
            return new Partido(id, local, visitante, resultado, fecha, arbitro);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("ID: {0}",Id);
            sb.AppendFormat(" Equipo Local: {0}", Local != null ? Local.Nombre : "---");
            sb.AppendFormat(" Equipo Visitante: {0}", Visitante != null ? Visitante.Nombre : "---");
            sb.AppendFormat(" Resultado: {0}", Resultado);
            sb.AppendFormat(" Fecha: {0}", Fecha);
            sb.AppendFormat(" Arbitro: {0}", Arbitro);

            return sb.ToString();
        }

    }
}
