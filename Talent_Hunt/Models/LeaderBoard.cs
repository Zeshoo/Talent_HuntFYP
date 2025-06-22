using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{
    
        public class LeaderBoard
        {
            public int EventId { get; set; }
            public string EventTitle { get; set; }
            public List<TopperInfo> TopThreeToppers { get; set; }
        }

        public class TopperInfo
        {
            public string StudentName { get; set; }
            public double AverageMarks { get; set; }
            public DateTime SubmissionTime { get; set; }
        }
    
}