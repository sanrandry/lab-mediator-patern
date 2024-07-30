
using LabMediatorLibrary.Application.Queries;
using LabMediatorLibrary.Domain.Interfaces.DTOs;
using LabMediatorLibrary.Domain.Interfaces.Repository;
using MediatR;

namespace LabMediatorLibrary.Application.Handlers
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserDTO?>
    {
        private readonly IDataAcessRepository _dataAcessRepository;

        public GetUserByIdHandler(IDataAcessRepository dataAcessRepository)
        {
            _dataAcessRepository = dataAcessRepository;
        }
        public Task<UserDTO?> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = _dataAcessRepository.GetUser(request.Id);
            return Task.FromResult(user);
        }
    }
}
