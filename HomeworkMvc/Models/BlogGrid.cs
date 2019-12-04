using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeworkMvc.Models
{
    public class BlogGrid
    {
        public int Id { get; set; }

        public string HeaderPhoto { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }

        [MaxLength(100)]
        public string PhotoItem { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        [Required]
        [MaxLength(200)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(150)]
        public string WhoFrom { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime DateTime { get; set; }
    }
}