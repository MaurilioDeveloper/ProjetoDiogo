namespace LojaPc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.COMPUTADORES",
                c => new
                    {
                        ComputadorId = c.Int(nullable: false, identity: true),
                        ComputadorStatus = c.Boolean(nullable: false),
                        Frete_FreteId = c.Int(),
                    })
                .PrimaryKey(t => t.ComputadorId)
                .ForeignKey("dbo.FRETES", t => t.Frete_FreteId)
                .Index(t => t.Frete_FreteId);
            
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
                "dbo.PECAS",
                c => new
                    {
                        PecaId = c.Int(nullable: false, identity: true),
                        NomePeca = c.String(nullable: false, maxLength: 30),
                        DescricaoPeca = c.String(nullable: false, maxLength: 50),
                        CategoriaPeca = c.String(nullable: false),
                        ValorPeca = c.Double(nullable: false),
                        PecaImagem = c.String(),
                        Computador_ComputadorId = c.Int(),
                    })
                .PrimaryKey(t => t.PecaId)
                .ForeignKey("dbo.COMPUTADORES", t => t.Computador_ComputadorId)
                .Index(t => t.Computador_ComputadorId);
            
            CreateTable(
                "dbo.USUARIOS",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        UsuarioNome = c.String(nullable: false, maxLength: 35),
                        UsuarioEmail = c.String(nullable: false),
                        UsuarioSenha = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PECAS", "Computador_ComputadorId", "dbo.COMPUTADORES");
            DropForeignKey("dbo.COMPUTADORES", "Frete_FreteId", "dbo.FRETES");
            DropIndex("dbo.PECAS", new[] { "Computador_ComputadorId" });
            DropIndex("dbo.COMPUTADORES", new[] { "Frete_FreteId" });
            DropTable("dbo.USUARIOS");
            DropTable("dbo.PECAS");
            DropTable("dbo.FRETES");
            DropTable("dbo.COMPUTADORES");
        }
    }
}
