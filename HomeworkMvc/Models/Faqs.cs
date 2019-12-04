using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeworkMvc.Models
{
    public class Faqs
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Required]
        [MaxLength(400)]
        public string Question { get; set; }
        [Required]
        [MaxLength(400)]
        public string Answer { get; set; }
    }
}