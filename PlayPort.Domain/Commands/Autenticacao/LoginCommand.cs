using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayPort.Domain.Commands.Autenticacao
{
    public class LoginCommand
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(a => a.Email)
                .NotEmpty()
                .WithMessage("E-mail obrigatório")
                .EmailAddress()
                .WithMessage("E-mail inválido");

            RuleFor(a => a.Senha)
                .NotEmpty()
                .WithMessage("A Senha é obrigatória");
        }
    }
}
