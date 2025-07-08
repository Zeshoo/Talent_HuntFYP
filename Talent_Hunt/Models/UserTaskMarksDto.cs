using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{
    public class UserTaskMarksDto
    {
        public int TaskId { get; set; }
        public string TaskDescription { get; set; }
        public List<CommitteeMarkDto> CommitteeMarks { get; set; }
    }

}