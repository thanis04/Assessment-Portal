using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class AssessmentCritetiaDTO
    {
        public int CriteriaId { get; set; }
        public int AssessmentId { get; set; }
        public string? Criterion { get; set; }
        public string? Score { get; set; }
        public string? Remarks { get; set; }
    }
}
