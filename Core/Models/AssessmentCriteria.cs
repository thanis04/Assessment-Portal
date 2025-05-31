using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class AssessmentCriteria
    {
        public int CriteriaId { get; set; }
        public int AssessmentId { get; set; }
        public string Criterion { get; set; } = string.Empty;
        public string Score { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
    }
}
