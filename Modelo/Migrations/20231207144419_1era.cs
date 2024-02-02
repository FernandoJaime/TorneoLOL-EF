using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _1era : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    IdEquipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartidasJugadas = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Ganadas = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Perdidas = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Puntuacion = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DadoDeBaja = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.IdEquipo);
                });

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    IdHabilidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoHabilidad = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.IdHabilidad);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "Campeones",
                columns: table => new
                {
                    IdCampeon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Estamuerto = table.Column<bool>(type: "bit", nullable: false),
                    PuntosDeVida = table.Column<int>(type: "int", nullable: false),
                    DañoAtaque = table.Column<int>(type: "int", nullable: false),
                    DañoTotal = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    IdHabilidad = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeones", x => x.IdCampeon);
                    table.ForeignKey(
                        name: "FK_Campeones_Habilidades_IdHabilidad",
                        column: x => x.IdHabilidad,
                        principalTable: "Habilidades",
                        principalColumn: "IdHabilidad");
                    table.ForeignKey(
                        name: "FK_Campeones_Roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Roles",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    IdJugador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Experiencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VecesMVP = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Habilidad = table.Column<int>(type: "int", nullable: false),
                    IdChampAsociado = table.Column<int>(type: "int", nullable: false),
                    IdEquipoAsociado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.IdJugador);
                    table.ForeignKey(
                        name: "FK_Jugadores_Campeones_IdChampAsociado",
                        column: x => x.IdChampAsociado,
                        principalTable: "Campeones",
                        principalColumn: "IdCampeon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_IdEquipoAsociado",
                        column: x => x.IdEquipoAsociado,
                        principalTable: "Equipos",
                        principalColumn: "IdEquipo");
                });

            migrationBuilder.CreateTable(
                name: "Partidas",
                columns: table => new
                {
                    IdPartida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPartida = table.Column<int>(type: "int", nullable: false),
                    IdEquipo1 = table.Column<int>(type: "int", nullable: false),
                    IdEquipo2 = table.Column<int>(type: "int", nullable: false),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    IdJugadorMVP = table.Column<int>(type: "int", nullable: false),
                    IdEquipoGanador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidas", x => x.IdPartida);
                    table.ForeignKey(
                        name: "FK_Partidas_Equipos_IdEquipo1",
                        column: x => x.IdEquipo1,
                        principalTable: "Equipos",
                        principalColumn: "IdEquipo");
                    table.ForeignKey(
                        name: "FK_Partidas_Equipos_IdEquipo2",
                        column: x => x.IdEquipo2,
                        principalTable: "Equipos",
                        principalColumn: "IdEquipo");
                    table.ForeignKey(
                        name: "FK_Partidas_Equipos_IdEquipoGanador",
                        column: x => x.IdEquipoGanador,
                        principalTable: "Equipos",
                        principalColumn: "IdEquipo");
                    table.ForeignKey(
                        name: "FK_Partidas_Jugadores_IdJugadorMVP",
                        column: x => x.IdJugadorMVP,
                        principalTable: "Jugadores",
                        principalColumn: "IdJugador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "IdHabilidad", "CodigoHabilidad", "Nombre", "Tipo" },
                values: new object[,]
                {
                    { 1, 1, "Curacion general", "Habilidad" },
                    { 2, 2, "Daño general", "Habilidad" },
                    { 3, 3, "Aumentar daño 10%", "HabilidadAdc" },
                    { 4, 4, "Reducir daño adc enemigo", "HabilidadAdc" },
                    { 5, 5, "Dañar jungla enemigo", "HabilidadJungla" },
                    { 6, 6, "Curarse", "HabilidadJungla" },
                    { 7, 7, "Aumentar 5% de daño", "HabilidadMid" },
                    { 8, 8, "Reducir daño mid enemigo", "HabilidadMid" },
                    { 9, 9, "Curar adc aliado", "HabilidadSoporte" },
                    { 10, 10, "Reducir daño general", "HabilidadSoporte" },
                    { 11, 11, "Dañar top enemigo", "HabilidadTop" },
                    { 12, 12, "Curar a soporte", "HabilidadTop" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "IdRol", "Nombre" },
                values: new object[,]
                {
                    { 1, "Jungla" },
                    { 2, "Mid" },
                    { 3, "Top" },
                    { 4, "Adc" },
                    { 5, "Soporte" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campeones_IdHabilidad",
                table: "Campeones",
                column: "IdHabilidad");

            migrationBuilder.CreateIndex(
                name: "IX_Campeones_IdRol",
                table: "Campeones",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Campeones_Nombre",
                table: "Campeones",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_Nombre",
                table: "Equipos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Habilidades_CodigoHabilidad",
                table: "Habilidades",
                column: "CodigoHabilidad",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_IdChampAsociado",
                table: "Jugadores",
                column: "IdChampAsociado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_IdEquipoAsociado",
                table: "Jugadores",
                column: "IdEquipoAsociado");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_Nickname",
                table: "Jugadores",
                column: "Nickname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Partidas_CodigoPartida",
                table: "Partidas",
                column: "CodigoPartida",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Partidas_IdEquipo1",
                table: "Partidas",
                column: "IdEquipo1");

            migrationBuilder.CreateIndex(
                name: "IX_Partidas_IdEquipo2",
                table: "Partidas",
                column: "IdEquipo2");

            migrationBuilder.CreateIndex(
                name: "IX_Partidas_IdEquipoGanador",
                table: "Partidas",
                column: "IdEquipoGanador");

            migrationBuilder.CreateIndex(
                name: "IX_Partidas_IdJugadorMVP",
                table: "Partidas",
                column: "IdJugadorMVP");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Nombre",
                table: "Roles",
                column: "Nombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partidas");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Campeones");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
