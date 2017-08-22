namespace CoachPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        PhotoFileName = c.String(),
                        Text = c.String(nullable: false),
                        PublicationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostId);
            
            CreateTable(
                "dbo.Proteges",
                c => new
                    {
                        ProtegeId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false, maxLength: 30),
                        HorseName = c.String(nullable: false, maxLength: 20),
                        PhotoFileName = c.String(),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProtegeId);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        TrainerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 15),
                        Surrname = c.String(nullable: false, maxLength: 15),
                        Description = c.String(nullable: false),
                        PhotoFileName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TrainerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainers");
            DropTable("dbo.Proteges");
            DropTable("dbo.Posts");
        }
    }
}
