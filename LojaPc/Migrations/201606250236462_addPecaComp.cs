namespace LojaPc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPecaComp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PECAS", "Computador_ComputadorId", "dbo.COMPUTADORES");
            DropIndex("dbo.PECAS", new[] { "Computador_ComputadorId" });
            CreateTable(
                "dbo.PECA_COMPUTADOR",
                c => new
                    {
                        PecaComputadorId = c.Int(nullable: false, identity: true),
                        PecaComputadorData = c.DateTime(nullable: false),
                        SessionId = c.String(),
                        Peca_PecaId = c.Int(),
                        Computador_ComputadorId = c.Int(),
                    })
                .PrimaryKey(t => t.PecaComputadorId)
                .ForeignKey("dbo.PECAS", t => t.Peca_PecaId)
                .ForeignKey("dbo.COMPUTADORES", t => t.Computador_ComputadorId)
                .Index(t => t.Peca_PecaId)
                .Index(t => t.Computador_ComputadorId);
            
            DropColumn("dbo.COMPUTADORES", "ComputadorSession");
            DropColumn("dbo.PECAS", "Computador_ComputadorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PECAS", "Computador_ComputadorId", c => c.Int());
            AddColumn("dbo.COMPUTADORES", "ComputadorSession", c => c.String());
            DropForeignKey("dbo.PECA_COMPUTADOR", "Computador_ComputadorId", "dbo.COMPUTADORES");
            DropForeignKey("dbo.PECA_COMPUTADOR", "Peca_PecaId", "dbo.PECAS");
            DropIndex("dbo.PECA_COMPUTADOR", new[] { "Computador_ComputadorId" });
            DropIndex("dbo.PECA_COMPUTADOR", new[] { "Peca_PecaId" });
            DropTable("dbo.PECA_COMPUTADOR");
            CreateIndex("dbo.PECAS", "Computador_ComputadorId");
            AddForeignKey("dbo.PECAS", "Computador_ComputadorId", "dbo.COMPUTADORES", "ComputadorId");
        }
    }
}
