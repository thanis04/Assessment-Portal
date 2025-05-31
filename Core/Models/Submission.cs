using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Submission
    {
        public int SubmissionId { get; set; }
        public int StudentId { get; set; }
        public int AssignmentId { get; set; }
        public DateOnly SubmissionDate { get; set; }
    }
}
