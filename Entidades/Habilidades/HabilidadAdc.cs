using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Habilidades
{
    public class HabilidadAdc : Habilidad
    {
        public void AumentarDañoDiez(Jugador jugador) // Codigo - 3
        {
            jugador.ChampAsociado.DañoAtaque += (jugador.ChampAsociado.DañoAtaque * 10) / 100;
        }
        public void ReducirDañoAdcEnemigo(Jugador jugador) // Codigo - 4
        {
            jugador.ChampAsociado.DañoAtaque -= 20;
        }
    }
}