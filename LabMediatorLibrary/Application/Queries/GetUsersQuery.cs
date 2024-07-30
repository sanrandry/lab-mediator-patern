

using LabMediatorLibrary.Domain.Interfaces.DTOs;
using MediatR;

namespace LabMediatorLibrary.Application.Queries
{
    public class GetUsersQuery : IRequest<List<UserDTO>>
    {
    }
}
