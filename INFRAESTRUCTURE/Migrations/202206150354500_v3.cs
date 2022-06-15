namespace INFRAESTRUCTURE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "studentCode", c => c.String(nullable: false));
            AddColumn("dbo.Students", "studentLastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "studentLastName");
            DropColumn("dbo.Students", "studentCode");
        }
    }
}
