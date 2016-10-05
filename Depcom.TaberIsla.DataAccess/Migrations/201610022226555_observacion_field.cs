namespace Depcom.TaberIsla.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class observacion_field : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Naufragos", "Observacion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Naufragos", "Observacion");
        }
    }
}
