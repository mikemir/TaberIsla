namespace Depcom.TaberIsla.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_bajas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bajas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdNaufrago = c.Int(nullable: false),
                        FechaHoraIngreso = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Naufragos", t => t.IdNaufrago, cascadeDelete: true)
                .Index(t => t.IdNaufrago);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bajas", "IdNaufrago", "dbo.Naufragos");
            DropIndex("dbo.Bajas", new[] { "IdNaufrago" });
            DropTable("dbo.Bajas");
        }
    }
}
