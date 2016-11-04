namespace LojaPc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasdas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.COMPUTADORES", "ComputadorStatus", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.COMPUTADORES", "ComputadorStatus", c => c.Boolean(nullable: false));
        }
    }
}
