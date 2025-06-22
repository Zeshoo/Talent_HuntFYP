using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{
    public class EventReportViewModel
    {
        public string Title { get; set; }
        public DateTime EventDate { get; set; }
        public int ParticipantCount { get; set; }
        public List<SubmissionReportItem> Submissions { get; set; }
    }

    public class SubmissionReportItem
    {
        public string StudentName { get; set; }
        public int CommitteeEvaluators { get; set; }
        public double AverageMarks { get; set; }
        public DateTime SubmissionTime { get; set; }
        public string PathofSubmission { get; set; }
    }


}