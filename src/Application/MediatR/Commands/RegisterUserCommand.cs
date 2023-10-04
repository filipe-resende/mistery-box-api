﻿using MediatR;

namespace Application.MediatR.Commands
{
    public class RegisterUserCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}