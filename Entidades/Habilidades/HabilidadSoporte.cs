using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Habilidades
{
    public class HabilidadSoporte : Habilidad
    {
        public void CurarAdcAliado(Jugador jugador) // Codigo - 9
        {
            jugador.ChampAsociado.PuntosDeVida += 100;
        }

        public void ReduccionDeDañoGeneral(Equipo equipito) // Codigo - 10
        {
            for(int i = 0; i< equipito.ListaJugadoresDeEquipo.Count; i++)
            {
                var jugador = equipito.ListaJugadoresDeEquipo[i];
                jugador.ChampAsociado.DañoAtaque -= 20;
            }
        }
    }
}