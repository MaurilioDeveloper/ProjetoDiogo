namespace LojaPc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialized : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.COMPUTADORES", "Frete_FreteId", "dbo.FRETES");
            DropForeignKey("dbo.PECA_COMPUTADOR", "Computador_ComputadorId", "dbo.COMPUTADORES");
            DropForeignKey("dbo.PECA_COMPUTADOR", "Peca_PecaId", "dbo.PECAS");
            DropIndex("dbo.COMPUTADORES", new[] { "Frete_FreteId" });
            DropIndex("dbo.PECA_COMPUTADOR", new[] { "Computador_ComputadorId" });
            DropIndex("dbo.PECA_COMPUTADOR", new[] { "Peca_PecaId" });
            DropTable("dbo.COMPUTADORES");
            DropTable("dbo.FRETES");
            DropTable("dbo.PECA_COMPUTADOR");
            DropTable("dbo.PECAS");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PECAS",
                c => new
                    {
                        PecaId = c.Int(nullable: false, identity: true),
                        NomePeca = c.String(nullable: false, maxLength: 30),
                        DescricaoPeca = c.String(nullable: false, maxLength: 50),
                        CategoriaPeca = c.String(nullable: false),
                        ValorPeca = c.Double(nullable: false),
                        PecaImagem = c.String(),
                        QuantidadePeca = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PecaId);
            
            CreateTable(
                "dbo.PECA_COMPUTADOR",
                c => new
                    {
                        PecaComputadorId = c.Int(nullable: false, identity: true),
                        PecaComputadorData = c.DateTime(nullable: false),
                        SessionId = c.String(),
                        Computador_ComputadorId = c.Int(),
                        Peca_PecaId = c.Int(),
                    })
                .PrimaryKey(t => t.PecaComputadorId);
            
            CreateTable(
                "dbo.FRETES",
                c => new
                    {
                        FreteId = c.Int(nullable: false, identity: true),
                        FreteUf = c.String(nullable: false),
                        FreteValor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.FreteId);
            
            CreateTable(
                "dbo.COMPUTADORES",
                c => new
                    {
                        ComputadorId = c.Int(nullable: false, identity: true),
                        ComputadorStatus = c.String(),
                        ComputadorSession = c.String(),
                        ComputadorSubTotal = c.Double(nullable: false),
                        ComputadorTotal = c.Double(nullable: false),
                        DataTermino = c.DateTime(nullable: false),
                        Frete_FreteId = c.Int(),
                    })
                .PrimaryKey(t => t.ComputadorId);
            
            CreateIndex("dbo.PECA_COMPUTADOR", "Peca_PecaId");
            CreateIndex("dbo.PECA_COMPUTADOR", "Computador_ComputadorId");
            CreateIndex("dbo.COMPUTADORES", "Frete_FreteId");
            AddForeignKey("dbo.PECA_COMPUTADOR", "Peca_PecaId", "dbo.PECAS", "PecaId");
            AddForeignKey("dbo.PECA_COMPUTADOR", "Computador_ComputadorId", "dbo.COMPUTADORES", "ComputadorId");
            AddForeignKey("dbo.COMPUTADORES", "Frete_FreteId", "dbo.FRETES", "FreteId");
        }
    }
}
