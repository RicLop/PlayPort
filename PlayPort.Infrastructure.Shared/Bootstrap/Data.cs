using PlayPort.Infrastructure.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayPort.Infrastructure.Shared.Bootstrap
{
    public static class Data
    {
        public static void Initialize(this ApiDbContext context)
        {
            context.Database.EnsureCreated();
        }

        public static void SeedData(ApiDbContext context)
        {

        }        
    }
}
