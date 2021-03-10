using PlayPort.Domain.Entities;
using PlayPort.Domain.Interfaces.Repositories;
using PlayPort.Infrastructure.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayPort.Infrastructure.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApiDbContext _context;

        public UsuarioRepository(ApiDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(typeof(ApiDbContext).Name);
        }

        public IQueryable<Usuario> GetAll() =>        
            _context.Usuarios.AsQueryable();        

        public Usuario GetById(string Id) =>
            _context.Usuarios.AsQueryable().Where(x => x.Id == Id).FirstOrDefault();

        public async Task InsertAsync(Usuario usuario) =>        
            _context.Usuarios.AddAsync(usuario);       

        public void Update(Usuario usuario) =>        
            _context.Usuarios.Update(usuario);        
    }
}
