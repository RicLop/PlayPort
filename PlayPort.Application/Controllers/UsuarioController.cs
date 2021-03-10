using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlayPort.Domain.Commands.Usuario;
using PlayPort.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayPort.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service ?? throw new NullReferenceException(typeof(IUsuarioService).Name);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Criar(CriarUsuarioCommand command)
        {
            return Ok(_service.Criar(command));
        }
    }
}
