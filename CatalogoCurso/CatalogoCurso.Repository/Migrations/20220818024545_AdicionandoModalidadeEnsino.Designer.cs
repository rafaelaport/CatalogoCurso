﻿// <auto-generated />
using System;
using CatalogoCurso.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CatalogoCurso.Repository.Migrations
{
    [DbContext(typeof(CatalogoCursoContext))]
    [Migration("20220818024545_AdicionandoModalidadeEnsino")]
    partial class AdicionandoModalidadeEnsino
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CatalogoCurso.Domain.Curso.Curso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Avaliacao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Bibliografia")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int");

                    b.Property<string>("Certificacao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<Guid>("EixoTecnologicoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ModalidadeEducacaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ModalidadeEnsinoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Objetivo")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("SegmentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TipoCursoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EixoTecnologicoId");

                    b.HasIndex("ModalidadeEducacaoId");

                    b.HasIndex("ModalidadeEnsinoId");

                    b.HasIndex("SegmentoId");

                    b.HasIndex("TipoCursoId");

                    b.ToTable("Curso", (string)null);
                });

            modelBuilder.Entity("CatalogoCurso.Domain.Curso.EixoTecnologico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("EixoTecnologico", (string)null);
                });

            modelBuilder.Entity("CatalogoCurso.Domain.Curso.ModalidadeEducacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("ModalidadeEducacao", (string)null);
                });

            modelBuilder.Entity("CatalogoCurso.Domain.Curso.ModalidadeEnsino", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ModalidadeEnsino");
                });

            modelBuilder.Entity("CatalogoCurso.Domain.Curso.Segmento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Segmento", (string)null);
                });

            modelBuilder.Entity("CatalogoCurso.Domain.Curso.TipoCurso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("TipoCurso", (string)null);
                });

            modelBuilder.Entity("CatalogoCurso.Domain.Curso.Curso", b =>
                {
                    b.HasOne("CatalogoCurso.Domain.Curso.EixoTecnologico", "EixoTecnologico")
                        .WithMany()
                        .HasForeignKey("EixoTecnologicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoCurso.Domain.Curso.ModalidadeEducacao", "ModalidadeEducacao")
                        .WithMany()
                        .HasForeignKey("ModalidadeEducacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoCurso.Domain.Curso.ModalidadeEnsino", "ModalidadeEnsino")
                        .WithMany()
                        .HasForeignKey("ModalidadeEnsinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoCurso.Domain.Curso.Segmento", "Segmento")
                        .WithMany()
                        .HasForeignKey("SegmentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoCurso.Domain.Curso.TipoCurso", "TipoCurso")
                        .WithMany()
                        .HasForeignKey("TipoCursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EixoTecnologico");

                    b.Navigation("ModalidadeEducacao");

                    b.Navigation("ModalidadeEnsino");

                    b.Navigation("Segmento");

                    b.Navigation("TipoCurso");
                });
#pragma warning restore 612, 618
        }
    }
}
