using CatalogoCurso.Application.Curso.Service;
using CatalogoCurso.Application.Curso.Service.Interface;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Application.ConfigurationModule).Assembly);
            services.AddMediatR(typeof(Application.ConfigurationModule).Assembly);

            services.AddScoped<ICursoService, CursoService>();
            services.AddScoped<IEixoTecnologicoService, EixoTecnologicoService>();
            services.AddScoped<IModalidadeEducacaoService, ModalidadeEducacaoService>();
            services.AddScoped<IModalidadeEnsinoService, ModalidadeEnsinoService>();
            services.AddScoped<ISegmentoService, SegmentoService>();
            services.AddScoped<ITipoCursoService, TipoCursoService>();

            return services;
        }
    }
}
