using Microsoft.EntityFrameworkCore;
using PlayPort.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayPort.Infrastructure.Data.Contexts
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios;
        public DbSet<Cargo> Cargos;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
