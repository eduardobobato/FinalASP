namespace ProjetoFinalASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "CpfCliente", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "Telefone", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "CnpjEmpresa", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "TelefoneEmpresa", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "TelefoneEmpresa", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "CnpjEmpresa", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "Telefone", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "CpfCliente", c => c.Int(nullable: false));
        }
    }
}
