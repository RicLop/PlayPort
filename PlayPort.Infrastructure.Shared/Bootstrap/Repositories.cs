using Microsoft.Extensions.DependencyInjection;
using PlayPort.Domain.Interfaces.Repositories;
using PlayPort.Domain.Interfaces.Services;
using PlayPort.Domain.Services;
using PlayPort.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayPort.Infrastructure.Shared.Bootstrap
{
    public static class Repositories
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
