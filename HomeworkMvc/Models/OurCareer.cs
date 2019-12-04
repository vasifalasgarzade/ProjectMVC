using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkMvc.Models
{
    public class OurCareer
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Tittle { get; set; }
        public string desc { get; set; }
        public DateTime Date { get; set; }
        public string dateicon { get; set; }
    }
}