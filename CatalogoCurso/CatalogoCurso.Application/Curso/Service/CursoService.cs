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
            await _cursoRepository.Salvar(curso);
            return _mapper.Map<CursoOutputDto>(curso);
        }

        public async Task<CursoOutputDto> Desativar(CursoUpdateDto cursoDto)
        {
            var curso = _mapper.Map<Domain.Curso.Curso>(cursoDto);
            curso.Ativo = false; //Todo: colocar ativo em um metodo apartado
            await _cursoRepository.Desativar(curso);
            return _mapper.Map<CursoOutputDto>(curso);
        }

        public async Task<CursoOutputDto> Atualizar(CursoUpdateDto cursoDto)
        {
            var curso = _mapper.Map<Domain.Curso.Curso>(cursoDto);
            curso.DataAtualizacao = DateTime.Now; //Todo: colocar dataAtualizacao em um metodo apartado
            await _cursoRepository.Atualizar(curso);
            return _mapper.Map<CursoOutputDto>(curso);
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
