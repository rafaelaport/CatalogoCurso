using CatalogoCurso.Application.Curso.Handler.Command;
using CatalogoCurso.Application.Curso.Handler.Query;
using CatalogoCurso.Application.Curso.Service;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Handler
{
    public class CursoHandler : IRequestHandler<CadastrarCursoCommand, CadastrarCursoCommandResponse>,
                                IRequestHandler<AtualizarCursoCommand, AtualizarCursoCommandResponse>,
                                IRequestHandler<ExcluirCursoCommand, ExcluirCursoCommandResponse>,
                                IRequestHandler<ObterTodosCursoQuery, ObterTodosCursoQueryResponse>,
                                IRequestHandler<ObterPorIdCursoQuery, ObterPorIdCursoQueryResponse>
    {

        private readonly ICursoService _cursoService;

        public CursoHandler(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        public async Task<CadastrarCursoCommandResponse> Handle(CadastrarCursoCommand request, CancellationToken cancellationToken)
        {
            var result = await _cursoService.Salvar(request.Curso);

            return new CadastrarCursoCommandResponse(result);
        }

        public async Task<AtualizarCursoCommandResponse> Handle(AtualizarCursoCommand request, CancellationToken cancellationToken)
        {
            var result = await _cursoService.Atualizar(request.Curso);

            return new AtualizarCursoCommandResponse(result);
        }

        public async Task<ExcluirCursoCommandResponse> Handle(ExcluirCursoCommand request, CancellationToken cancellationToken)
        {
            var result = await _cursoService.Desativar(request.Id);

            return new ExcluirCursoCommandResponse(result);
        }

        public async Task<ObterTodosCursoQueryResponse> Handle(ObterTodosCursoQuery request, CancellationToken cancellationToken)
        {
            var result = await _cursoService.ObterTodos();
            return new ObterTodosCursoQueryResponse(result);
        }

        public async Task<ObterPorIdCursoQueryResponse> Handle(ObterPorIdCursoQuery request, CancellationToken cancellationToken)
        {
            var result = await _cursoService.ObterPorId(request.Id);
            return new ObterPorIdCursoQueryResponse(result);
        }
    }
}
