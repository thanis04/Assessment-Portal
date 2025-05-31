using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<StudentDTO> GetAll();
        IEnumerable<StudentDTO> Get(string enrollmentNo);
    }
}
