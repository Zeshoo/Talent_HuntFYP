using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{
   
        public class UserEventMarksViewModel
        {
            public string EventTitle { get; set; }
            public int? Marks { get; set; }  // nullable, in case not marked yet
        }
    


}