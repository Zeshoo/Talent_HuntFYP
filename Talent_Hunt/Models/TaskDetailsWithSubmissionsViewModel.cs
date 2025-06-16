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
    }


}