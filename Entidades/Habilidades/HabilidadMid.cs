using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Habilidades
{
    public class HabilidadMid : Habilidad
    {
        public void AumentarPorcientoDaño(Jugador jugador) // Codigo - 7
        {
            jugador.ChampAsociado.DañoAtaque += (jugador.ChampAsociado.DañoAtaque * 5) / 100;
        }

        public void ReduccionDañoMidEnemigo(Jugador jugador) // Codigo - 8
        {
            jugador.ChampAsociado.DañoAtaque -= 25;
        }
    }
}
