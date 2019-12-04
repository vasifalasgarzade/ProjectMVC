using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HomeworkMvc.Models
{
    public class Home
    {
        [Required]
        public int Id { get; set; }
        [Required,MaxLength(255)]
        public string Bgphoto { get; set; }

        [Required, MaxLength(355)]
        public string Desc { get; set; }

        [Required, MaxLength(255)]
        public string Tittle { get; set; }

        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }

    }
}