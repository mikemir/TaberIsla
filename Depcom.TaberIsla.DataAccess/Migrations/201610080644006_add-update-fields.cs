namespace Depcom.TaberIsla.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addupdatefields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Naufragos", "FechaNacimiento", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Responsables", "Nombres", c => c.String(nullable: false));
            AlterColumn("dbo.Responsables", "Apellidos", c => c.String(nullable: false));
            AlterColumn("dbo.Responsables", "Dui", c => c.String(nullable: false));
            AlterColumn("dbo.Responsables", "Direccion", c => c.String(nullable: false));
            AlterColumn("dbo.Responsables", "Telefono1", c => c.String(nullable: false));
            AlterColumn("dbo.Responsables", "Telefono2", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Responsables", "Telefono2", c => c.String());
            AlterColumn("dbo.Responsables", "Telefono1", c => c.String());
            AlterColumn("dbo.Responsables", "Direccion", c => c.String());
            AlterColumn("dbo.Responsables", "Dui", c => c.String());
            AlterColumn("dbo.Responsables", "Apellidos", c => c.String());
            AlterColumn("dbo.Responsables", "Nombres", c => c.String());
            AlterColumn("dbo.Naufragos", "FechaNacimiento", c => c.DateTime(nullable: false));
        }
    }
}
