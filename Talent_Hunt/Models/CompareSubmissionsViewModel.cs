using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{
    // Models/CompareSubmissionsViewModel.cs
   
        public class CompareSubmissionsViewModel
        {
            public SubmissionViewModel SelectedSubmission { get; set; }
            public List<Submission> OtherSubmissions { get; set; }
        }
    
}
