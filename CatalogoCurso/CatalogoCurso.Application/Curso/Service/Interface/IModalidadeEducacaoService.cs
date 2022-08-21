using CatalogoCurso.Application.Curso.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Curso.Service.Interface
{
    public interface IModalidadeEducacaoService
    {
        Task<List<ModalidadeEducacaoOutputDto>> ObterTodos();
    }
}
