namespace Depcom.TaberIsla.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicamentos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Dosis = c.String(),
                        Hora = c.String(),
                        NaufragoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Naufragos", t => t.NaufragoId, cascadeDelete: true)
                .Index(t => t.NaufragoId);

            CreateTable(
                "dbo.Naufragos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        ResponsableId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Responsables", t => t.ResponsableId, cascadeDelete: true)
                .Index(t => t.ResponsableId);

            CreateTable(
                "dbo.Responsables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        Dui = c.String(),
                        Direccion = c.String(),
                        Telefono1 = c.String(),
                        Telefono2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Naufragos", "ResponsableId", "dbo.Responsables");
            DropForeignKey("dbo.Medicamentos", "NaufragoId", "dbo.Naufragos");
            DropIndex("dbo.Naufragos", new[] { "ResponsableId" });
            DropIndex("dbo.Medicamentos", new[] { "NaufragoId" });
            DropTable("dbo.Responsables");
            DropTable("dbo.Naufragos");
            DropTable("dbo.Medicamentos");
        }
    }
}
