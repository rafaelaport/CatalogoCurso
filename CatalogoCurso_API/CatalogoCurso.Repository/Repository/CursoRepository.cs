using CatalogoCurso.Domain.Curso;
using CatalogoCurso.Domain.Curso.Repository;
using CatalogoCurso.Repository.Context;
using CatalogoCurso.Repository.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository.Repository
{
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        public CursoRepository(CatalogoCursoContext context) : base(context)
        {

        }

        public override async Task<IEnumerable<Curso>> ObterTodos()
        {
            return await this.Query
                             .Include(c => c.ModalidadeEnsino)
                             .Include(c => c.TipoCurso)
                             .Include(c => c.ModalidadeEducacao)
                             .Include(c => c.EixoTecnologico)
                             .Include(c => c.Segmento)
                             .Where(c => c.Ativo)
                             .AsNoTrackingWithIdentityResolution()
                             .ToListAsync();
        }

        public override async Task<Curso> ObterPorId(Guid id)
        {
            return await this.Query
                             .Include(c => c.ModalidadeEnsino)
                             .Include(c => c.TipoCurso)
                             .Include(c => c.ModalidadeEducacao)
                             .Include(c => c.EixoTecnologico)
                             .Include(c => c.Segmento)
                              .AsNoTrackingWithIdentityResolution()
                              .FirstOrDefaultAsync(x => x.Id == id && x.Ativo);
        }

    }
}
