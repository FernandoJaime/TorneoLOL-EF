using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Habilidades
{
    public class HabilidadJungla : Habilidad
    {
        public void DañarJunglaEnemigo(Jugador Jungla) // Codigo - 5
        {
            Jungla.ChampAsociado.PuntosDeVida -= 150;
        }

        public void Curarse(Jugador Jungla) // Codigo - 6
        {
            Jungla.ChampAsociado.PuntosDeVida += 100;
        }
    }
}
