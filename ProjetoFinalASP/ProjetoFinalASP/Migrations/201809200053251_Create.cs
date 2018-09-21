namespace ProjetoFinalASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        idCategoria = c.Int(nullable: false, identity: true),
                        NomeCategoria = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idCategoria);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        idCliente = c.Int(nullable: false, identity: true),
                        NomeCliente = c.String(nullable: false),
                        CpfCliente = c.Int(nullable: false),
                        Telefone = c.Int(nullable: false),
                        NomeEmpresa = c.String(nullable: false),
                        CnpjEmpresa = c.Int(nullable: false),
                        TelefoneEmpresa = c.Int(nullable: false),
                        Endereco = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idCliente);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        idProduto = c.Int(nullable: false, identity: true),
                        NomeProduto = c.String(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Double(nullable: false),
                        Descricao = c.String(nullable: false),
                        Categoria_idCategoria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idProduto)
                .ForeignKey("dbo.Categorias", t => t.Categoria_idCategoria, cascadeDelete: true)
                .Index(t => t.Categoria_idCategoria);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        idUsuario = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        NivelAcesso = c.String(),
                        UltimoAcesso = c.DateTime(nullable: false),
                        Discriminator = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.idUsuario);
            
            CreateTable(
                "dbo.Vendedores",
                c => new
                    {
                        idUsuario = c.Int(nullable: false),
                        idVendedor = c.Int(nullable: false),
                        NomeVendedor = c.String(nullable: false),
                        CpfVendedor = c.Int(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Telefone = c.Int(nullable: false),
                        Endereco = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idUsuario)
                .ForeignKey("dbo.Usuarios", t => t.idUsuario)
                .Index(t => t.idUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendedores", "idUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Produtos", "Categoria_idCategoria", "dbo.Categorias");
            DropIndex("dbo.Vendedores", new[] { "idUsuario" });
            DropIndex("dbo.Produtos", new[] { "Categoria_idCategoria" });
            DropTable("dbo.Vendedores");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Produtos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
        }
    }
}
