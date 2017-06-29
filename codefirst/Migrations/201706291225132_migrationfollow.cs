namespace codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationfollow : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        oneMyProperty = c.Int(nullable: false),
                        tMyProperty = c.Int(nullable: false),
                        yMyProperty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Class1");
        }
    }
}
