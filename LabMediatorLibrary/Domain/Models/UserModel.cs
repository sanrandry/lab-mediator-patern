
namespace LabMediatorLibrary.Domain.Models
{
    internal class UserModel
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

        public string? ProfilUrl { get; set; }

        public required string Password { get; set; }
    }
}
