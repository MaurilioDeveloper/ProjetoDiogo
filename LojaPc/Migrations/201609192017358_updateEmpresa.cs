namespace LojaPc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresas", "Nome", c => c.String(nullable: false));
            AddColumn("dbo.Empresas", "NomeFantasia", c => c.String(nullable: false));
            AddColumn("dbo.Empresas", "Cnpj", c => c.String(nullable: false));
            AddColumn("dbo.Empresas", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Empresas", "Telefone", c => c.String(nullable: false));
            AddColumn("dbo.Empresas", "Celular", c => c.String());
            AddColumn("dbo.Empresas", "Uf", c => c.String(nullable: false));
            AddColumn("dbo.Empresas", "Cidade", c => c.String(nullable: false));
            AddColumn("dbo.Empresas", "Bairro", c => c.String(nullable: false));
            AddColumn("dbo.Empresas", "Endereco", c => c.String(nullable: false));
            AddColumn("dbo.Empresas", "Cep", c => c.String(nullable: false));
            AddColumn("dbo.Empresas", "InscricaoEstadual", c => c.String());
            AddColumn("dbo.Empresas", "InscricaoMunicipal", c => c.String());
            AddColumn("dbo.Empresas", "Status", c => c.String());
            AddColumn("dbo.Empresas", "Responsavel", c => c.String());
            AddColumn("dbo.Empresas", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresas", "Url");
            DropColumn("dbo.Empresas", "Responsavel");
            DropColumn("dbo.Empresas", "Status");
            DropColumn("dbo.Empresas", "InscricaoMunicipal");
            DropColumn("dbo.Empresas", "InscricaoEstadual");
            DropColumn("dbo.Empresas", "Cep");
            DropColumn("dbo.Empresas", "Endereco");
            DropColumn("dbo.Empresas", "Bairro");
            DropColumn("dbo.Empresas", "Cidade");
            DropColumn("dbo.Empresas", "Uf");
            DropColumn("dbo.Empresas", "Celular");
            DropColumn("dbo.Empresas", "Telefone");
            DropColumn("dbo.Empresas", "Email");
            DropColumn("dbo.Empresas", "Cnpj");
            DropColumn("dbo.Empresas", "NomeFantasia");
            DropColumn("dbo.Empresas", "Nome");
        }
    }
}
