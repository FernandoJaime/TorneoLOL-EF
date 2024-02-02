using Entidades.Habilidades;

namespace Entidades
{
    public class Campeon
    {
        // Declaracion de campos.
        private int VidaInicial { get; set; }
        private int DañoInicial { get; set; }

        // Declaracion de propiedades.
        public int IdCampeon { get; set; }
        public string Nombre { get; set; }
        public bool Estamuerto { get => calculomuerte(); set => calculomuerte(); }
        public int PuntosDeVida {get; set;}
        public int DañoAtaque {get; set;}
        public int DañoTotal { get; set;}
        public int IdRol {get; set;}
        public Rol RolChamp {get; set;} = new Rol();
        public int? IdHabilidad { get; set; }
        public Habilidad Habilidad { get; set; }
        public override string ToString()
        {
            return this.Nombre;
        }
        // Metodo para setear valores iniciales.
        public void AsignarValoresIniciales()
        {
            VidaInicial = this.PuntosDeVida;
            DañoInicial = this.DañoAtaque;
        }

        // Metodo para calcular si el campeon esta muerto y manejar la propiedad bool.
        private bool calculomuerte()
        {
            if (PuntosDeVida <= 0)
            {
                return true;
            }
            return false;
        }

        // Se encarga de atacar a un campeon enemigo segun su experiencia tiene mas daño.
        private void Ataque(Campeon CampeonAAtacar, Jugador jugador)
        {
            if (!calculomuerte())
            {
                if (DañoAtaque > 0)
                {
                    switch (jugador.Experiencia)
                    {
                        case "Experto":
                            CampeonAAtacar.PuntosDeVida -= (DañoAtaque + 20);
                            break;
                        case "Veterano":
                            CampeonAAtacar.PuntosDeVida -= (DañoAtaque + 15);
                            break;
                        case "Profesional":
                            CampeonAAtacar.PuntosDeVida -= (DañoAtaque + 10);
                            break;
                        case "Novato":
                            CampeonAAtacar.PuntosDeVida -= DañoAtaque;
                            break;
                    }
                    DañoTotal += this.DañoAtaque; // Sumo el daño total que hizo el campeon.
                }
            }
        }

        // Metodos para lanzar habilidades dependiendo del rol.
        public void LanzarHabilidad(Equipo Equipo_Aliado, Equipo Equipo_Enemigo)
        {
            if (!Estamuerto)
            {
                // Rol Jungla.
                if (Habilidad is HabilidadJungla habilidadjungla)
                {
                    switch (Habilidad.CodigoHabilidad)
                    {
                        case 1:
                            habilidadjungla.CuracionGeneral(Equipo_Aliado);
                            break;
                        case 2:
                            habilidadjungla.DañoGeneral(Equipo_Enemigo);
                            break;
                        case 5:
                            habilidadjungla.DañarJunglaEnemigo(Equipo_Enemigo.ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Jungla"));
                            break;
                        case 6:
                            habilidadjungla.Curarse(Equipo_Aliado.ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Jungla"));
                            break;
                    }
                }

                // Rol Adc.
                if (Habilidad is HabilidadAdc habilidadAdc)
                {
                    switch (Habilidad.CodigoHabilidad)
                    {
                        case 1:
                            habilidadAdc.CuracionGeneral(Equipo_Aliado);
                            break;
                        case 2:
                            habilidadAdc.DañoGeneral(Equipo_Enemigo);
                            break;
                        case 3:
                            habilidadAdc.AumentarDañoDiez(Equipo_Aliado.ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Adc"));
                            break;
                        case 4:
                            habilidadAdc.ReducirDañoAdcEnemigo(Equipo_Enemigo.ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Adc"));
                            break;
                    }
                }

                // Rol Mid.
                if (Habilidad is HabilidadMid habilidadmid)
                {
                    switch (Habilidad.CodigoHabilidad)
                    {
                        case 1:
                            habilidadmid.CuracionGeneral(Equipo_Aliado);
                            break;
                        case 2:
                            habilidadmid.DañoGeneral(Equipo_Enemigo);
                            break;
                        case 7:
                            habilidadmid.AumentarPorcientoDaño(Equipo_Aliado.ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Mid"));
                            break;
                        case 8:
                            habilidadmid.ReduccionDañoMidEnemigo(Equipo_Enemigo.ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Mid"));
                            break;
                    }
                }

                // Rol Top.
                if (Habilidad is HabilidadTop habilidadtop)
                {
                    switch (Habilidad.CodigoHabilidad)
                    {
                        case 1:
                            habilidadtop.CuracionGeneral(Equipo_Aliado);
                            break;
                        case 2:
                            habilidadtop.DañoGeneral(Equipo_Enemigo);
                            break;
                        case 11:
                            habilidadtop.DañarTopEnemigo(Equipo_Enemigo.ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Top"));
                            break;
                        case 12:
                            habilidadtop.CurarASoporte(Equipo_Aliado.ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Soporte"));
                            break;
                    }
                }

                // Rol Soporte.
                if (Habilidad is HabilidadSoporte habilidadSoporte)
                {
                    switch (Habilidad.CodigoHabilidad)
                    {
                        case 1:
                            habilidadSoporte.CuracionGeneral(Equipo_Aliado);
                            break;
                        case 2:
                            habilidadSoporte.DañoGeneral(Equipo_Enemigo);
                            break;
                        case 9:
                            habilidadSoporte.CurarAdcAliado(Equipo_Aliado.ListaJugadoresDeEquipo.FirstOrDefault(x => x.ChampAsociado.RolChamp.Nombre == "Adc"));
                            break;
                        case 10:
                            habilidadSoporte.ReduccionDeDañoGeneral(Equipo_Enemigo);
                            break;
                    }
                }
            }
        }

        // Metodo para atacar despues de lanzar cada habilidad.
        public void Atacar(Equipo EquipoASerAtacado, Jugador JugadorQueEstaAtacando)
        {
            switch (RolChamp.Nombre)
            {
                case "Jungla":
                    var JunglaEnemigo = EquipoASerAtacado.RetornarJugadordeseado("Jungla").ChampAsociado;
                    if (JunglaEnemigo.Estamuerto == false)
                    {
                        Ataque(JunglaEnemigo, JugadorQueEstaAtacando);
                    }
                    else
                    {
                        var JugadorxAAtacar = EquipoASerAtacado.ListaJugadoresDeEquipo.FirstOrDefault(jugador => jugador.ChampAsociado.Estamuerto == false);
                        if (JugadorxAAtacar != null)
                        {
                            Ataque(JugadorxAAtacar.ChampAsociado, JugadorQueEstaAtacando);
                        }
                    }
                    break;
                case "Soporte":
                    var SoporteEnemigo = EquipoASerAtacado.RetornarJugadordeseado("Soporte").ChampAsociado;
                    if (SoporteEnemigo.Estamuerto == false)
                    {
                        Ataque(SoporteEnemigo, JugadorQueEstaAtacando);
                    }
                    else
                    {
                        var JugadorxAAtacar = EquipoASerAtacado.ListaJugadoresDeEquipo.FirstOrDefault(jugador => jugador.ChampAsociado.Estamuerto == false);
                        if (JugadorxAAtacar != null)
                        {
                            Ataque(JugadorxAAtacar.ChampAsociado, JugadorQueEstaAtacando);
                        }
                    }
                    break;
                case "Mid":
                    var MidEnemigo = EquipoASerAtacado.RetornarJugadordeseado("Mid").ChampAsociado;
                    if (MidEnemigo.Estamuerto == false)
                    {
                        Ataque(MidEnemigo, JugadorQueEstaAtacando);
                    }
                    else
                    {
                        var JugadorxAAtacar = EquipoASerAtacado.ListaJugadoresDeEquipo.FirstOrDefault(jugador => jugador.ChampAsociado.Estamuerto == false);
                        if (JugadorxAAtacar != null)
                        {
                            Ataque(JugadorxAAtacar.ChampAsociado, JugadorQueEstaAtacando);
                        }
                    }
                    break;
                case "Adc":
                    var AdcEnemigo = EquipoASerAtacado.RetornarJugadordeseado("Adc").ChampAsociado;
                    if (AdcEnemigo.Estamuerto == false)
                    {
                        Ataque(AdcEnemigo, JugadorQueEstaAtacando);
                    }
                    else
                    {
                        var JugadorxAAtacar = EquipoASerAtacado.ListaJugadoresDeEquipo.FirstOrDefault(jugador => jugador.ChampAsociado.Estamuerto == false);
                        if (JugadorxAAtacar != null)
                        {
                            Ataque(JugadorxAAtacar.ChampAsociado, JugadorQueEstaAtacando);
                        }
                    }
                    break;
                case "Top":
                    var TopEnemigo = EquipoASerAtacado.RetornarJugadordeseado("Top").ChampAsociado;
                    if (TopEnemigo.Estamuerto == false)
                    {
                        Ataque(TopEnemigo, JugadorQueEstaAtacando);
                    }
                    else
                    {
                        var JugadorxAAtacar = EquipoASerAtacado.ListaJugadoresDeEquipo.FirstOrDefault(jugador => jugador.ChampAsociado.Estamuerto == false);
                        if (JugadorxAAtacar != null)
                        {
                            Ataque(JugadorxAAtacar.ChampAsociado, JugadorQueEstaAtacando);
                        }
                    }
                    break;
            }
        }
    }
}