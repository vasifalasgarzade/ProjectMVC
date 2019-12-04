using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeworkMvc.Models
{
    public class JobsGrid
    {
        public int Id { get; set; }
        [MaxLength(300)]
        public string Photo { get; set; }
      
        [Required]
        [MaxLength(200)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(200)]
        public string Work { get; set; }
        [Required]
        [MaxLength(200)]
        public string Location { get; set; }
        [Required]
        [MaxLength(200)]
        public string Count { get; set; }
        [Required]
        [MaxLength(150)]
        public string Experience { get; set; }

        [NotMapped]
        public HttpPostedFileBase PhotoUplad { get; set; }
    }
}