using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoCurso.Repository.Migrations
{
    public partial class AdicionandoModalidadeEnsino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModalidadeEnsino",
                table: "Curso");

            migrationBuilder.AddColumn<Guid>(
                name: "ModalidadeEnsinoId",
                table: "Curso",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ModalidadeEnsino",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadeEnsino", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_ModalidadeEnsinoId",
                table: "Curso",
                column: "ModalidadeEnsinoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_ModalidadeEnsino_ModalidadeEnsinoId",
                table: "Curso",
                column: "ModalidadeEnsinoId",
                principalTable: "ModalidadeEnsino",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_ModalidadeEnsino_ModalidadeEnsinoId",
                table: "Curso");

            migrationBuilder.DropTable(
                name: "ModalidadeEnsino");

            migrationBuilder.DropIndex(
                name: "IX_Curso_ModalidadeEnsinoId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "ModalidadeEnsinoId",
                table: "Curso");

            migrationBuilder.AddColumn<string>(
                name: "ModalidadeEnsino",
                table: "Curso",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
