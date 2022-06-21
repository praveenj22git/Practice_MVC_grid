namespace MVC_PRAC_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insert2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoginEmps",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoginEmps");
        }
    }
}
