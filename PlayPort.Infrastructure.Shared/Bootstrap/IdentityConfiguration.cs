using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using PlayPort.Domain.Entities;
using PlayPort.Infrastructure.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayPort.Infrastructure.Shared.Bootstrap
{
    public static class IdentityConfiguration
    {
        public static void AddConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentityCore<Usuario>()
                    .AddUserStore<ApiDbContext>()
                    .AddRoles<Cargo>() 
                    .AddRoleStore<ApiDbContext>();
        }
    }
}
