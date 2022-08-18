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
    public class ModalidadeEducacaoMapping : IEntityTypeConfiguration<ModalidadeEducacao>
    {
        public void Configure(EntityTypeBuilder<ModalidadeEducacao> builder)
        {
            builder.ToTable("ModalidadeEducacao");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(200);
            builder.Property(x => x.DataCadastro).HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(x => x.Ativo).HasDefaultValue(true).IsRequired();
        }
    }
}
