namespace LojaPc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class computadorSessio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.COMPUTADORES", "ComputadorSession", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.COMPUTADORES", "ComputadorSession");
        }
    }
}
