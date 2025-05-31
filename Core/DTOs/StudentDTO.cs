using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public string? EnrollmentNumber { get; set; }
        public string? Course { get; set; }
    }
}
