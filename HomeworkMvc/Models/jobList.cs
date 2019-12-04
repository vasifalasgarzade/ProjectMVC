using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeworkMvc.Models
{
    public class jobList
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Photo { get; set; }
       
      
        [Required]
        [MaxLength(150)]
        public string Work { get; set; }
        [Required]
        [MaxLength(400)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(300)]
        public string Location { get; set; }
        [Required]
        [MaxLength(140)]
        public string Date { get; set; }
        [Required]
        [MaxLength(150)]
        public string Working { get; set; }

        [NotMapped]
        public HttpPostedFileBase PhotoUpoad { get; set; }


    }
}