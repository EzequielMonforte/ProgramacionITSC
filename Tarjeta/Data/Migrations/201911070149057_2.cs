namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Tipo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Tipo");
        }
    }
}
