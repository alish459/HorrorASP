namespace MVC.Connecntion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersiainMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        PageID = c.Int(nullable: false, identity: true),
                        PageName = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PageID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pages");
        }
    }
}
