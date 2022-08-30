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
    internal class ModalidadeEducacaoService : IModalidadeEducacaoService
    {
        private readonly IModalidadeEducacaoRepository _modalidadeEducacaoRepository;
        private readonly IMapper _mapper;

        public ModalidadeEducacaoService(IModalidadeEducacaoRepository modalidadeEducacaoRepository, IMapper mapper)
        {
            _modalidadeEducacaoRepository = modalidadeEducacaoRepository;
            _mapper = mapper;
        }

        public async Task<List<ModalidadeEducacaoOutputDto>> ObterTodos()
        {
            var modalidades = await _modalidadeEducacaoRepository.ObterTodos();
            return _mapper.Map<List<ModalidadeEducacaoOutputDto>>(modalidades.OrderBy(x => x.Descricao));
        }
    }
}
