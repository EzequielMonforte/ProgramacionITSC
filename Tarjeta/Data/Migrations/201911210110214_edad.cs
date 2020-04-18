namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edad : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Born", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Born", c => c.DateTime());
        }
    }
}
