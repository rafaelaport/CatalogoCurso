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
    internal class SegmentoService : ISegmentoService
    {
        private readonly ISegmentoRepository _segmentoRepository;
        private readonly IMapper _mapper;

        public SegmentoService(ISegmentoRepository segmentoRepository, IMapper mapper)
        {
            _segmentoRepository = segmentoRepository;
            _mapper = mapper;
        }

        public async Task<List<SegmentoOutputDto>> ObterTodos()
        {
            var segmentos = await _segmentoRepository.ObterTodos();
            return _mapper.Map<List<SegmentoOutputDto>>(segmentos);
        }
    }
}
