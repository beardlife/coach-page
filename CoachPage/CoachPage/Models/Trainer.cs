using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoachPage.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Maksimum 15 znaków")]
        public string Name { get; set; }

        [Required]
        [MaxLength(15,ErrorMessage="Maksimum 15 znaków")]
        public string Surrname { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string PhotoFileName { get; set; }

    }
}