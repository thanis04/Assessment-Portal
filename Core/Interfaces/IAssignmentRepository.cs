using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAssignmentRepository
    {
        IEnumerable<AssignmentDTO> GetAll();
        IEnumerable<AssignmentDTO> Get(DateOnly dueDate);
        IEnumerable<AssignmentDTO> CreateAssignment(AssignmentDTO assignmentDTO);

    }
}
