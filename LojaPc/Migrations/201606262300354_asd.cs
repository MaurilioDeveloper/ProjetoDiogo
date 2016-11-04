namespace LojaPc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.COMPUTADORES", "ComputadorSubTotal", c => c.Double(nullable: false));
            AddColumn("dbo.COMPUTADORES", "ComputadorTotal", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.COMPUTADORES", "ComputadorTotal");
            DropColumn("dbo.COMPUTADORES", "ComputadorSubTotal");
        }
    }
}
