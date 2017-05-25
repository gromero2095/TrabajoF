namespace TrabajoF.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConfigurationNewthree : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Nacionalidad", "TipoPago");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Nacionalidad", "TipoPago", c => c.Int(nullable: false));
        }
    }
}
