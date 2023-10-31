using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_GYM_Genie.Migrations
{
    /// <inheritdoc />
    public partial class Version1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    ClaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoClase = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NombreClase = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Equipamiento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CostoClase = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.ClaseId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PesoCliente = table.Column<float>(type: "real", nullable: false),
                    AlturaCm = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    PagoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MontoPago = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.PagoId);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI_Persona = table.Column<int>(type: "int", nullable: false),
                    NombrePersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ApellidoPersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TelefonoPersona = table.Column<int>(type: "int", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NombreUsuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Contrasenia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    AlturaDireccion = table.Column<int>(type: "int", nullable: false),
                    Profesor = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    ProfesorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Alias = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CBU = table.Column<int>(type: "int", nullable: false),
                    Sueldo = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.ProfesorId);
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
                name: "Roles",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoRol = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolId);
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Turnos");
        }
    }
}
