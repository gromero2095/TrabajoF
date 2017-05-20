namespace TrabajoF.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autors",
                c => new
                    {
                        Autorid = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        FechadeNacimiento = c.String(),
                    })
                .PrimaryKey(t => t.Autorid);
            
            CreateTable(
                "dbo.Carritoes",
                c => new
                    {
                        Carritoid = c.Int(nullable: false, identity: true),
                        Correo = c.String(),
                        Telefono = c.Int(nullable: false),
                        EnviarNom = c.String(),
                        EnviarApe = c.String(),
                        EnviarDireccion = c.String(),
                        EnviarDistrito = c.String(),
                    })
                .PrimaryKey(t => t.Carritoid);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Clienteid = c.Int(nullable: false, identity: true),
                        DNI = c.Int(nullable: false),
                        RUCCliente = c.Int(nullable: false),
                        Nombres = c.String(),
                        ApePaterno = c.String(),
                        ApeMaterno = c.String(),
                        Direccion = c.String(),
                        Telefono = c.Int(nullable: false),
                        Sexo = c.String(),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.Clienteid);
            
            CreateTable(
                "dbo.Comprobantes",
                c => new
                    {
                        Comprobanteid = c.Int(nullable: false, identity: true),
                        Fecha = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Comprobanteid);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        Empleadoid = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        ApePaterno = c.String(),
                        ApeMaterno = c.String(),
                        Telefono = c.Int(nullable: false),
                        Sexo = c.String(),
                        FechaIngreso = c.Int(nullable: false),
                        Estado = c.String(),
                        Direccion = c.String(),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.Empleadoid);
            
            CreateTable(
                "dbo.Librerias",
                c => new
                    {
                        Libreriaid = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        RUCLibreria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Libreriaid);
            
            CreateTable(
                "dbo.Libroes",
                c => new
                    {
                        Libroid = c.Int(nullable: false, identity: true),
                        Editorial = c.String(),
                        Precio = c.Double(nullable: false),
                        Estado = c.String(),
                        Stock = c.Int(nullable: false),
                        AñoPublicacion = c.DateTime(nullable: false),
                        Valoracion = c.String(),
                    })
                .PrimaryKey(t => t.Libroid);
            
            CreateTable(
                "dbo.LocalLibrerias",
                c => new
                    {
                        LocalLibreriaid = c.Int(nullable: false, identity: true),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.LocalLibreriaid);
            
            CreateTable(
                "dbo.Nacionalidads",
                c => new
                    {
                        Nacionalidadid = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Nacionalidadid);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        Ventaid = c.Int(nullable: false, identity: true),
                        Libros = c.String(),
                        MontoTotal = c.Int(nullable: false),
                        FechaTrans = c.Int(nullable: false),
                        ModalidadRecogo = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Ventaid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ventas");
            DropTable("dbo.Nacionalidads");
            DropTable("dbo.LocalLibrerias");
            DropTable("dbo.Libroes");
            DropTable("dbo.Librerias");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Comprobantes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Carritoes");
            DropTable("dbo.Autors");
        }
    }
}
