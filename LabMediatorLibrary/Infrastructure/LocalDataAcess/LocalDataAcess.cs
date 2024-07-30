using LabMediatorLibrary.Domain.Interfaces.DTOs;
using LabMediatorLibrary.Domain.Interfaces.Repository;
using LabMediatorLibrary.Domain.Models;

namespace LabMediatorLibrary.Infrastructure.LocalDataAcess
{
    public class LocalDataAcess : IDataAcessRepository
    {
        private List<UserModel> _users = new List<UserModel>()
        {
            new UserModel()
            {
                Id = 1,
                Name = "John Doe",
                Email = "joh@gmial.com",
                ProfilUrl = "https://www.google.com",
                Password = "123456"
            },
            new UserModel()
            {
                Id = 2,
                Name = "Jane Doe",
                Email = "jane@gmail.com",
                ProfilUrl = "https://www.google.com",
                Password = "123456"
            }
        };
        public UserDTO AddUser(AddUserDTO user)
        {
            var id = _users.Count + 1;
            _users.Add(new UserModel()
            {
                Id = id,
                Name = user.Name,
                Email = user.Email,
                ProfilUrl = user.ProfilUrl,
                Password = "temporaryPassword"
            });
            return new UserDTO()
            {
                Id = id,
                Name = user.Name,
                Email = user.Email,
                ProfilUrl = user.ProfilUrl
            };
        }

        public UserDTO? GetUser(int id)
        {
            UserModel? userModel = _users.FirstOrDefault(x => x.Id == id);
            if (userModel == null)
            {
                return null;
            }
            return new UserDTO()
            {
                Id = userModel.Id,
                Name = userModel.Name,
                Email = userModel.Email,
                ProfilUrl = userModel.ProfilUrl
            };

        }

        public List<UserDTO> GetUsers()
        {
           return _users.Select(x => new UserDTO()
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                ProfilUrl = x.ProfilUrl
            }).ToList();
        }
    }
}
