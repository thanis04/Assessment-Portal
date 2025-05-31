using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public string EnrollmentNumber { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
    }
}
