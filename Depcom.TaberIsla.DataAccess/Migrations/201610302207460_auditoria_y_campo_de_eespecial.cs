namespace Depcom.TaberIsla.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class auditoria_y_campo_de_eespecial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Naufragos", "EsEspecial", c => c.Boolean());
            AddColumn("dbo.Naufragos", "FechaHoraIngreso", c => c.DateTime());
            AddColumn("dbo.Responsables", "FechaHoraIngreso", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Responsables", "FechaHoraIngreso");
            DropColumn("dbo.Naufragos", "FechaHoraIngreso");
            DropColumn("dbo.Naufragos", "EsEspecial");
        }
    }
}
