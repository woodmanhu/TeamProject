namespace SEIS752Team1Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IniticalCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Date = c.DateTime(nullable: false),
                        Location = c.String(),
                        Url = c.String(maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
