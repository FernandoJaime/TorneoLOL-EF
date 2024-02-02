using Entidades.Habilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        // Declaracion de propiedades.
        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public int PartidasJugadas { get; set; }
        public int Ganadas { get; set; }
        public int Perdidas { get; set; }
        public int Puntuacion { get; set; }
        public bool DadoDeBaja { get; set; }
        public List<Jugador> ListaJugadoresDeEquipo { get; set; } = new List<Jugador>();

        public override string ToString()
        {
            return Nombre;
        }

        public void EliminarEquipo()
        {
           // this.ListaJugadoresDeEquipo.ForEach(x => x.EquipoAsociado = null);
            ListaJugadoresDeEquipo.Clear();
            this.DadoDeBaja = true;
        }

        public void TransformaryAsignarHabilidades(Habilidad jungla, Habilidad adc, Habilidad sop, Habilidad mid, Habilidad top) // Transformo las habilidades que obtengo de la base de datos (Para poder utilizarlas dependiendo del rol)
        {
            try
            {
                foreach (var jugador in ListaJugadoresDeEquipo)
                {
                    switch (jugador.ChampAsociado.RolChamp.Nombre)
                    {
                        case "Jungla":
                            jugador.ChampAsociado.Habilidad = new HabilidadJungla() { Nombre = jungla.Nombre, IdHabilidad = jungla.IdHabilidad, CodigoHabilidad = jungla.CodigoHabilidad, Tipo = jungla.Tipo };
                            break;
                        case "Adc":
                            jugador.ChampAsociado.Habilidad = new HabilidadAdc() { Nombre = adc.Nombre, IdHabilidad = adc.IdHabilidad, CodigoHabilidad = adc.CodigoHabilidad, Tipo = adc.Tipo };
                            break;
                        case "Soporte":
                            jugador.ChampAsociado.Habilidad = new HabilidadSoporte() { Nombre = sop.Nombre, IdHabilidad = sop.IdHabilidad, CodigoHabilidad = sop.CodigoHabilidad, Tipo = sop.Tipo };
                            break;
                        case "Mid":
                            jugador.ChampAsociado.Habilidad = new HabilidadMid() { Nombre = mid.Nombre, IdHabilidad = mid.IdHabilidad, CodigoHabilidad = mid.CodigoHabilidad, Tipo = mid.Tipo };
                            break;
                        case "Top":
                            jugador.ChampAsociado.Habilidad = new HabilidadTop() { Nombre = top.Nombre, IdHabilidad = top.IdHabilidad, CodigoHabilidad = top.CodigoHabilidad, Tipo = top.Tipo };
                            break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Metodo para agregar jugadores al equipo.
        public void AgregarJugadores(Jugador top, Jugador mid, Jugador adc, Jugador suporte, Jugador jungla)
        {
            ListaJugadoresDeEquipo.AddRange(new List<Jugador> { top, mid, adc, suporte, jungla }); // Agrego los jugadores a la lista.
            ListaJugadoresDeEquipo.ForEach(x => x.EquipoAsociado = this);  
        }

        // Metodo dependiendo del rol, devuelve el jugador del equipo que tenga ese rol.
        public Jugador RetornarJugadordeseado(string RolDeseado)
        {
            var JugadorADevolver = new Jugador();
            switch (RolDeseado)
            {
                case "Jungla":
                    JugadorADevolver = ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Jungla");
                    break;
                case "Mid":
                    JugadorADevolver = ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Mid");
                    break;
                case "Soporte":
                    JugadorADevolver = ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Soporte");
                    break;
                case "Adc":
                    JugadorADevolver = ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Adc");
                    break;
                case "Top":
                    JugadorADevolver = ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Top");
                    break;
            }
            return JugadorADevolver;
        }

        // Metodo de busqueda dentro de la lista de jugadores del equipo si hay alguno con vida.
        public bool HayJugadoresConVida()
        {
            foreach (var item in ListaJugadoresDeEquipo)
            {
                if (!item.ChampAsociado.Estamuerto)
                {
                    return true;  // Si encuentra un jugador con vida, devuelve false.
                }
            }
            return false;  // Si no encuentra ningún jugador con vida, devuelve true.
        }
    }
}