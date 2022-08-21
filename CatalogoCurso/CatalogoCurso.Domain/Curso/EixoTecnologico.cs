using CatalogoCurso.CrossCutting.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Curso
{
    public class EixoTecnologico : Entity<EixoTecnologico>
    {
        public string Descricao { get; set; }
    }
}
