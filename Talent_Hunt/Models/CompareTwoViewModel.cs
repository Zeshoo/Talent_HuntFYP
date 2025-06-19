using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talent_Hunt.Models
{

    public class CompareTwoViewModel
    {
        public Submission Submission1 { get; set; }
        public Submission Submission2 { get; set; }

        public Users User1 { get; set; }
        public Users User2 { get; set; }

        public List<Submission> OtherSubmissions { get; set; } // ✅ Add this to show other options for comparison
    }



}