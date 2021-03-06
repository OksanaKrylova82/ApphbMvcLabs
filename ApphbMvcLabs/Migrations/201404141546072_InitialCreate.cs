namespace ApphbMvcLabs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    ID = c.Guid(nullable: false),
                    Email = c.String(),
                    Password = c.String(),
                })
                .PrimaryKey(t => t.ID);

        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
