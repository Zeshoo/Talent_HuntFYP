using System;
using System.Collections.Generic;

namespace Talent_Hunt.Models
{
    public class TaskDetailViewModel
    {
        public int TaskId { get; set; }
        public string TaskDescription { get; set; }
        public double? TaskAverage { get; set; }
        public string MarksStatus { get; set; }
    }

    public class UserEventMarksViewModel
    {
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        public string EventPic { get; set; }
        public double? OverallAverage { get; set; }
        public string EventStatus { get; set; }

        // Optional, if you still need student info
        public int studentid { get; set; }
        public string UserName { get; set; }

        // Nested task list
        public List<TaskDetailViewModel> TaskDetails { get; set; }
    }
}
