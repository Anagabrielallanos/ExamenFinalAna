namespace FinalCalida.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Datos",
                c => new
                    {
                        IdDatos = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Categoria = c.String(),
                        SadldoInicial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDatos);
            
            CreateTable(
                "dbo.GastoTarjeta",
                c => new
                    {
                        IdGastoTarjeta = c.Int(nullable: false, identity: true),
                        Cuenta = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DatosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdGastoTarjeta)
                .ForeignKey("dbo.Datos", t => t.DatosId, cascadeDelete: true)
                .Index(t => t.DatosId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GastoTarjeta", "DatosId", "dbo.Datos");
            DropIndex("dbo.GastoTarjeta", new[] { "DatosId" });
            DropTable("dbo.GastoTarjeta");
            DropTable("dbo.Datos");
        }
    }
}
