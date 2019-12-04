using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HomeworkMvc.Models;

namespace HomeworkMvc.Data
{
    public class MvcProjectdb:DbContext
    {
        public MvcProjectdb() : base("MvcProjectdb")
        {
        }
        public DbSet<BlogGrid> BlogGrids { get; set; }
        public DbSet<BlogList> BlogLists { get; set; }
        public DbSet<CandidateListing> CandidateListings { get; set; }
        public DbSet<EmployersList> EmployersLists { get; set; }
        public DbSet<Faqs> Faqs { get; set; }
        public DbSet<FindYourJobs> FindYourJobs { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<HowItWork> HowItWorks { get; set; }
        public DbSet<JobDetails> JobDetails { get; set; }
        public DbSet<jobList> JobLists { get; set; }
        public DbSet<JobsGrid> JobsGrids { get; set; }
        public DbSet<OurCareer> OurCareers { get; set; }
        public DbSet<OurClient> OurClients { get; set; }
        public DbSet<OurStories> OurStories { get; set; }
        public DbSet<PopularCardItem> PopularCardItems { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}