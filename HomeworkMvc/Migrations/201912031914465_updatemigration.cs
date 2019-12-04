namespace HomeworkMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CandidateListings", "Text");
            DropColumn("dbo.CandidateListings", "HeaderPhoto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CandidateListings", "HeaderPhoto", c => c.String(maxLength: 200));
            AddColumn("dbo.CandidateListings", "Text", c => c.String(nullable: false, storeType: "ntext"));
        }
    }
}
