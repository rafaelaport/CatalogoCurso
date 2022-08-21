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
    public class EixoTecnologicoService : IEixoTecnologicoService
    {
        private readonly IEixoTecnologicoRepository _eixoTecnologicoRepository;
        private readonly IMapper _mapper;

        public EixoTecnologicoService(IEixoTecnologicoRepository eixoTecnologicoRepository, IMapper mapper)
        {
            _eixoTecnologicoRepository = eixoTecnologicoRepository;
            _mapper = mapper;
        }

        public async Task<List<EixoTecnologicoOutputDto>> ObterTodos()
        {
            var eixos = await _eixoTecnologicoRepository.ObterTodos();
            return _mapper.Map<List<EixoTecnologicoOutputDto>>(eixos);
        }
    }
}
