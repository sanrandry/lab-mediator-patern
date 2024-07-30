

namespace LabMediatorLibrary.Domain.Interfaces.DTOs
{
    public class AddUserDTO 
    {
        public required string Name { get; set; }
        public required string Email { get; set; }

        public string? ProfilUrl { get; set; }
    }
}
