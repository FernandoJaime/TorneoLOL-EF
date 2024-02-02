using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladoraPartidas
    {
        private static ControladoraPartidas instancia; // Aplicamos Singleton.

        public static ControladoraPartidas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraPartidas();
                }
                return instancia;
            }
        }

        // ------------------------------------------------------- RECUPERAR --------------------------------------------------------------
        public IReadOnlyCollection<Habilidad> RecuperarHabilidadJungla()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Habilidades.ToList().FindAll(x => (x.CodigoHabilidad == 1 || x.CodigoHabilidad == 2 || x.CodigoHabilidad == 5 || x.CodigoHabilidad == 6));
            }
        }
        public IReadOnlyCollection<Habilidad> RecuperarHabilidadAdc()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Habilidades.ToList().FindAll(x => (x.CodigoHabilidad == 1 || x.CodigoHabilidad == 2 || x.CodigoHabilidad == 3 || x.CodigoHabilidad == 4));
            }
        }
        public IReadOnlyCollection<Habilidad> RecuperarHabilidadTop()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Habilidades.ToList().FindAll(x => (x.CodigoHabilidad == 1 || x.CodigoHabilidad == 2 || x.CodigoHabilidad == 11 || x.CodigoHabilidad == 12));
            } 
        }
        public IReadOnlyCollection<Habilidad> RecuperarHabilidadMid()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Habilidades.ToList().FindAll(x => (x.CodigoHabilidad == 1 || x.CodigoHabilidad == 2 || x.CodigoHabilidad == 7 || x.CodigoHabilidad == 8));
            }
        }
        public IReadOnlyCollection<Habilidad> RecuperarHabilidadSoporte()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Habilidades.ToList().FindAll(x => (x.CodigoHabilidad == 1 || x.CodigoHabilidad == 2 || x.CodigoHabilidad == 9 || x.CodigoHabilidad == 10));
            }
        }
        public IReadOnlyCollection<Partida> RecuperarPartidasConDetalles()
        {
            try
            {
                using (var contexto = new Contexto())
                {
                    var partidas = contexto.Partidas
                    .Include(p => p.Equipo_1)
                        .ThenInclude(e => e.ListaJugadoresDeEquipo)
                            .ThenInclude(j => j.ChampAsociado)
                                .ThenInclude(c => c.RolChamp)
                    .Include(p => p.Equipo_2)
                        .ThenInclude(e => e.ListaJugadoresDeEquipo)
                            .ThenInclude(j => j.ChampAsociado)
                                .ThenInclude(c => c.RolChamp)
                    .Include(p => p.JugadorMVP)
                    .Include(p => p.Ganador)
                    .ToList()
                    .AsReadOnly();

                    return partidas;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IReadOnlyCollection<Partida> RecuperarPartidasDeEquipo(Equipo equipo)
        {
            using (var contexto = new Contexto())
            {
                contexto.Jugadores.Include(j => j.ChampAsociado).ThenInclude(c => c.RolChamp).ToList();
                return contexto.Partidas
                    .Include(p => p.Equipo_1)
                    .Include(p => p.Equipo_2)
                    .Where(p => p.IdEquipo1 == equipo.IdEquipo || p.IdEquipo2 == equipo.IdEquipo)
                    .ToList()
                    .AsReadOnly();
            }
        }

        // ------------------------------------------------------- AGREGAR --------------------------------------------------------------
        public string AgregarPartida (Partida partidaAagregar) // Método para agregar partidas
        {
            try
            {
                using (var contexto = new Contexto())
                {
                    // contexto.Partidas.Add(partidaAagregar);
                    contexto.Entry(partidaAagregar).State = EntityState.Added;
                    // Actualizar objetos si ya existen en el contexto
                    contexto.Entry(partidaAagregar.Equipo_1).State = EntityState.Modified;
                    contexto.Entry(partidaAagregar.Equipo_2).State = EntityState.Modified;
                    contexto.Entry(partidaAagregar.JugadorMVP).State = EntityState.Modified;
                    contexto.Entry(partidaAagregar.Ganador).State = EntityState.Modified;

                    contexto.SaveChanges();
                    return "La partida terminada y registrada!";
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //----------------------------------------------------------ACTUALIZAR HABILIDADES-----------------------------------------------
        public void ActualizarHabilidades(List<Jugador> JugadoresDePartida)
        {
            using (var contexto = new Contexto())
            {
                foreach (var Jugador in JugadoresDePartida)
                {
                    contexto.Jugadores.Update(Jugador);
                }
            }
        }
      
    }
}