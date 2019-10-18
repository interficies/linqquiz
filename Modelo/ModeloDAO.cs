using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    using System.Collections.Generic;



    public class LigaDAO
    {

        static object _lock = new object();

        private static LigaDAO _instance;
        public static LigaDAO Instance
        {

            get
            {

                lock (_lock)
                {
                    if (null == _instance)
                    {
                        _instance = new LigaDAO();
                    }

                }

                return _instance;
            }

        }


        

        public List<Equipo> Equipos { get; }
        public List<Jugador> Jugadores { get; }
        public List<Partido> Partidos { get; }

        private LigaDAO()
        {

            /***
             * Equipos
             * 
             *
             */

            //INSERT INTO `equipo` VALUES 
            //(1,"Regal Barcelona","Barcelona","http://www.fcbarcelona.com/web/index_idiomes.html",10),
            //(2,"Real Madrid","Madrid","http://www.realmadrid.com/cs/Satellite/es/1193040472450/SubhomeEquipo/Baloncesto.htm",9),
            //(3,"P.E. Valencia","Valencia","http://www.valenciabasket.com/",11),
            //(4,"Caja Laboral","Vitoria","http://www.baskonia.com/prehomes/prehomes.asp?id_prehome=69",22),
            //(5,"Gran Canaria","Las Palmas","http://www.acb.com/club.php?id=CLA",14),
            //(6,"CAI Zaragoza","Zaragoza","http://basketzaragoza.net/",23);



            Equipos = new List<Equipo>();
            Equipos.Add(Equipo.CreateEquipo(1, "Regal Barcelona", "Barcelona", "http://www.fcbarcelona.com/web/index_idiomes.html", 10));
            Equipos.Add(Equipo.CreateEquipo(2, "Real Madrid", "Madrid", "http://www.realmadrid.com/cs/Satellite/es/1193040472450/SubhomeEquipo/Baloncesto.htm", 9));
            Equipos.Add(Equipo.CreateEquipo(3, "P.E. Valencia", "Valencia", "http://www.valenciabasket.com/", 11));
            Equipos.Add(Equipo.CreateEquipo(4, "Caja Laboral", "Vitoria", "http://www.baskonia.com/prehomes/prehomes.asp?id_prehome=69", 22));
            Equipos.Add(Equipo.CreateEquipo(5, "Gran Canaria", "Las Palmas", "http://www.acb.com/club.php?id=CLA", 14));
            Equipos.Add(Equipo.CreateEquipo(6, "CAI Zaragoza", "Zaragoza", "http://basketzaragoza.net/", 23));

            //INSERT INTO `jugador` VALUES 
            //*(1,"Juan Carlos","Navarro","escolta",1,"2010-01-10 00:00:00",130000,1,"1.96"),
            //*(2,"Felipe","Reyes","Pivot",2,"2009-02-20 00:00:00",132000,2,"2.04"),
            //(3,"Victor","Claver","Alero",3,"2009-03-08 00:00:00",99000,3,"2.08"),
            //(4,"Rafa ","Martinez","ala-pivot",4,"2010-11-11 00:00:00",51000,3,"1.91"),
            //(5,"Fernando","San Emeterio","Alero",6,"2008-09-22 00:00:00",60000,4,"1.99"),
            //(6,"Mirza","Teletovic","Pivot",6,"2010-05-13 00:00:00",77000,4,"2.06"),
            //(7,"Sergio ","Llull","Escolta",2,"2011-10-29 00:00:00",100000,2,"1.90"),
            //(8,"Victor ","Sada","Base",1,"2012-01-01 00:00:00",80000,1,"1.92"),
            //(9,"Carlos","Suarez","Alero",2,"2011-02-19 00:00:00",66000,2,"2.03"),
            //(10,"Xavi ","Rey","Pivot",14,"2008-10-12 00:00:00",104500,5,"2.09"),
            //(11,"Carlos ","Cabezas","Base",13,"2012-01-21 00:00:00",105000,6,"1.86"),
            //(12,"Pablo ","Aguilar","Alero",13,"2011-06-14 00:00:00",51700,6,"2.03"),
            //(13,"Rafa","Hettsheimeir","Pivot",13,"2008-04-15 00:00:00",58300,6,"2.08"),
            //(14,"Sitapha","Savané","Pivot",14,"2011-07-27 00:00:00",66000,5,"2.01"),
            //(15,"anonimo","anonimo","Ala-pivot",2,"2012-01-01 00:00:00",4000,3,"2.00"),
            

            /**
             * 
             * Jugadores
             * 
             */

            Jugadores = new List<Jugador>();

            //1
            Jugadores.Add( Jugador.CreateJugador(1, "Juan Carlos", "Navarro", "escolta", null, DateTime.Parse("2010-01-10 00:00:00"), 130000, Equipos[0], 1.96));
            Equipos[0].Jugadores.Add(Jugadores[0]);

            //2
            Jugadores.Add( Jugador.CreateJugador(2, "Felipe", "Reyes", "Pivot", DateTime.Parse("2009-02-20 00:00:00"), 132000, Equipos[1], 2.04));
            Equipos[1].Jugadores.Add(Jugadores[1]);

            //(3,"Victor","Claver","Alero",3,"2009-03-08 00:00:00",99000,3,"2.08"),

            Jugadores.Add(Jugador.CreateJugador(3, "Victor", "Claver", "Alero",  DateTime.Parse("2009-03-08 00:00:00"), 99000, Equipos[2], 2.08));
            Equipos[2].Jugadores.Add(Jugadores[2]);

            //(4,"Rafa ","Martinez","ala-pivot",4,"2010-11-11 00:00:00",51000,3,"1.91"),

            Jugadores.Add(Jugador.CreateJugador( 4, "Rafa ", "Martinez", "ala-pivot", DateTime.Parse("2010-11-11 00:00:00"), 51000, Equipos[2], 1.91));
            Equipos[2].Jugadores.Add(Jugadores[3]);

            //(5,"Fernando","San Emeterio","Alero",6,"2008-09-22 00:00:00",60000,4,"1.99"), El 6 encara no existeix
            Jugadores.Add(Jugador.CreateJugador(5, "Fernando", "San Emeterio", "Alero", null, DateTime.Parse("2008-09-22 00:00:00"), 60000, Equipos[4], 1.99));
            Equipos[3].Jugadores.Add(Jugadores[4]);

            //(6,"Mirza","Teletovic","Pivot",6,"2010-05-13 00:00:00",77000,4,"2.06"),

            Jugadores.Add(Jugador.CreateJugador(6, "Mirza", "Teletovic", "Pivot" ,DateTime.Parse("2010-05-13 00:00:00"), 77000, Equipos[3], 2.06));
            Equipos[3].Jugadores.Add(Jugadores[5]);
            Jugadores[4].Capitan = Jugadores[5];

            //(7,"Sergio ","Llull","Escolta",2,"2011-10-29 00:00:00",100000,2,"1.90"),
            Jugadores.Add(Jugador.CreateJugador(7, "Sergio ", "Llull", "Escolta", Jugadores[1], DateTime.Parse("2011-10-29 00:00:00"), 100000, Equipos[1], 1.90));
            Equipos[1].Jugadores.Add(Jugadores[6]);

            //(8,"Victor ","Sada","Base",1,"2012-01-01 00:00:00",80000,1,"1.92"),
            Jugadores.Add(Jugador.CreateJugador(8, "Victor ", "Sada", "Base", Jugadores[0],  DateTime.Parse("2012-01-01 00:00:00"), 80000, Equipos[0], 1.92));
            Equipos[0].Jugadores.Add(Jugadores[7]);

            //(9,"Carlos","Suarez","Alero",2,"2011-02-19 00:00:00",66000,2,"2.03"),
            Jugadores.Add(Jugador.CreateJugador(8, "Victor ", "Sada", "Base", Jugadores[0],  DateTime.Parse("2012-01-01 00:00:00"), 80000, Equipos[0], 1.92));
            Equipos[1].Jugadores.Add(Jugadores[8]);

            //(10,"Xavi ","Rey","Pivot",14,"2008-10-12 00:00:00",104500,5,"2.09"),
            Jugadores.Add(Jugador.CreateJugador(10, "Xavi ", "Rey", "Pivot", null,DateTime.Parse("2008-10-12 00:00:00"), 104500, Equipos[4], 2.09));
            Equipos[4].Jugadores.Add(Jugadores[9]);

            //(11,"Carlos ","Cabezas","Base",13,"2012-01-21 00:00:00",105000,6,"1.86"),
            Jugadores.Add(Jugador.CreateJugador(11, "Carlos ", "Cabezas", "Base", null, DateTime.Parse("2012-01-21 00:00:00"), 105000, Equipos[5], 1.86));
            Equipos[5].Jugadores.Add(Jugadores[10]);

            //(12,"Pablo ","Aguilar","Alero",13,"2011-06-14 00:00:00",51700,6,"2.03"),
            Jugadores.Add(Jugador.CreateJugador(12, "Pablo ", "Aguilar", "Alero", null, DateTime.Parse("2011-06-14 00:00:00"), 51700, Equipos[5], 2.03));
            Equipos[5].Jugadores.Add(Jugadores[11]);
            
            //(13,"Rafa","Hettsheimeir","Pivot",13,"2008-04-15 00:00:00",58300,6,"2.08"),
            Jugadores.Add(Jugador.CreateJugador(13, "Rafa", "Hettsheimeir", "Pivot", DateTime.Parse("2008-04-15 00:00:00"), 58300, Equipos[5], 2.08));
            Equipos[5].Jugadores.Add(Jugadores[12]);

            //(14,"Sitapha","Savané","Pivot",14,"2011-07-27 00:00:00",66000,5,"2.01"),
            Jugadores.Add(Jugador.CreateJugador(14, "Sitapha", "Savané", "Pivot", DateTime.Parse("2011-07-27 00:00:00"), 66000, Equipos[4], 2.01));
            Equipos[4].Jugadores.Add(Jugadores[13]);
            Jugadores[10].Capitan = Jugadores[13];
            Jugadores[11].Capitan = Jugadores[13];

            //(15,"anonimo","anonimo","Ala-pivot",2,"2012-01-01 00:00:00",4000,3,"2.00"),
            Jugadores.Add(Jugador.CreateJugador(15,"anonimo","anonimo","Ala-pivot",Jugadores[1],DateTime.Parse("2012-01-01 00:00:00"),4000,Equipos[2],2.00));
            Equipos[4].Jugadores.Add(Jugadores[14]);
            Jugadores[9].Capitan = Jugadores[14];

            /**
             * 
             * Partidos
             * 
             */

            Partidos = new List<Partido>();

            //(1,1,2,'100-100','2011-10-10','4\r'),
            Partidos.Add(Partido.CreatePartido(1, Equipos[0], Equipos[1], "100-100", DateTime.Parse("2011-10-10"),"4"));

            //(2,2,3,'90-91','2011-11-17','5\r'),
            Partidos.Add(Partido.CreatePartido(2, Equipos[1], Equipos[2], "90-91", DateTime.Parse("2011-11-17"), "5"));

            //(3,3,4,'88-77','2011-11-23','6\r'),
            Partidos.Add(Partido.CreatePartido(3, Equipos[3], Equipos[4], "88-77", DateTime.Parse("2011-11-23"), "6"));

            //(4,1,6,'66-78','2011-11-30','6\r'),
            Partidos.Add(Partido.CreatePartido(4, Equipos[0], Equipos[5], "66-78", DateTime.Parse("2011-11-30"), "6"));

            //(5,2,4,'90-90','2012-01-12','7\r'),
            Partidos.Add(Partido.CreatePartido(5, Equipos[1], Equipos[3], "90-90", DateTime.Parse("2012-01-12"), "7"));
            
            //(6,4,5,'79-83','2012-01-19','3\r'),
            Partidos.Add(Partido.CreatePartido(6, Equipos[3], Equipos[4], "79-83", DateTime.Parse("2012-01-19"), "3"));

            //(7,3,6,'91-88','2012-02-22','3\r'),
            Partidos.Add(Partido.CreatePartido(7, Equipos[2], Equipos[5], "91-88", DateTime.Parse("2012-02-22"), "3"));

            //(8,5,4,'90-66','2012-04-27','2\r'),
            Partidos.Add(Partido.CreatePartido(8, Equipos[4], Equipos[3], "90-66", DateTime.Parse("2012-04-27"), "2"));

            //(9,6,5,'110-70','2012-05-30','1'),
            Partidos.Add(Partido.CreatePartido(9, Equipos[5], Equipos[4], "100-70", DateTime.Parse("2012-05-30"), "1"));

            //(10,3,5,'88-77','2011-09-01','2');
            Partidos.Add(Partido.CreatePartido(10, Equipos[2], Equipos[4], "88-77", DateTime.Parse("2011-09-01"), "2"));

        }

    }
}

