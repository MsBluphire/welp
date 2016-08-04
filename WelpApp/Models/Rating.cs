using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WelpApp.Models
{
    public class Rating
    {
        // properties
        public int RatingID { get; set; }
        public string ApplicationUserID { get; set; }
        public int BusinessID { get; set; }
        public short? StarReview { get; set; }
        public string TextReview { get; set; }

        // navigation properties
        public virtual ApplicationUser User { get; set; }
        public virtual Business Business { get; set; }
    }
}