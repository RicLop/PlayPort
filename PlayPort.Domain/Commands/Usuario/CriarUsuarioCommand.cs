using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayPort.Domain.Commands.Usuario
{
    public class CriarUsuarioCommand
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    public class CriarUsuarioCommandValidator : AbstractValidator<CriarUsuarioCommand>
    {
        public CriarUsuarioCommandValidator()
        {
            RuleFor(a => a.Nome)
                .NotEmpty()
                .WithMessage("Nome de usuário obrigatório.");

            RuleFor(a => a.Email)
                .NotEmpty()
                .WithMessage("E-mail obrigatório.")
                .EmailAddress()
                .WithMessage("E-mail inválido.");

            RuleFor(a => a.Senha)
                .NotEmpty()
                .WithMessage("A Senha é obrigatória.");
        }
    }
}
