using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_GYM_Genie.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate45 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "PersonaSequence");

            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    ClaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreClase = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Equipamiento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CostoClase = table.Column<float>(type: "real", nullable: false),
                    ProfesorDNI = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.ClaseId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    DNI_Persona = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [PersonaSequence]"),
                    NombrePersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ApellidoPersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TelefonoPersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NombreUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Contrasenia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    id = table.Column<int>(type: "int", nullable: false),
                    PesoCliente = table.Column<float>(type: "real", nullable: false),
                    AlturaCm = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.DNI_Persona);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    DNI_Persona = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [PersonaSequence]"),
                    NombrePersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ApellidoPersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TelefonoPersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NombreUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Contrasenia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.DNI_Persona);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    DNI_Persona = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [PersonaSequence]"),
                    NombrePersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ApellidoPersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TelefonoPersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NombreUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Contrasenia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Alias = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Sueldo = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.DNI_Persona);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ReservaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiaReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraReserva = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ReservaId);
                });

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    TurnoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiaTurno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraInicioTurno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraFinTurno = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.TurnoId);
                });

            migrationBuilder.CreateTable(
                name: "Incripciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteDNI_Persona = table.Column<int>(type: "int", nullable: false),
                    ClaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incripciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Incripciones_Clases_ClaseId",
                        column: x => x.ClaseId,
                        principalTable: "Clases",
                        principalColumn: "ClaseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incripciones_Clientes_ClienteDNI_Persona",
                        column: x => x.ClienteDNI_Persona,
                        principalTable: "Clientes",
                        principalColumn: "DNI_Persona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Incripciones_ClaseId",
                table: "Incripciones",
                column: "ClaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Incripciones_ClienteDNI_Persona",
                table: "Incripciones",
                column: "ClienteDNI_Persona");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incripciones");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropSequence(
                name: "PersonaSequence");
        }
    }
}
