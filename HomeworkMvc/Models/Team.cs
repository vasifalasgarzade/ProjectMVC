using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeworkMvc.Models
{
    public class Team
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Work { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Icon { get; set; }
    }
}