namespace LojaPc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEmpresa1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        EmpresaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EmpresaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresas");
        }
    }
}
