namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Dni = c.String(),
                        Genre = c.String(),
                        Born = c.DateTime(nullable: false),
                        Cuit = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tarjetas",
                c => new
                    {
                        NroTarjeta = c.Int(nullable: false, identity: true),
                        Saldo = c.Double(nullable: false),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.NroTarjeta)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tarjetas", "Person_Id", "dbo.People");
            DropIndex("dbo.Tarjetas", new[] { "Person_Id" });
            DropTable("dbo.Tarjetas");
            DropTable("dbo.People");
        }
    }
}
