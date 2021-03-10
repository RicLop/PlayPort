using PlayPort.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayPort.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        public IQueryable<Usuario> GetAll();

        public Usuario GetById(string Id);

        public Task InsertAsync(Usuario usuario);

        public void Update(Usuario usuario);
    }
}
