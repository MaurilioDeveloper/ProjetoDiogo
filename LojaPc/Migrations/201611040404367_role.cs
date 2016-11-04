namespace LojaPc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class role : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.USUARIOS", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.USUARIOS", "Role");
        }
    }
}
