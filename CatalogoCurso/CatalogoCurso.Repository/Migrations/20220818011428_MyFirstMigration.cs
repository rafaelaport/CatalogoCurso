using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoCurso.Repository.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EixoTecnologico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EixoTecnologico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadeEducacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadeEducacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Segmento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segmento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCurso",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCurso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CargaHoraria = table.Column<int>(type: "int", nullable: false),
                    Objetivo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Bibliografia = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Avaliacao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Certificacao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ModalidadeEnsino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoCursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModalidadeEducacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EixoTecnologicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SegmentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curso_EixoTecnologico_EixoTecnologicoId",
                        column: x => x.EixoTecnologicoId,
                        principalTable: "EixoTecnologico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curso_ModalidadeEducacao_ModalidadeEducacaoId",
                        column: x => x.ModalidadeEducacaoId,
                        principalTable: "ModalidadeEducacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curso_Segmento_SegmentoId",
                        column: x => x.SegmentoId,
                        principalTable: "Segmento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curso_TipoCurso_TipoCursoId",
                        column: x => x.TipoCursoId,
                        principalTable: "TipoCurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "EixoTecnologico");

            migrationBuilder.DropTable(
                name: "ModalidadeEducacao");

            migrationBuilder.DropTable(
                name: "Segmento");

            migrationBuilder.DropTable(
                name: "TipoCurso");
        }
    }
}
