﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo;

#nullable disable

namespace Modelo.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entidades.Campeon", b =>
                {
                    b.Property<int>("IdCampeon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCampeon"));

                    b.Property<int>("DañoAtaque")
                        .HasColumnType("int");

                    b.Property<int>("DañoTotal")
                        .HasColumnType("int");

                    b.Property<bool>("Estamuerto")
                        .HasColumnType("bit");

                    b.Property<int?>("IdHabilidad")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PuntosDeVida")
                        .HasColumnType("int");

                    b.HasKey("IdCampeon");

                    b.HasIndex("IdHabilidad");

                    b.HasIndex("IdRol");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Campeones", (string)null);
                });

            modelBuilder.Entity("Entidades.Equipo", b =>
                {
                    b.Property<int>("IdEquipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEquipo"));

                    b.Property<bool>("DadoDeBaja")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("Ganadas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PartidasJugadas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Perdidas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Puntuacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("IdEquipo");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Equipos", (string)null);
                });

            modelBuilder.Entity("Entidades.Habilidad", b =>
                {
                    b.Property<int>("IdHabilidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHabilidad"));

                    b.Property<int>("CodigoHabilidad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdHabilidad");

                    b.HasIndex("CodigoHabilidad")
                        .IsUnique();

                    b.ToTable("Habilidades", (string)null);

                    b.HasData(
                        new
                        {
                            IdHabilidad = 1,
                            CodigoHabilidad = 1,
                            Nombre = "Curacion general",
                            Tipo = "Habilidad"
                        },
                        new
                        {
                            IdHabilidad = 2,
                            CodigoHabilidad = 2,
                            Nombre = "Daño general",
                            Tipo = "Habilidad"
                        },
                        new
                        {
                            IdHabilidad = 3,
                            CodigoHabilidad = 3,
                            Nombre = "Aumentar daño 10%",
                            Tipo = "HabilidadAdc"
                        },
                        new
                        {
                            IdHabilidad = 4,
                            CodigoHabilidad = 4,
                            Nombre = "Reducir daño adc enemigo",
                            Tipo = "HabilidadAdc"
                        },
                        new
                        {
                            IdHabilidad = 5,
                            CodigoHabilidad = 5,
                            Nombre = "Dañar jungla enemigo",
                            Tipo = "HabilidadJungla"
                        },
                        new
                        {
                            IdHabilidad = 6,
                            CodigoHabilidad = 6,
                            Nombre = "Curarse",
                            Tipo = "HabilidadJungla"
                        },
                        new
                        {
                            IdHabilidad = 7,
                            CodigoHabilidad = 7,
                            Nombre = "Aumentar 5% de daño",
                            Tipo = "HabilidadMid"
                        },
                        new
                        {
                            IdHabilidad = 8,
                            CodigoHabilidad = 8,
                            Nombre = "Reducir daño mid enemigo",
                            Tipo = "HabilidadMid"
                        },
                        new
                        {
                            IdHabilidad = 9,
                            CodigoHabilidad = 9,
                            Nombre = "Curar adc aliado",
                            Tipo = "HabilidadSoporte"
                        },
                        new
                        {
                            IdHabilidad = 10,
                            CodigoHabilidad = 10,
                            Nombre = "Reducir daño general",
                            Tipo = "HabilidadSoporte"
                        },
                        new
                        {
                            IdHabilidad = 11,
                            CodigoHabilidad = 11,
                            Nombre = "Dañar top enemigo",
                            Tipo = "HabilidadTop"
                        },
                        new
                        {
                            IdHabilidad = 12,
                            CodigoHabilidad = 12,
                            Nombre = "Curar a soporte",
                            Tipo = "HabilidadTop"
                        });
                });

            modelBuilder.Entity("Entidades.Jugador", b =>
                {
                    b.Property<int>("IdJugador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJugador"));

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Experiencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Habilidad")
                        .HasColumnType("int");

                    b.Property<int>("IdChampAsociado")
                        .HasColumnType("int");

                    b.Property<int?>("IdEquipoAsociado")
                        .HasColumnType("int");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VecesMVP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("IdJugador");

                    b.HasIndex("IdChampAsociado")
                        .IsUnique();

                    b.HasIndex("IdEquipoAsociado");

                    b.HasIndex("Nickname")
                        .IsUnique();

                    b.ToTable("Jugadores", (string)null);
                });

            modelBuilder.Entity("Entidades.Partida", b =>
                {
                    b.Property<int>("IdPartida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPartida"));

                    b.Property<int>("CodigoPartida")
                        .HasColumnType("int");

                    b.Property<int>("Duracion")
                        .HasColumnType("int");

                    b.Property<int>("IdEquipo1")
                        .HasColumnType("int");

                    b.Property<int>("IdEquipo2")
                        .HasColumnType("int");

                    b.Property<int>("IdEquipoGanador")
                        .HasColumnType("int");

                    b.Property<int>("IdJugadorMVP")
                        .HasColumnType("int");

                    b.HasKey("IdPartida");

                    b.HasIndex("CodigoPartida")
                        .IsUnique();

                    b.HasIndex("IdEquipo1");

                    b.HasIndex("IdEquipo2");

                    b.HasIndex("IdEquipoGanador");

                    b.HasIndex("IdJugadorMVP");

                    b.ToTable("Partidas", (string)null);
                });

            modelBuilder.Entity("Entidades.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRol"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdRol");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            IdRol = 1,
                            Nombre = "Jungla"
                        },
                        new
                        {
                            IdRol = 2,
                            Nombre = "Mid"
                        },
                        new
                        {
                            IdRol = 3,
                            Nombre = "Top"
                        },
                        new
                        {
                            IdRol = 4,
                            Nombre = "Adc"
                        },
                        new
                        {
                            IdRol = 5,
                            Nombre = "Soporte"
                        });
                });

            modelBuilder.Entity("Entidades.Campeon", b =>
                {
                    b.HasOne("Entidades.Habilidad", "Habilidad")
                        .WithMany()
                        .HasForeignKey("IdHabilidad");

                    b.HasOne("Entidades.Rol", "RolChamp")
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habilidad");

                    b.Navigation("RolChamp");
                });

            modelBuilder.Entity("Entidades.Jugador", b =>
                {
                    b.HasOne("Entidades.Campeon", "ChampAsociado")
                        .WithOne()
                        .HasForeignKey("Entidades.Jugador", "IdChampAsociado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Equipo", "EquipoAsociado")
                        .WithMany("ListaJugadoresDeEquipo")
                        .HasForeignKey("IdEquipoAsociado");

                    b.Navigation("ChampAsociado");

                    b.Navigation("EquipoAsociado");
                });

            modelBuilder.Entity("Entidades.Partida", b =>
                {
                    b.HasOne("Entidades.Equipo", "Equipo_1")
                        .WithMany()
                        .HasForeignKey("IdEquipo1")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entidades.Equipo", "Equipo_2")
                        .WithMany()
                        .HasForeignKey("IdEquipo2")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entidades.Equipo", "Ganador")
                        .WithMany()
                        .HasForeignKey("IdEquipoGanador")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entidades.Jugador", "JugadorMVP")
                        .WithMany()
                        .HasForeignKey("IdJugadorMVP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo_1");

                    b.Navigation("Equipo_2");

                    b.Navigation("Ganador");

                    b.Navigation("JugadorMVP");
                });

            modelBuilder.Entity("Entidades.Equipo", b =>
                {
                    b.Navigation("ListaJugadoresDeEquipo");
                });
#pragma warning restore 612, 618
        }
    }
}