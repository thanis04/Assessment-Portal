using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IFacultyRepository
    {
        IEnumerable<FacultyDTO> GetAll();
        IEnumerable<FacultyDTO> GetByDescription(string description);
    }
}
