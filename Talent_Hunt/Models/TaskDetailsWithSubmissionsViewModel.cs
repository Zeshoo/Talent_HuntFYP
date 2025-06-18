using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{
    public class TaskDetailsWithSubmissionsViewModel
    {
        public string EventTitle { get; set; }
        public string Description { get; set; }
        public List<SubmissionDetail> Submissions { get; set; }
        public int SubmissionID { get; set; }
    }

    public class SubmissionDetail
    {
        public int SubmissionID { get; set; }
        public string UserName { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int? Marks { get; set; }
        public string PathofSubmission { get; set; }

        public string CommitteeMemberName { get; set; }
        public int MarksId { get; set; }               // Corresponds to Marks.Id
            // Corresponds to Marks.SubmissionID (can be same as Id or different)
        public int CommitteeMemberID { get; set; }     // Marks.CommitteeMemberID
        public int Marks1 { get; set; }

        public int? HighestMarks { get; set; }
        public string HighestBy { get; set; }
        public List<MarkDetail> AllMarks { get; set; }

        public class MarkDetail
        {
            public int Marks1 { get; set; }
            public string CommitteeMemberName { get; set; }
        }// Marks.Marks (or Marks1 in your API)
    }


}