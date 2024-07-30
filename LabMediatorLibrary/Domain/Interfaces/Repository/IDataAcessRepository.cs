using LabMediatorLibrary.Domain.Interfaces.DTOs;

namespace LabMediatorLibrary.Domain.Interfaces.Repository
{
    public interface IDataAcessRepository
    {
        public List<UserDTO> GetUsers();
        public UserDTO? GetUser(int id);

        public  UserDTO AddUser(AddUserDTO user);
    }
}
