using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{
   
        public class UserEventMarksViewModel
        {
      public int EventId { get; set; }
        public int studentid {  get; set; }
        public string EventTitle { get; set; }
        public string EventPic { get; set; }
        public string UserName { get; set; }
        public double? Marks { get; set; }
    }
    


}