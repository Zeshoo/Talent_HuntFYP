using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{
    // Models/UserTaskMarksViewModel.cs
    public class UserTaskMarksViewModel
    {
        
            public int TaskId { get; set; }
            public string TaskDescription { get; set; }
            public string CommitteeMemberName { get; set; }
            public int CommitteeMemberId { get; set; }
            public decimal? HighestMark { get; set; }
        }

    

}