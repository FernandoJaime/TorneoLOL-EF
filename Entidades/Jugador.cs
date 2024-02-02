using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        // Declaracion de propiedades.
        public int IdJugador {get;set;}
        public string Nickname { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public int Edad { get; set; }
        private string experiencia {  get; set; }
        public string Experiencia { get => experiencia; set { experiencia = value; CalculoHabilidad(); } }
        public int VecesMVP { get; set; }
        public int Habilidad { get; set; }
        public int IdChampAsociado { get; set; }
        public Campeon ChampAsociado { get; set; } = new Campeon();
        public int? IdEquipoAsociado {get;set;}
        public Equipo EquipoAsociado { get; set; }
        public bool TieneEquipo
        {
            get { if (EquipoAsociado == null) return false; else return true; }
        }
        public override string ToString()
        {
          return Nickname;
        }

        // Metodo para calcular la habilidad del jugador dependiendo de su experiencia.
        public void CalculoHabilidad()
        {
            Random num = new Random();
            switch (this.experiencia)
            {
                case "Experto":
                    Habilidad = num.Next(75, 100);
                    break;
                case "Veterano":
                    Habilidad = num.Next(50, 75);
                    break;
                case "Profesional":
                    Habilidad = num.Next(25, 50);
                    break;
                case "Novato":
                    Habilidad = num.Next(5, 25);
                    break;
                default:
                    Habilidad = 0;
                    break;
            }
        }
    }
}