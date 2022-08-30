using AutoMapper;
using CatalogoCurso.Application.Curso.Dto;
using CatalogoCurso.Application.Curso.Service.Interface;
using CatalogoCurso.Domain.Curso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Service
{
    internal class TipoCursoService : ITipoCursoService
    {
        private readonly ITipoCursoRepository _tipoCursoRepository;
        private readonly IMapper _mapper;

        public TipoCursoService(ITipoCursoRepository tipoCursoRepository, IMapper mapper)
        {
            _tipoCursoRepository = tipoCursoRepository;
            _mapper = mapper;
        }

        public async Task<List<TipoCursoOutputDto>> ObterTodos()
        {
            var tiposCurso = await _tipoCursoRepository.ObterTodos();
            return _mapper.Map<List<TipoCursoOutputDto>>(tiposCurso.OrderBy(x => x.Descricao));
        }
    }
}
