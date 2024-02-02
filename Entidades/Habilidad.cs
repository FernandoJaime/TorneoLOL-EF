using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habilidad
    {
        // Declaracion de propiedades.
        public int IdHabilidad { get; set; }
        public int CodigoHabilidad { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public void CuracionGeneral(Equipo equipo) // Codigo - 1
        {
            for(int i = 0; i< equipo.ListaJugadoresDeEquipo.Count;i++)
            {
                var jugador = equipo.ListaJugadoresDeEquipo[i];
                jugador.ChampAsociado.PuntosDeVida += 50;
            }
        }
        public override string ToString()
        {
            return this.Nombre;
        }
        public void DañoGeneral(Equipo equipo) // Codigo - 2
        {
            for (int i = 0; i < equipo.ListaJugadoresDeEquipo.Count; i++)
            {
                var jugador = equipo.ListaJugadoresDeEquipo[i];
                jugador.ChampAsociado.PuntosDeVida -= 50;
            }
        } 
    }
}