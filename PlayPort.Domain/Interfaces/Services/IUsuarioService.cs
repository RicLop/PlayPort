using PlayPort.Domain.Commands.Usuario;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlayPort.Domain.Interfaces.Services
{
    public interface IUsuarioService
    {
        public Task Criar(CriarUsuarioCommand command);
    }
}
