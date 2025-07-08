using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{
    public class EventTaskMarksResponse
    {
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        public List<UserTaskMarksDto> Tasks { get; set; }
    }

}