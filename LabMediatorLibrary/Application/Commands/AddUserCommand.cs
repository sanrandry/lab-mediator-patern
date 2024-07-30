

using LabMediatorLibrary.Domain.Interfaces.DTOs;
using MediatR;

namespace LabMediatorLibrary.Application.Commands
{
    public class AddUserCommand : IRequest<UserDTO>
    {
        public AddUserDTO User { get; set; } = null!;
    }
}
