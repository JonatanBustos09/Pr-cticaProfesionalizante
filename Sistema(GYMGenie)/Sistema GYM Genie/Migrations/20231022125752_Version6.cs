using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_GYM_Genie.Migrations
{
    /// <inheritdoc />
    public partial class Version6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "AlturaCm",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "CBU",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ClaseId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "DiaReserva",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "DiaTurno",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Equipamiento",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "HoraFinTurno",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "HoraInicioTurno",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "HoraReserva",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "MontoPago",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "NombreClase",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "PagoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "PesoCliente",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Sueldo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TipoClase",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TipoRol",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TurnoId",
                table: "Personas");

            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    ClaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoClase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreClase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipamiento = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Profesores",
                columns: table => new
                {
                    ProfesorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    TipoRol = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Profesores");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlturaCm",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CBU",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClaseId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DiaReserva",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DiaTurno",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Equipamiento",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraFinTurno",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraInicioTurno",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraReserva",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "MontoPago",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreClase",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PagoId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "PesoCliente",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfesorId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Sueldo",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoClase",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoRol",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurnoId",
                table: "Personas",
                type: "int",
                nullable: true);
        }
    }
}
