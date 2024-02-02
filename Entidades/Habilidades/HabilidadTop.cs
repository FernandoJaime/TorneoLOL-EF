using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Habilidades
{
    public class HabilidadTop : Habilidad
    {
        public void DañarTopEnemigo(Jugador jugador) // Codigo - 11
        {
            jugador.ChampAsociado.PuntosDeVida -= 200;

        }

        public void CurarASoporte(Jugador jugador) // Codigo - 12
        {
            jugador.ChampAsociado.PuntosDeVida += 100;
        }
    }
}
