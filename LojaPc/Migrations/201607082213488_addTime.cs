namespace LojaPc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.COMPUTADORES", "DataTermino", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.COMPUTADORES", "DataTermino");
        }
    }
}
