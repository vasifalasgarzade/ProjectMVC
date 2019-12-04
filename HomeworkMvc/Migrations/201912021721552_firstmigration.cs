namespace HomeworkMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fullname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        LastLoginDate = c.DateTime(nullable: false),
                        Token = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BlogGrids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HeaderPhoto = c.String(),
                        PhotoItem = c.String(maxLength: 100),
                        Title = c.String(nullable: false, maxLength: 200),
                        Text = c.String(nullable: false, storeType: "ntext"),
                        Icon = c.String(nullable: false, maxLength: 200),
                        WhoFrom = c.String(nullable: false, maxLength: 150),
                        DateTime = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BlogLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(nullable: false, maxLength: 200),
                        PublishDate = c.String(nullable: false, maxLength: 200),
                        PhotoItem = c.String(maxLength: 200),
                        Title = c.String(nullable: false, maxLength: 200),
                        Text = c.String(nullable: false, storeType: "ntext"),
                        Comment = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CandidateListings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 200),
                        PhotoItem = c.String(maxLength: 200),
                        Icon = c.String(nullable: false, maxLength: 200),
                        Work = c.String(nullable: false, maxLength: 200),
                        Location = c.String(nullable: false, maxLength: 200),
                        Price = c.String(nullable: false, maxLength: 200),
                        Skills = c.String(nullable: false, maxLength: 200),
                        Text = c.String(nullable: false, storeType: "ntext"),
                        HeaderPhoto = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployersLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhotoItem = c.String(maxLength: 200),
                        FullName = c.String(nullable: false, maxLength: 200),
                        Work = c.String(nullable: false, maxLength: 200),
                        Icon = c.String(nullable: false, maxLength: 200),
                        Location = c.String(nullable: false, maxLength: 200),
                        Rating = c.String(nullable: false, maxLength: 50),
                        HeaderPhoto = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Faqs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(nullable: false, maxLength: 200),
                        Question = c.String(nullable: false, maxLength: 400),
                        Answer = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FindYourJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        MiniTittle = c.String(),
                        MiniDesc = c.String(),
                        LocationIcon = c.String(),
                        Location = c.String(),
                        Count = c.String(),
                        CountIcon = c.String(),
                        Fulltime = c.String(),
                        Experience = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Homes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Bgphoto = c.String(nullable: false, maxLength: 255),
                        Desc = c.String(nullable: false, maxLength: 355),
                        Tittle = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HowItWorks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Photo = c.String(),
                        Tiitle = c.String(),
                        Desc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JobDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false, storeType: "ntext"),
                        Desc = c.String(nullable: false, storeType: "ntext"),
                        Qualification = c.String(nullable: false, maxLength: 300),
                        Responsibilities = c.String(nullable: false, maxLength: 200),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.jobLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 150),
                        Work = c.String(nullable: false, maxLength: 150),
                        Title = c.String(nullable: false, maxLength: 400),
                        Icon = c.String(nullable: false, maxLength: 200),
                        Location = c.String(nullable: false, maxLength: 300),
                        Date = c.String(nullable: false, maxLength: 140),
                        Working = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JobsGrids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 300),
                        Icon = c.String(nullable: false, maxLength: 200),
                        Work = c.String(nullable: false, maxLength: 200),
                        Location = c.String(nullable: false, maxLength: 200),
                        Count = c.String(nullable: false, maxLength: 200),
                        Experience = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OurCareers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Tittle = c.String(),
                        desc = c.String(),
                        Date = c.DateTime(nullable: false),
                        dateicon = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OurClients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OurStories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Photo = c.String(),
                        Tittle = c.String(),
                        MiniDesc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PopularCardItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Icon = c.String(nullable: false, maxLength: 255),
                        Tittle = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 200),
                        FullName = c.String(nullable: false, maxLength: 200),
                        Work = c.String(nullable: false, maxLength: 200),
                        Title = c.String(nullable: false, maxLength: 200),
                        Icon = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
            DropTable("dbo.PopularCardItems");
            DropTable("dbo.OurStories");
            DropTable("dbo.OurClients");
            DropTable("dbo.OurCareers");
            DropTable("dbo.JobsGrids");
            DropTable("dbo.jobLists");
            DropTable("dbo.JobDetails");
            DropTable("dbo.HowItWorks");
            DropTable("dbo.Homes");
            DropTable("dbo.FindYourJobs");
            DropTable("dbo.Faqs");
            DropTable("dbo.EmployersLists");
            DropTable("dbo.CandidateListings");
            DropTable("dbo.BlogLists");
            DropTable("dbo.BlogGrids");
            DropTable("dbo.Admins");
        }
    }
}
