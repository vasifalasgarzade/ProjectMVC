using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeworkMvc.Models
{
    public class JobDetails
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Desc { get; set; }
        [Required]
        [MaxLength(300)]
        public string Qualification { get; set; }
        [Required]
        [MaxLength(200)]
        public string Responsibilities { get; set; }
   
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
    }
}