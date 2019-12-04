using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeworkMvc.Models
{
    public class CandidateListing
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; }
        [MaxLength(200)]
        public string PhotoItem { get; set; }
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
        public string Price { get; set; }
        [Required]
        [MaxLength(200)]
        public string Skills { get; set; }
   
    
        
    }
}