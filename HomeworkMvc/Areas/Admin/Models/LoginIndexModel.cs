using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeworkMvc.Areas.Admin.Models
{
    public class LoginIndexModel
    {
        [Required(ErrorMessage = "Email xanasi bow qoyula bilmez")]
        [MaxLength(50, ErrorMessage = "Max 50 xarakter")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "parol bos qoyula bilmez")]
        [MaxLength(50, ErrorMessage = "Max 50 xarakter")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}