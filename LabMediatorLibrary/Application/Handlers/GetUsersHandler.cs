using LabMediatorLibrary.Application.Queries;
using LabMediatorLibrary.Domain.Interfaces.DTOs;
using LabMediatorLibrary.Domain.Interfaces.Repository;
using MediatR;

namespace LabMediatorLibrary.Application.Handlers
{
    public class GetUsersHandler : IRequestHandler<GetUsersQuery, List<UserDTO>>
    {
        private readonly IDataAcessRepository _dataAcessRepository;

        public GetUsersHandler(IDataAcessRepository dataAcessRepository)
        {
            _dataAcessRepository = dataAcessRepository;
        }
        public Task<List<UserDTO>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
           return Task.FromResult(_dataAcessRepository.GetUsers());
        }
    }
}
