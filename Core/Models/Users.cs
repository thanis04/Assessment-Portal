using Core.Models.Enums;

namespace Core.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public EndUsers Role { get; set; }
    }
}
