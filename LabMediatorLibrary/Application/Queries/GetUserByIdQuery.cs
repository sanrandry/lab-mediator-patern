using LabMediatorLibrary.Domain.Interfaces.DTOs;
using MediatR;

namespace LabMediatorLibrary.Application.Queries
{
    public class GetUserByIdQuery: IRequest<UserDTO>
    {
        public int Id { get; set; }
    }
}
