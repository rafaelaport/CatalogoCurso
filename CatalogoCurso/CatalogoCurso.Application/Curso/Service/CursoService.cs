using AutoMapper;
using CatalogoCurso.Application.Curso.Dto;
using CatalogoCurso.Domain.Curso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Service
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IMapper _mapper;

        public CursoService(ICursoRepository cursoRepository, IMapper mapper)
        {
            _cursoRepository = cursoRepository;
            _mapper = mapper;
        }

        public async Task<CursoOutputDto> Salvar(CursoInputDto cursoDto)
        {
            var curso = _mapper.Map<Domain.Curso.Curso>(cursoDto);
            curso = curso.Cadastrar(curso);
            await _cursoRepository.Salvar(curso);
            return _mapper.Map<CursoOutputDto>(curso);
        }

        public async Task<CursoOutputDto> Desativar(Guid cursoId)
        {
            var curso = await _cursoRepository.ObterPorId(cursoId);
            curso.Destivar();
            await _cursoRepository.Desativar(curso);
            return _mapper.Map<CursoOutputDto>(curso);
        }

        public async Task<CursoOutputDto> Atualizar(CursoUpdateDto cursoDto)
        {
            var cursoBD = await _cursoRepository.ObterPorId(cursoDto.Id);
            var curso = _mapper.Map<Domain.Curso.Curso>(cursoDto);

            cursoBD.Atualizar(curso);

            await _cursoRepository.Atualizar(cursoBD);
            return _mapper.Map<CursoOutputDto>(cursoBD);
        }

        public async Task<CursoOutputDto> ObterPorId(Guid cursoId)
        {
            var curso = await _cursoRepository.ObterPorId(cursoId);
            return _mapper.Map<CursoOutputDto>(curso);
        }
        public async Task<List<CursoOutputDto>> ObterTodos()
        {
            var curso = await _cursoRepository.ObterTodos();
            return _mapper.Map<List<CursoOutputDto>>(curso);
        }

    }
}
