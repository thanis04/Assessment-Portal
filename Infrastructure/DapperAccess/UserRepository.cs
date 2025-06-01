using Core.DTOs;
using Core.Interfaces;
using Core.Models.Enums;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.DapperAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly IConfiguration _configuration;
        public IEnumerable<UserDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetByRole(EndUsers endUsers, string roleName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
