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
    internal class ModalidadeEnsinoService : IModalidadeEnsinoService
    {
        private readonly IModalidadeEnsinoRepository _modalidadeEnsinoRepository;
        private readonly IMapper _mapper;

        public ModalidadeEnsinoService(IModalidadeEnsinoRepository modalidadeEnsinoRepository, IMapper mapper)
        {
            _modalidadeEnsinoRepository = modalidadeEnsinoRepository;
            _mapper = mapper;
        }

        public async Task<List<ModalidadeEnsinoOutputDto>> ObterTodos()
        {
            var modalidades = await _modalidadeEnsinoRepository.ObterTodos();
            return _mapper.Map<List<ModalidadeEnsinoOutputDto>>(modalidades.OrderBy(x => x.Descricao));
        }
    }
}
