using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeworkMvc.Models
{
    public class EmployersList
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string PhotoItem { get; set; }
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Work { get; set; }
        [Required]
        [MaxLength(200)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(200)]
        public string Location { get; set; }
        [Required]
        [MaxLength(50)]
        public string Rating { get; set; }
        [MaxLength(200)]
        public string HeaderPhoto { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
    }
}