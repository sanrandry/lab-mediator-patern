

using LabMediatorLibrary.Application.Commands;
using LabMediatorLibrary.Domain.Interfaces.DTOs;
using LabMediatorLibrary.Domain.Interfaces.Repository;
using MediatR;

namespace LabMediatorLibrary.Application.Handlers
{
    public class AddUserHandler : IRequestHandler<AddUserCommand, UserDTO>
    {
        private readonly IDataAcessRepository _dataAcessRepository;

        public AddUserHandler(IDataAcessRepository dataAcessRepository)
        {
            _dataAcessRepository = dataAcessRepository;
        }
        public Task<UserDTO> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAcessRepository.AddUser(request.User));
        }
    }
}
