using Microsoft.AspNet.Identity;
using PlayPort.Domain.Commands.Usuario;
using PlayPort.Domain.Entities;
using PlayPort.Domain.Interfaces.Repositories;
using PlayPort.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlayPort.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        readonly UserManager<Usuario> _gerenciadorUsuario;

        public UsuarioService(UserManager<Usuario> gerenciadorUsuario)
        {
            _gerenciadorUsuario = gerenciadorUsuario ?? throw new NullReferenceException(typeof(UserManager<Usuario>).Name);
        }

        public async Task Criar(CriarUsuarioCommand command)
        {
            try
            {
                var usuario = new Usuario()
                {
                    UserName = command.Nome,
                    Email = command.Email
                };

                await _gerenciadorUsuario.CreateAsync(usuario, command.Senha);               
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

    }
}
