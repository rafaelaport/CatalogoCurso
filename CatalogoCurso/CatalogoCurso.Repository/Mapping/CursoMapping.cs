using CatalogoCurso.Domain.Curso;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository.Mapping
{
    public class CursoMapping : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder) 
        {
            builder.ToTable("Curso");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.CargaHoraria).IsRequired();
            builder.Property(x => x.Objetivo).HasMaxLength(500);
            builder.Property(x => x.Bibliografia).HasMaxLength(500);
            builder.Property(x => x.Avaliacao).HasMaxLength(500);
            builder.Property(x => x.Certificacao).HasMaxLength(500);

            builder.HasOne(x => x.ModalidadeEnsino).WithMany().HasForeignKey(y => y.ModalidadeEnsinoId);
            builder.HasOne(x => x.TipoCurso).WithMany().HasForeignKey(y => y.TipoCursoId);
            builder.HasOne(x => x.ModalidadeEducacao).WithMany().HasForeignKey(y => y.ModalidadeEducacaoId);
            builder.HasOne(x => x.EixoTecnologico).WithMany().HasForeignKey(y => y.EixoTecnologicoId);
            builder.HasOne(x => x.Segmento).WithMany().HasForeignKey(y => y.SegmentoId);

            builder.Property(x => x.DataCadastro).HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(x => x.DataAtualizacao).IsRequired();
            builder.Property(x => x.Ativo).HasDefaultValue(true).IsRequired();


        }
    }
}
