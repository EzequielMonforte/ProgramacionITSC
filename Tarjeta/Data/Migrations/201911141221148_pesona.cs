namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pesona : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tarjetas", "Person_Id", "dbo.People");
            DropIndex("dbo.Tarjetas", new[] { "Person_Id" });
            DropPrimaryKey("dbo.Tarjetas");
            AddColumn("dbo.Tarjetas", "DniPersona", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Tarjetas", "NroTarjeta", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Tarjetas", "DniPersona");
            DropColumn("dbo.Tarjetas", "Person_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tarjetas", "Person_Id", c => c.Int());
            DropPrimaryKey("dbo.Tarjetas");
            AlterColumn("dbo.Tarjetas", "NroTarjeta", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Tarjetas", "DniPersona");
            AddPrimaryKey("dbo.Tarjetas", "NroTarjeta");
            CreateIndex("dbo.Tarjetas", "Person_Id");
            AddForeignKey("dbo.Tarjetas", "Person_Id", "dbo.People", "Id");
        }
    }
}
