using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{
    public class CommitteeMarkDetailDto
    {
        public int TaskId { get; set; }
        public int StudentId { get; set; }
        public int CommitteeMemberId { get; set; }
        public string CommitteeMemberName { get; set; }
        public int? Mark { get; set; }
        public string Feedback { get; set; }
    }

}