using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Modelo;
using System.Linq.Expressions;

namespace Controlador
{
    public class ControladoraJugadores
    {
       // private Contexto contexto;
        private static ControladoraJugadores instancia; // Aplicamos Singleton.
        public static ControladoraJugadores Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraJugadores();
                }
                return instancia;
            }
        }
        // -------------------------------------------------- METODOS DE VERIFICACION DE EXISTENCIA --------------------------------------------------------------
        public bool ExisteJugador(Jugador Jugador)
        {
            using (var contexto = new Contexto())
            {
                var existe = contexto.Jugadores.ToList().FirstOrDefault(x => x.Nickname == Jugador.Nickname);
                if (existe == null)
                {
                    return false;
                }
                return true;
            }
        }
        public bool ExisteCampeon(Campeon Campeon)
        {
            using (var contexto = new Contexto())
            {
                var existe = contexto.Campeones.ToList().FirstOrDefault(x => x.Nombre == Campeon.Nombre);
                if (existe == null)
                {
                    return false;
                }
                return true;
            }
        }
        // ------------------------------------------------------- RECUPERAR --------------------------------------------------------------
        public IReadOnlyCollection<Jugador> RecuperarJugadores() // Recupero los jugadores.
        {
            try
            {
                using (var contexto = new Contexto())
                {
                    return contexto.Jugadores.OrderByDescending(j => j.VecesMVP).Include(x => x.ChampAsociado.RolChamp).Include(x => x.ChampAsociado).Include(x => x.EquipoAsociado).AsNoTracking().ToList(); 
                    // Recuperamos los jugadores para mostrarlos de manera ordenada segun las veces que salieron MVP de una partida.
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IReadOnlyCollection<Rol> RecuperarRoles()
        {
            try
            {
                using (var contexto = new Contexto())
                {
                    return contexto.Roles.ToList().AsReadOnly();
                }  
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public IReadOnlyCollection<Jugador> RecuperarPorRol(string Rol) //Recuperar los jugadores que no están un equipo y son de un rol específico
        {
            try
            {
                using (var contexto = new Contexto())
                {
                    var listado = contexto.Jugadores.OrderByDescending(j => j.VecesMVP).Include(x => x.ChampAsociado).Include(x => x.ChampAsociado.RolChamp).Include(x => x.EquipoAsociado).AsNoTracking().ToList();
                    switch (Rol)
                    {
                        case "Jungla":
                            return listado.ToList().FindAll(x => (x.TieneEquipo == false && x.ChampAsociado.RolChamp.Nombre == "Jungla")).AsReadOnly();
                            break;
                        case "Mid":
                            return listado.ToList().FindAll(x => (x.TieneEquipo == false && x.ChampAsociado.RolChamp.Nombre == "Mid")).AsReadOnly();
                            break;
                        case "Soporte":
                            return listado.ToList().FindAll(x => (x.TieneEquipo == false && x.ChampAsociado.RolChamp.Nombre == "Soporte")).AsReadOnly();
                            break;
                        case "Adc":
                            return listado.ToList().FindAll(x => (x.TieneEquipo == false && x.ChampAsociado.RolChamp.Nombre == "Adc")).AsReadOnly();
                            break;
                        case "Top":
                            return listado.ToList().FindAll(x => (x.TieneEquipo == false && x.ChampAsociado.RolChamp.Nombre == "Top")).AsReadOnly();
                            break;
                    }
                    return listado;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        // ------------------------------------------------------- AGREGAR --------------------------------------------------------------
        public string AgregarJugador(Jugador jugadoraagregar)
        {
            try
            {
                using (var contexto = new Contexto())
                {
                    var existe = contexto.Jugadores.ToList().FirstOrDefault(x => x.Nickname == jugadoraagregar.Nickname);
                    if (jugadoraagregar.ChampAsociado !=null)
                    {
                        contexto.Jugadores.Update(jugadoraagregar);
                        contexto.SaveChanges();
                        return "Se ha agregado el jugador correctamente!";
                    }
                   
                    if (existe is null)
                    {
                        contexto.Jugadores.Add(jugadoraagregar);
                     
                        contexto.SaveChanges();
                        return "El jugador se ha agregado correctamente!";
                    }
                    else
                    {
                        return "El jugador ya existe";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error";
            }
        }
        // ------------------------------------------------------- ELIMINAR --------------------------------------------------------------
        public string EliminarJugador(Jugador jugador) //Método para eliminar jugador
        {
            try
            {
                using (var contexto = new Contexto())
                {
                    var existe = contexto.Jugadores.ToList().FirstOrDefault(x => x.Nickname == jugador.Nickname);
                    if (existe is not null)
                    {
                        var tiene = jugador.TieneEquipo;
                        if (!tiene)
                        {
                            using (var contextos = new Contexto())
                            {
                                contextos.Jugadores.Remove(jugador);
                                try
                                {
                                    var existe1 = contextos.Campeones.ToList().FirstOrDefault(x => x.Nombre == jugador.ChampAsociado.Nombre);
                                    if (existe1 is not null)
                                    {
                                        contextos.Campeones.Remove(jugador.ChampAsociado); //El Hecho de eliminar un jugador también conlleva eliminar el campeón al cual está asociado
                                        contextos.SaveChanges();
                                        return "El jugador se ha eliminado con éxito!";
                                    }
                                    else
                                    {
                                        return "No existe el campeon";
                                    }

                                }
                                catch (Exception ex)
                                {
                                    throw;
                                }
                            }
                        }
                        else
                        {
                            return "El jugador pertenece a un equipo, por favor disuelva primero el mismo!";
                        }

                    }
                    else
                    {
                        return "El jugador que desea eliminar no existe!";
                    }
                }
            }
            catch (Exception ex)
            {
                return "erorr desconocido!";
            }
        }
        // ------------------------------------------------------- MODIFICAR --------------------------------------------------------------
        public string ModificarJugador(Jugador JugadorAModi)
        {
            try
            {
                using (var contexto = new Contexto())
                {
                    contexto.Entry(JugadorAModi).State = EntityState.Detached;
                    contexto.Jugadores.Update(JugadorAModi);
                    contexto.SaveChanges();
                    return "El jugador se ha actualizado con éxito!";
                }
            }
            catch (Exception ex)
            {
                return "Error desconocido!";
            }
        }
        public void ActualizarEquipo (List<Jugador> JugadoresDeEquipo)
        {
            using (var contexto = new Contexto())
            {
                foreach (var Jugador in JugadoresDeEquipo)
                {
                    contexto.Update(Jugador);
                    contexto.SaveChanges();
                }
            }
        }   
    }
}