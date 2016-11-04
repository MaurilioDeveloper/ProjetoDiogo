namespace LojaPc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addQuantidade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PECAS", "QuantidadePeca", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PECAS", "QuantidadePeca");
        }
    }
}
