using Entidades;
using Entidades.Habilidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Contexto : DbContext
    {
        public DbSet<Habilidad> Habilidades { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Campeon> Campeones { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Partida> Partidas { get; set; }

        // Conexion a la base de datos.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\MSSQLLocalDB;initial catalog=TorneoLOL;integrated security = true;").EnableSensitiveDataLogging();
        }

        // Configuracion de las tablas.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CONFIGURACION DE LAS PROPIEDADES:

            // Habilidades.
            modelBuilder.Entity<Habilidad>().ToTable("Habilidades");
            modelBuilder.Entity<Habilidad>().HasKey(h => h.IdHabilidad);
            modelBuilder.Entity<Habilidad>().HasIndex(h => h.CodigoHabilidad).IsUnique();
            modelBuilder.Entity<Habilidad>().Property(h => h.Nombre).IsRequired(true);
            modelBuilder.Entity<Habilidad>().Property(h => h.Tipo).IsRequired(true);

            // Roles.
            modelBuilder.Entity<Rol>().ToTable("Roles");
            modelBuilder.Entity<Rol>().HasKey(r => r.IdRol); ;
            modelBuilder.Entity<Rol>().HasIndex(r => r.Nombre).IsUnique();

            // Campeones.
            modelBuilder.Entity<Campeon>().ToTable("Campeones");
            modelBuilder.Entity<Campeon>().HasKey(c => c.IdCampeon);
            modelBuilder.Entity<Campeon>().HasIndex(c => c.Nombre).IsUnique();
            modelBuilder.Entity<Campeon>().Property(c => c.Estamuerto).IsRequired(true);
            modelBuilder.Entity<Campeon>().Property(c => c.PuntosDeVida).IsRequired(true);
            modelBuilder.Entity<Campeon>().Property(c => c.DañoAtaque).IsRequired(true);
            modelBuilder.Entity<Campeon>().HasOne(c => c.RolChamp).WithMany().HasForeignKey(c => c.IdRol);
            modelBuilder.Entity<Campeon>().HasOne(c => c.Habilidad).WithMany().HasForeignKey(c => c.IdHabilidad);
            modelBuilder.Entity<Campeon>().Property(c => c.IdHabilidad).IsRequired(false);

            // Jugadores.
            modelBuilder.Entity<Jugador>().ToTable("Jugadores");
            modelBuilder.Entity<Jugador>().HasKey(j => j.IdJugador);
            modelBuilder.Entity<Jugador>().HasIndex(j => j.Nickname).IsUnique();
            modelBuilder.Entity<Jugador>().Property(j => j.Nombre).IsRequired(true);
            modelBuilder.Entity<Jugador>().Property(j => j.Nacionalidad).IsRequired(true);
            modelBuilder.Entity<Jugador>().Property(j => j.Edad).IsRequired(true);
            modelBuilder.Entity<Jugador>().Property(j => j.Experiencia).IsRequired(true);
            modelBuilder.Entity<Jugador>().Property(j => j.VecesMVP).HasDefaultValue(0);
            modelBuilder.Entity<Jugador>().HasOne(j => j.ChampAsociado).WithOne().HasForeignKey<Jugador>(j => j.IdChampAsociado);
            modelBuilder.Entity<Jugador>().HasOne(j => j.EquipoAsociado).WithMany(e => e.ListaJugadoresDeEquipo).HasForeignKey(j => j.IdEquipoAsociado);
            modelBuilder.Entity<Jugador>().Property(j => j.IdEquipoAsociado).IsRequired(false);

            // Equipos.
            modelBuilder.Entity<Equipo>().ToTable("Equipos");
            modelBuilder.Entity<Equipo>().HasKey(e => e.IdEquipo);
            modelBuilder.Entity<Equipo>().HasIndex(e => e.Nombre).IsUnique();
            modelBuilder.Entity<Equipo>().Property(e => e.Puntuacion).HasDefaultValue(0);
            modelBuilder.Entity<Equipo>().Property(e => e.PartidasJugadas).HasDefaultValue(0);
            modelBuilder.Entity<Equipo>().Property(e => e.Ganadas).HasDefaultValue(0);
            modelBuilder.Entity<Equipo>().Property(e => e.Perdidas).HasDefaultValue(0);
            modelBuilder.Entity<Equipo>().Property(e => e.DadoDeBaja).HasDefaultValue(false);

            // Partida.
            modelBuilder.Entity<Partida>().ToTable("Partidas");
            modelBuilder.Entity<Partida>().HasKey(p => p.IdPartida);
            modelBuilder.Entity<Partida>().HasIndex(p => p.CodigoPartida).IsUnique();
            modelBuilder.Entity<Partida>().Property(p => p.Duracion).IsRequired(true);
            modelBuilder.Entity<Partida>().HasOne(p => p.Ganador).WithMany().HasForeignKey(p => p.IdEquipoGanador).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Partida>().HasOne(p => p.Equipo_1).WithMany().HasForeignKey(p => p.IdEquipo1).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Partida>().HasOne(p => p.Equipo_2).WithMany().HasForeignKey(p => p.IdEquipo2).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Partida>().HasOne(p => p.JugadorMVP).WithMany().HasForeignKey(p => p.IdJugadorMVP);

            // PRECARGA DE DATOS:

            // Roles.
            var Jungla = new Rol { IdRol = 1, Nombre = "Jungla" };
            var Mid = new Rol { IdRol = 2, Nombre = "Mid" };
            var Top = new Rol { IdRol = 3, Nombre = "Top" };
            var Adc = new Rol { IdRol = 4, Nombre = "Adc" };
            var Soporte = new Rol { IdRol = 5, Nombre = "Soporte" };
            modelBuilder.Entity<Rol>().HasData(Jungla, Mid, Top, Adc, Soporte);

            // Habilidades.
            var CuracionGeneral = new Habilidad { IdHabilidad = 1, CodigoHabilidad = 1, Tipo = "Habilidad", Nombre = "Curacion general" };
            var DañoGeneral = new Habilidad { IdHabilidad = 2, CodigoHabilidad = 2, Tipo = "Habilidad", Nombre = "Daño general" };
            var AumentarDañoDiez = new Habilidad { IdHabilidad = 3, CodigoHabilidad = 3, Tipo = "HabilidadAdc", Nombre = "Aumentar daño 10%" };
            var ReducirDañoAdcEnemigo = new Habilidad { IdHabilidad = 4, CodigoHabilidad = 4, Tipo = "HabilidadAdc", Nombre = "Reducir daño adc enemigo" };
            var DañarJunglaEnemigo = new Habilidad { IdHabilidad = 5, CodigoHabilidad = 5, Tipo = "HabilidadJungla", Nombre = "Dañar jungla enemigo" };
            var Curarse = new Habilidad { IdHabilidad = 6, CodigoHabilidad = 6, Tipo = "HabilidadJungla", Nombre = "Curarse" };
            var AumentarPorcentajeDeDaño = new Habilidad { IdHabilidad = 7, CodigoHabilidad = 7, Tipo = "HabilidadMid", Nombre = "Aumentar 5% de daño" };
            var ReduccionDañoMidEnemigo = new Habilidad { IdHabilidad = 8, CodigoHabilidad = 8, Tipo = "HabilidadMid", Nombre = "Reducir daño mid enemigo" };
            var CurarAdcAliado = new Habilidad { IdHabilidad = 9, CodigoHabilidad = 9, Tipo = "HabilidadSoporte", Nombre = "Curar adc aliado" };
            var ReducciónDañoGeneral = new Habilidad { IdHabilidad = 10, CodigoHabilidad = 10, Tipo = "HabilidadSoporte", Nombre = "Reducir daño general" };
            var DañarTopEnemigo = new Habilidad { IdHabilidad = 11, CodigoHabilidad = 11, Tipo = "HabilidadTop", Nombre = "Dañar top enemigo" };
            var CurarASoporte = new Habilidad { IdHabilidad = 12, CodigoHabilidad = 12, Tipo = "HabilidadTop", Nombre = "Curar a soporte" };
            modelBuilder.Entity<Habilidad>().HasData(CuracionGeneral, DañoGeneral, AumentarDañoDiez, ReducirDañoAdcEnemigo, DañarJunglaEnemigo, Curarse, AumentarPorcentajeDeDaño, ReduccionDañoMidEnemigo, CurarAdcAliado, ReducciónDañoGeneral, DañarTopEnemigo, CurarASoporte);
        }
    }
}