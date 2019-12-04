using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HomeworkMvc.Models
{
    public class PopularCardItem
    {
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Icon { get; set; }
        [Required,MaxLength(255)]
        public string Tittle { get; set; }
    }
}