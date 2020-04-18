namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tarjp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tarjetas", "TipoTarjeta", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tarjetas", "TipoTarjeta");
        }
    }
}
