using CatalogoCurso.CrossCutting.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Curso
{
    public class Segmento : Entity<Guid>
    {
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
