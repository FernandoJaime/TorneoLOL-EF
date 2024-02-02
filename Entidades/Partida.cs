using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partida
    {
        // Declaracion de propiedades.
        public int IdPartida { get; set; }
        public int CodigoPartida { get; set; }
        public int IdEquipo1 { get; set; }
        public Equipo Equipo_1 { get; set; }
        public int IdEquipo2 { get; set; }
        public Equipo Equipo_2 { get; set; }
        public int Duracion { get; set; }
        public int IdJugadorMVP { get; set; }
        public Jugador JugadorMVP { get; set; }
        public int IdEquipoGanador { get; set; }
        public Equipo Ganador { get; set; }

        // Metodo para calcular el MVP de la partida segun el daño hecho.
        public Jugador CalculoMvp()
        {
            var MayorDañoE1 = Equipo_1.ListaJugadoresDeEquipo.Max(jugador => jugador.ChampAsociado.DañoTotal);
            var MayorDañoE2 = Equipo_2.ListaJugadoresDeEquipo.Max(jugador => jugador.ChampAsociado.DañoTotal);
            var JugadorconMayorDañoE1 = Equipo_1.ListaJugadoresDeEquipo.FirstOrDefault(jugador => jugador.ChampAsociado.DañoTotal == MayorDañoE1);
            var JugadorconMayorDañoE2 = Equipo_2.ListaJugadoresDeEquipo.FirstOrDefault(jugador => jugador.ChampAsociado.DañoTotal == MayorDañoE2);
            if (MayorDañoE1 > MayorDañoE2)
            {
                return JugadorconMayorDañoE1;
            }
            else if (MayorDañoE1 == MayorDañoE2)
            {
                Random random = new Random();
                int numero = random.Next(1, 2);
                if (numero == 1)
                {
                    return JugadorconMayorDañoE1;
                }
                return JugadorconMayorDañoE2;
            }
            return JugadorconMayorDañoE2;
        }

        public void SimularPartida()
        {

            Equipo_1.ListaJugadoresDeEquipo.ForEach(Jugador => Jugador.ChampAsociado.DañoTotal = 0);
            Equipo_2.ListaJugadoresDeEquipo.ForEach(Jugador => Jugador.ChampAsociado.DañoTotal = 0);

            Equipo_1.ListaJugadoresDeEquipo.ForEach(x => x.ChampAsociado.Estamuerto = false);
            Equipo_2.ListaJugadoresDeEquipo.ForEach(x => x.ChampAsociado.Estamuerto = false);

            do // do-while para que se repita el ciclo hasta que un equipo quede sin jugadores con vida.
            {
                // Ataques de Jungla (De los dos equipos).
                var Jugador = Equipo_1.RetornarJugadordeseado("Jungla");
                Jugador.ChampAsociado.LanzarHabilidad(Equipo_1, Equipo_2);
                Jugador.ChampAsociado.Atacar(Equipo_2, Jugador);

                var Jugador1 = Equipo_2.RetornarJugadordeseado("Jungla");
                Jugador1.ChampAsociado.LanzarHabilidad(Equipo_2, Equipo_1);
                Jugador1.ChampAsociado.Atacar(Equipo_1, Jugador1);

                //Ataques de MidLaners (De los dos equipos).
                var Jugador2 = Equipo_1.RetornarJugadordeseado("Mid");
                Jugador2.ChampAsociado.LanzarHabilidad(Equipo_1, Equipo_2);
                Jugador2.ChampAsociado.Atacar(Equipo_2, Jugador2);

                var Jugador3 = Equipo_2.RetornarJugadordeseado("Mid");
                Jugador3.ChampAsociado.LanzarHabilidad(Equipo_2, Equipo_1);
                Jugador3.ChampAsociado.Atacar(Equipo_1, Jugador3);

                // Ataque de TopLaners (de ambos equipos).
                var Jugador4 = Equipo_1.RetornarJugadordeseado("Top");
                Jugador4.ChampAsociado.LanzarHabilidad(Equipo_1, Equipo_2);
                Jugador4.ChampAsociado.Atacar(Equipo_2, Jugador4);

                var Jugador5 = Equipo_2.RetornarJugadordeseado("Top");
                Jugador5.ChampAsociado.LanzarHabilidad(Equipo_2, Equipo_1);
                Jugador5.ChampAsociado.Atacar(Equipo_1, Jugador5);

                // Ataque de Soportes (de ambos equipos).
                var Jugador6 = Equipo_1.RetornarJugadordeseado("Soporte");
                Jugador6.ChampAsociado.LanzarHabilidad(Equipo_1, Equipo_2);
                Jugador6.ChampAsociado.Atacar(Equipo_2, Jugador6);

                var Jugador7 = Equipo_2.RetornarJugadordeseado("Soporte");
                Jugador7.ChampAsociado.LanzarHabilidad(Equipo_2, Equipo_1);
                Jugador7.ChampAsociado.Atacar(Equipo_1, Jugador7);

                // Ataque de Adc (de ambos equipos).
                var Jugador8 = Equipo_1.RetornarJugadordeseado("Adc");
                Jugador8.ChampAsociado.LanzarHabilidad(Equipo_1, Equipo_2);
                Jugador8.ChampAsociado.Atacar(Equipo_2, Jugador8);

                var Jugador9 = Equipo_2.RetornarJugadordeseado("Adc");
                Jugador9.ChampAsociado.LanzarHabilidad(Equipo_2, Equipo_1);
                Jugador9.ChampAsociado.Atacar(Equipo_1, Jugador9);

            } while (Equipo_1.HayJugadoresConVida() && Equipo_2.HayJugadoresConVida());

            if (Equipo_1.HayJugadoresConVida())
            {
                Ganador = Equipo_1;
                Equipo_1.Puntuacion += 3;
                Equipo_1.Ganadas++;
                Equipo_2.Perdidas++;
            }
            else
            {
                Ganador = Equipo_2;
                Equipo_2.Puntuacion += 3;
                Equipo_2.Ganadas++;
                Equipo_1.Perdidas++;
            }

            JugadorMVP = CalculoMvp();
            JugadorMVP.VecesMVP++;
            Equipo_1.PartidasJugadas++;
            Equipo_2.PartidasJugadas++;
            Random random = new Random();
            int numero = random.Next(15, 60);
            Duracion = numero;
            int numero2 = random.Next(1, 500);
            CodigoPartida = numero2 ;
            Equipo_1.ListaJugadoresDeEquipo.ForEach(x => x.ChampAsociado.Habilidad = null);
            Equipo_2.ListaJugadoresDeEquipo.ForEach(x => x.ChampAsociado.Habilidad = null);
        }
    }
}
