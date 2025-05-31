using Core.DTOs;
using Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    internal interface IUserRepository
    {
        IEnumerable<UserDTO> GetAll();
        IEnumerable<UserDTO> GetByUserName(string userName);
        IEnumerable<UserDTO> GetByRole(EndUsers endUsers, string roleName);
    }
}
