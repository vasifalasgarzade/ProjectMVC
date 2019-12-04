using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeworkMvc.Models;

namespace HomeworkMvc.ViewModels
{
    public class JobViewModel
    {
        public List<jobList> JobLists { get; set; }
        public List<JobsGrid> JobsGrids { get; set; }
        public List<JobDetails> jobDetails { get; set; }
        public JobDetails jobDetail { get; set; }

    }
}