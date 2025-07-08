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
        public List<SubmissionViewModel> Submissions { get; set; }
    }

    public class SubmissionViewModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; } // You need this for links
        public string StudentName { get; set; }
        public int CommitteeEvaluators { get; set; }
        public double AverageMarks { get; set; }
        public DateTime SubmissionTime { get; set; }
        public string PathofSubmission { get; set; }
        public int TaskID { get; set; }
        public string UserName { get; set; }

        public string UserID { get; set; }

        public string Details { get; set; }


        public string EventTitle { get; set; }


        public List<TaskMarkViewModel> TaskMarks { get; set; }

       
           
        

    }

    public class TaskMarkViewModel
    {
        public int TaskId { get; set; }
        public string TaskDescription { get; set; }
        public List<CommitteeMarkViewModel> CommitteeMarks { get; set; }
    }

    public class CommitteeMarkViewModel
    {
        public int CommitteeMemberId { get; set; }
        public string CommitteeMemberName { get; set; }
        public int? Marks { get; set; }
        public string Feedback { get; set; }
    }


}