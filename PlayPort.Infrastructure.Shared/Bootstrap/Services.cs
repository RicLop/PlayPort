using Microsoft.Extensions.DependencyInjection;
using PlayPort.Domain.Interfaces.Services;
using PlayPort.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayPort.Infrastructure.Shared.Bootstrap
{
    public static class Services
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}
