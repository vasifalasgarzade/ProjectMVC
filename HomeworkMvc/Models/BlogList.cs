using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeworkMvc.Models
{
    public class BlogList
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase UploadPhoto { get; set; }
        [Required]
        [MaxLength(200)]
        public string PublishDate { get; set; }
        [MaxLength(200)]
        public string PhotoItem { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        [Required]
        [MaxLength(200)]
        public string Comment { get; set; }
    }
}