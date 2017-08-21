using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoachPage.Models
{
    public class Protege
    {
        public int ProtegeId { get; set; }
        
        [Required]
        [MaxLength(30, ErrorMessage = "Maksimum 30 znaków")]
        public string StudentName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Maksimum 20 znaków")]
        public string HorseName { get; set; }

        public string PhotoFileName { get; set; }

        [Required]
        public string Description { get; set; }
    }
}