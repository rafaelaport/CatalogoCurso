using CatalogoCurso.Domain.Curso;
using CatalogoCurso.Domain.Curso.Repository;
using CatalogoCurso.Repository.Context;
using CatalogoCurso.Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository.Repository
{
    public class EixoTecnologicoRepository : Repository<EixoTecnologico>, IEixoTecnologicoRepository
    {
        public EixoTecnologicoRepository(CatalogoCursoContext context) : base(context)
        {
        }
    }
}
