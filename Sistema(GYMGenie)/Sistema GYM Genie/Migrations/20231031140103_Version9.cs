﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_GYM_Genie.Migrations
{
    /// <inheritdoc />
    public partial class Version9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Profesores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Profesor",
                table: "Personas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_PersonaId",
                table: "Profesores",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesores_Personas_PersonaId",
                table: "Profesores",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profesores_Personas_PersonaId",
                table: "Profesores");

            migrationBuilder.DropIndex(
                name: "IX_Profesores_PersonaId",
                table: "Profesores");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Profesores");

            migrationBuilder.DropColumn(
                name: "Profesor",
                table: "Personas");
        }
    }
}
