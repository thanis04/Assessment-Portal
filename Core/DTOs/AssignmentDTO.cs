using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class AssignmentDTO
    {
        public int AssignmentId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateOnly DueDate { get; set; }
        public int FacultyId { get; set; }
    }
}
