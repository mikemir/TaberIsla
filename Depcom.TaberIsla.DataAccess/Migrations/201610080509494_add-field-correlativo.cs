namespace Depcom.TaberIsla.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addfieldcorrelativo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Naufragos", "Correlativo", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Naufragos", "Correlativo");
        }
    }
}
