using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlayPort.Infrastructure.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayPort.Infrastructure.Shared.Bootstrap
{
    public static class FrameworkNpgsql
    {
        public static void AddFrameworkNpgsql(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFrameworkNpgsql()
                    .AddDbContext<ApiDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DbContext")));
        }
    }
}
