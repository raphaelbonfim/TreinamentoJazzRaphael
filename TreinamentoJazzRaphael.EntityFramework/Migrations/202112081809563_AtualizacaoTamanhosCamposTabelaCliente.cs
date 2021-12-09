namespace TreinamentoJazzRaphael.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizacaoTamanhosCamposTabelaCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Nome", c => c.String(maxLength: 255));
            AlterColumn("dbo.Clientes", "CPF", c => c.String(maxLength: 255));
            AlterColumn("dbo.Clientes", "Endereco_Rua", c => c.String(maxLength: 255));
            AlterColumn("dbo.Clientes", "Endereco_Bairro", c => c.String(maxLength: 255));
            AlterColumn("dbo.Clientes", "Endereco_Cidade", c => c.String(maxLength: 255));
            AlterColumn("dbo.Clientes", "Endereco_Estado", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Endereco_Estado", c => c.String());
            AlterColumn("dbo.Clientes", "Endereco_Cidade", c => c.String());
            AlterColumn("dbo.Clientes", "Endereco_Bairro", c => c.String());
            AlterColumn("dbo.Clientes", "Endereco_Rua", c => c.String());
            AlterColumn("dbo.Clientes", "CPF", c => c.String());
            AlterColumn("dbo.Clientes", "Nome", c => c.String());
        }
    }
}
