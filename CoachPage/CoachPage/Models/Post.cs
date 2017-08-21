using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoachPage.Models
{
    public class Post
    {
        public int PostId { get; set; }

        public string PhotoFileName { get; set; }
        
        [Required]
        public string Text { get; set; }
        
        [Required]
        public DateTime PublicationDate { get; set; }

    }
}