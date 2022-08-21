using CatalogoCurso.Application.Curso.Handler.Command;
using CatalogoCurso.Application.Curso.Handler.Query;
using CatalogoCurso.Application.Curso.Service.Interface;
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
                                IRequestHandler<ObterPorIdCursoQuery, ObterPorIdCursoQueryResponse>,
                                IRequestHandler<ObterTodosEixoTecnologicoQuery, ObterTodosEixoTecnologicoQueryResponse>,
                                IRequestHandler<ObterTodosModalidadeEducacaoQuery, ObterTodosModalidadeEducacaoQueryResponse>,
                                IRequestHandler<ObterTodosModalidadeEnsinoQuery, ObterTodosModalidadeEnsinoQueryResponse>,
                                IRequestHandler<ObterTodosSegmentoQuery, ObterTodosSegmentoQueryResponse>,
                                IRequestHandler<ObterTodosTipoCursoQuery, ObterTodosTipoCursoQueryResponse>
    {

        private readonly ICursoService _cursoService;
        private readonly IEixoTecnologicoService _eixoTecnologicoService;
        private readonly IModalidadeEducacaoService _modalidadeEducacaoService;
        private readonly IModalidadeEnsinoService _modalidadeEnsinoService;
        private readonly ISegmentoService _segmentoService;
        private readonly ITipoCursoService _tipoCursoService;

        public CursoHandler(ICursoService cursoService, 
                            IEixoTecnologicoService eixoTecnologicoService, 
                            IModalidadeEducacaoService modalidadeEducacaoService, 
                            IModalidadeEnsinoService modalidadeEnsinoService, 
                            ISegmentoService segmentoService, 
                            ITipoCursoService tipoCursoService)
        {
            _cursoService = cursoService;
            _eixoTecnologicoService = eixoTecnologicoService;
            _modalidadeEducacaoService = modalidadeEducacaoService;
            _modalidadeEnsinoService = modalidadeEnsinoService;
            _segmentoService = segmentoService;
            _tipoCursoService = tipoCursoService;
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

        public async Task<ObterTodosEixoTecnologicoQueryResponse> Handle(ObterTodosEixoTecnologicoQuery request, CancellationToken cancellationToken)
        {
            var result = await _eixoTecnologicoService.ObterTodos();
            return new ObterTodosEixoTecnologicoQueryResponse(result);
        }

        public async Task<ObterTodosModalidadeEducacaoQueryResponse> Handle(ObterTodosModalidadeEducacaoQuery request, CancellationToken cancellationToken)
        {
            var result = await _modalidadeEducacaoService.ObterTodos();
            return new ObterTodosModalidadeEducacaoQueryResponse(result);
        }

        public async Task<ObterTodosModalidadeEnsinoQueryResponse> Handle(ObterTodosModalidadeEnsinoQuery request, CancellationToken cancellationToken)
        {
            var result = await _modalidadeEnsinoService.ObterTodos();
            return new ObterTodosModalidadeEnsinoQueryResponse(result);
        }

        public async Task<ObterTodosSegmentoQueryResponse> Handle(ObterTodosSegmentoQuery request, CancellationToken cancellationToken)
        {
            var result = await _segmentoService.ObterTodos();
            return new ObterTodosSegmentoQueryResponse(result);
        }

        public async Task<ObterTodosTipoCursoQueryResponse> Handle(ObterTodosTipoCursoQuery request, CancellationToken cancellationToken)
        {
            var result = await _tipoCursoService.ObterTodos();
            return new ObterTodosTipoCursoQueryResponse(result);
        }
    }
}
