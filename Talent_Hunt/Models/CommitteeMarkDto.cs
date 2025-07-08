using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{
    public class CommitteeMarkDto
    {
        public int CommitteeMemberId { get; set; }
        public string CommitteeMemberName { get; set; }
        public decimal LatestMarks { get; set; }
        public string Feedback { get; set; }
    }
}