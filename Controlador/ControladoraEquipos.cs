using Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Modelo;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladoraEquipos
    {
        private static ControladoraEquipos instancia;
        public static ControladoraEquipos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraEquipos();
                }
                return instancia;
            }
        }
        // ------------------------------------------------------- RECUPERAR --------------------------------------------------------------
        public IReadOnlyCollection<Equipo> RecuperarEquiposConDetalles()
        {
            using (var contexto = new Contexto())
            {
                var equip = contexto.Equipos
                    .Include(x => x.ListaJugadoresDeEquipo)
                        .ThenInclude(j => j.ChampAsociado)  // Incluir el campeón asociado
                            .ThenInclude(c => c.RolChamp)   // Incluir el rol del campeón
                    .Where(x => x.DadoDeBaja == false)
                    .AsNoTracking()
                    .ToList()
                    .AsReadOnly();

                return equip;
            }
        }
        public void ModificarEquipo (Equipo EquipoAModi)
        {
            try
            {
                using (var contexto = new Contexto())
                {
                    var existe = contexto.Equipos.ToList().FirstOrDefault(x => x.Nombre == EquipoAModi.Nombre);
                    if (existe is not null)
                    {
                        contexto.Equipos.Update(EquipoAModi);
                        contexto.SaveChanges();
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        // ------------------------------------------------------- AGREGAR ----------------------------------------------------------------
        public string AgregarEquipo(Equipo equipoAAgregar)
        {
            try
            {
                using (var contexto = new Contexto())
                {
                    var existe = contexto.Equipos.ToList().FirstOrDefault(x => x.Nombre == equipoAAgregar.Nombre);
                    if (existe is null)
                    {
                        contexto.Equipos.Add(equipoAAgregar);
                        contexto.SaveChanges();
                        return "El equipo " + equipoAAgregar.Nombre + ", se ha agregado con éxito!";
                    }
                    else
                    {
                        return "Lo sentimos el equipo ya existe! cambie el nombre del mismo...";
                    }
                }
            }
            catch (Exception)
            {
                return "error desconocido!";
            }
        }

        // ------------------------------------------------------- ELIMINAR ---------------------------------------------------------------
        public string EliminarEquipo(Equipo EquipoAEliminar)
        {
            try
            {
                using (var contexto = new Contexto())
                {
                    // Buscar la entidad existente con la misma clave y desvincularla del contexto.
                    var equipoExistente = contexto.Equipos.Local.FirstOrDefault(e => e.IdEquipo == EquipoAEliminar.IdEquipo);
                    if (equipoExistente != null)
                    {
                        contexto.Entry(equipoExistente).State = EntityState.Detached;
                    }
                    foreach (var jugador in EquipoAEliminar.ListaJugadoresDeEquipo)
                    {
                        contexto.Entry(jugador).State = EntityState.Modified;
                        contexto.Entry(jugador.EquipoAsociado).State = EntityState.Modified;
                    }
                    
                    // Actualizar la propiedad DadoDeBaja y otros cambios necesarios.
                    EquipoAEliminar.EliminarEquipo();
                   
                    // Guardar los cambios en la base de datos
                    contexto.SaveChanges();

                    return "El equipo se ha eliminado con éxito!";
                }
            }
            catch (Exception ex)
            {
                return "Error al intentar eliminar el equipo: " + ex.Message;
            }
        }
    }
}