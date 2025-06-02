using System.Data;
using Core.DTOs;
using Core.Interfaces;
using Core.Models;
using Core.Models.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using Dapper;


namespace Infrastructure.DapperAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly IConfiguration _configuration;

        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;    
        }

        public async Task<IEnumerable<Users>> GetAllUsersAsync()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var users = await connection.QueryAsync<Users>(
                "sp_GetAllUsers",
                commandType: CommandType.StoredProcedure);

            return users;
        }

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
