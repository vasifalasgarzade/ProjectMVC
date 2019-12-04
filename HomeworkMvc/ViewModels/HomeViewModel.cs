using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeworkMvc.Models;

namespace HomeworkMvc.ViewModels
{
    public class HomeViewModel
    {
        public Home Home { get; set; }
        public List<PopularCardItem> PopularCardItems { get; set; }
        public List<FindYourJobs> FindYourJobs { get; set; }
        public List<HowItWork> HowItWorks { get; set; }
        public List<OurStories> OurStories { get; set; }
        public List<OurClient> OurClients { get; set; }
        public List<OurCareer> OurCareers { get; set; }


    }
}