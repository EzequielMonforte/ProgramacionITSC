namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class area : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Tarjetas");
            AddColumn("dbo.Tarjetas", "persona_Id", c => c.Int());
            AlterColumn("dbo.Tarjetas", "NroTarjeta", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Tarjetas", "NroTarjeta");
            CreateIndex("dbo.Tarjetas", "persona_Id");
            AddForeignKey("dbo.Tarjetas", "persona_Id", "dbo.People", "Id");
            DropColumn("dbo.Tarjetas", "DniPersona");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tarjetas", "DniPersona", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Tarjetas", "persona_Id", "dbo.People");
            DropIndex("dbo.Tarjetas", new[] { "persona_Id" });
            DropPrimaryKey("dbo.Tarjetas");
            AlterColumn("dbo.Tarjetas", "NroTarjeta", c => c.Int(nullable: false));
            DropColumn("dbo.Tarjetas", "persona_Id");
            AddPrimaryKey("dbo.Tarjetas", "DniPersona");
        }
    }
}
