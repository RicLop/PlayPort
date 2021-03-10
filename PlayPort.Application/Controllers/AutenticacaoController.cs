using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlayPort.Domain.Commands.Autenticacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayPort.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] 
    public class AutenticacaoController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AutenticacaoController(IConfiguration configuration) 
        {
            _configuration = configuration ?? throw new ArgumentNullException(typeof(IConfiguration).Name);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public IActionResult Login(LoginCommand command)
        {
            return Ok(_configuration["SecretKey"]);
        }
    }
}
