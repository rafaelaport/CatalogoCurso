using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoCurso.Repository.Migrations
{
    public partial class AdicionandoFK2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_EixoTecnologico_Id",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_Curso_ModalidadeEducacao_Id",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Segmento_Id",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_Curso_TipoCurso_Id",
                table: "Curso");

            migrationBuilder.AddColumn<Guid>(
                name: "EixoTecnologicoId",
                table: "Curso",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ModalidadeEducacaoId",
                table: "Curso",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SegmentoId",
                table: "Curso",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TipoCursoId",
                table: "Curso",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Curso_EixoTecnologicoId",
                table: "Curso",
                column: "EixoTecnologicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_ModalidadeEducacaoId",
                table: "Curso",
                column: "ModalidadeEducacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_SegmentoId",
                table: "Curso",
                column: "SegmentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_TipoCursoId",
                table: "Curso",
                column: "TipoCursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_EixoTecnologico_EixoTecnologicoId",
                table: "Curso",
                column: "EixoTecnologicoId",
                principalTable: "EixoTecnologico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_ModalidadeEducacao_ModalidadeEducacaoId",
                table: "Curso",
                column: "ModalidadeEducacaoId",
                principalTable: "ModalidadeEducacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Segmento_SegmentoId",
                table: "Curso",
                column: "SegmentoId",
                principalTable: "Segmento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_TipoCurso_TipoCursoId",
                table: "Curso",
                column: "TipoCursoId",
                principalTable: "TipoCurso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_EixoTecnologico_EixoTecnologicoId",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_Curso_ModalidadeEducacao_ModalidadeEducacaoId",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Segmento_SegmentoId",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_Curso_TipoCurso_TipoCursoId",
                table: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Curso_EixoTecnologicoId",
                table: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Curso_ModalidadeEducacaoId",
                table: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Curso_SegmentoId",
                table: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Curso_TipoCursoId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "EixoTecnologicoId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "ModalidadeEducacaoId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "SegmentoId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "TipoCursoId",
                table: "Curso");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_EixoTecnologico_Id",
                table: "Curso",
                column: "Id",
                principalTable: "EixoTecnologico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_ModalidadeEducacao_Id",
                table: "Curso",
                column: "Id",
                principalTable: "ModalidadeEducacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Segmento_Id",
                table: "Curso",
                column: "Id",
                principalTable: "Segmento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_TipoCurso_Id",
                table: "Curso",
                column: "Id",
                principalTable: "TipoCurso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
