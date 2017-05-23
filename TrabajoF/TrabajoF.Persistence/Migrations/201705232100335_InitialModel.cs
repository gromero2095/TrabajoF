namespace TrabajoF.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autor",
                c => new
                    {
                        Autorid = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 100),
                        FechadeNacimiento = c.String(nullable: false, maxLength: 100),
                        Libroid = c.Int(nullable: false),
                        Nacionalidadid = c.Int(nullable: false),
                        Libro_Libroid = c.Int(),
                    })
                .PrimaryKey(t => t.Autorid)
                .ForeignKey("dbo.Libro", t => t.Libro_Libroid)
                .ForeignKey("dbo.Nacionalidad", t => t.Nacionalidadid, cascadeDelete: true)
                .Index(t => t.Nacionalidadid)
                .Index(t => t.Libro_Libroid);
            
            CreateTable(
                "dbo.Libro",
                c => new
                    {
                        Libroid = c.Int(nullable: false, identity: true),
                        Editorial = c.String(nullable: false, maxLength: 255),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.String(nullable: false, maxLength: 100),
                        Stock = c.Int(nullable: false),
                        AñoPublicacion = c.DateTime(nullable: false),
                        Valoracion = c.String(nullable: false, maxLength: 100),
                        Autorid = c.Int(nullable: false),
                        Carritoid = c.Int(nullable: false),
                        TipoLibro = c.Int(nullable: false),
                        Categoria = c.Int(nullable: false),
                        Ventaid = c.Int(),
                        Empleadoid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Libroid)
                .ForeignKey("dbo.Empleado", t => t.Empleadoid, cascadeDelete: true)
                .ForeignKey("dbo.Carrito", t => t.Carritoid, cascadeDelete: true)
                .ForeignKey("dbo.Venta", t => t.Ventaid)
                .ForeignKey("dbo.Autor", t => t.Autorid, cascadeDelete: true)
                .Index(t => t.Autorid)
                .Index(t => t.Carritoid)
                .Index(t => t.Ventaid)
                .Index(t => t.Empleadoid);
            
            CreateTable(
                "dbo.Carrito",
                c => new
                    {
                        Carritoid = c.Int(nullable: false),
                        Correo = c.String(nullable: false, maxLength: 255),
                        Telefono = c.Int(nullable: false),
                        EnviarNom = c.String(nullable: false, maxLength: 100),
                        EnviarApe = c.String(nullable: false, maxLength: 100),
                        EnviarDireccion = c.String(nullable: false, maxLength: 100),
                        EnviarDistrito = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Carritoid)
                .ForeignKey("dbo.Cliente", t => t.Carritoid)
                .ForeignKey("dbo.Venta", t => t.Carritoid)
                .Index(t => t.Carritoid);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Clienteid = c.Int(nullable: false, identity: true),
                        DNI = c.Int(nullable: false),
                        RUCCliente = c.Int(nullable: false),
                        Nombres = c.String(nullable: false, maxLength: 100),
                        ApePaterno = c.String(nullable: false, maxLength: 100),
                        ApeMaterno = c.String(nullable: false, maxLength: 100),
                        Direccion = c.String(nullable: false, maxLength: 150),
                        Telefono = c.Int(nullable: false),
                        Sexo = c.String(nullable: false, maxLength: 50),
                        Correo = c.String(nullable: false, maxLength: 100),
                        Comprobanteid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Clienteid);
            
            CreateTable(
                "dbo.Comprobante",
                c => new
                    {
                        Comprobanteid = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 255),
                        Fecha = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        Clienteid = c.Int(nullable: false),
                        Ventasid = c.Int(nullable: false),
                        Envio = c.Int(nullable: false),
                        Cliente_Clienteid = c.Int(),
                    })
                .PrimaryKey(t => t.Comprobanteid)
                .ForeignKey("dbo.Venta", t => t.Comprobanteid)
                .ForeignKey("dbo.Cliente", t => t.Comprobanteid)
                .ForeignKey("dbo.Cliente", t => t.Cliente_Clienteid)
                .Index(t => t.Comprobanteid)
                .Index(t => t.Cliente_Clienteid);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        Ventaid = c.Int(nullable: false, identity: true),
                        Libro = c.String(nullable: false, maxLength: 255),
                        MontoTotal = c.Int(nullable: false),
                        FechaTrans = c.Int(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 50),
                        Carritoid = c.Int(nullable: false),
                        LocalLibreriaId = c.Int(nullable: false),
                        Envio = c.Int(nullable: false),
                        Cliente_Clienteid = c.Int(),
                    })
                .PrimaryKey(t => t.Ventaid)
                .ForeignKey("dbo.LocalxLibreria", t => t.LocalLibreriaId, cascadeDelete: true)
                .ForeignKey("dbo.Cliente", t => t.Cliente_Clienteid)
                .Index(t => t.LocalLibreriaId)
                .Index(t => t.Cliente_Clienteid);
            
            CreateTable(
                "dbo.LocalxLibreria",
                c => new
                    {
                        LocalLibreriaid = c.Int(nullable: false, identity: true),
                        Direccion = c.String(nullable: false, maxLength: 255),
                        Libreria_Libreriaid = c.Int(),
                        Venta_Ventaid = c.Int(),
                    })
                .PrimaryKey(t => t.LocalLibreriaid)
                .ForeignKey("dbo.Libreria", t => t.Libreria_Libreriaid)
                .ForeignKey("dbo.Venta", t => t.Venta_Ventaid)
                .Index(t => t.Libreria_Libreriaid)
                .Index(t => t.Venta_Ventaid);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        Empleadoid = c.Int(nullable: false),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        ApePaterno = c.String(nullable: false, maxLength: 100),
                        ApeMaterno = c.String(nullable: false, maxLength: 100),
                        Telefono = c.Int(nullable: false),
                        Sexo = c.String(nullable: false, maxLength: 25),
                        FechaIngreso = c.Int(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 200),
                        Direccion = c.String(nullable: false, maxLength: 255),
                        Correo = c.String(nullable: false, maxLength: 150),
                        TipoEmpleado = c.Int(nullable: false),
                        LocalLibreriaid = c.Int(nullable: false),
                        Libroid = c.Int(nullable: false),
                        Libro_Libroid = c.Int(),
                    })
                .PrimaryKey(t => t.Empleadoid)
                .ForeignKey("dbo.Libro", t => t.Libro_Libroid)
                .ForeignKey("dbo.LocalxLibreria", t => t.Empleadoid)
                .Index(t => t.Empleadoid)
                .Index(t => t.Libro_Libroid);
            
            CreateTable(
                "dbo.Libreria",
                c => new
                    {
                        Libreriaid = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 255),
                        RUCLibreria = c.Int(nullable: false),
                        LocalLibreriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Libreriaid)
                .ForeignKey("dbo.LocalxLibreria", t => t.LocalLibreriaId)
                .Index(t => t.LocalLibreriaId);
            
            CreateTable(
                "dbo.Pago",
                c => new
                    {
                        Pagoid = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 255),
                        TipoPago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pagoid)
                .ForeignKey("dbo.Venta", t => t.Pagoid)
                .Index(t => t.Pagoid);
            
            CreateTable(
                "dbo.Nacionalidad",
                c => new
                    {
                        Nacionalidadid = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 255),
                        TipoPago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Nacionalidadid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Autor", "Nacionalidadid", "dbo.Nacionalidad");
            DropForeignKey("dbo.Libro", "Autorid", "dbo.Autor");
            DropForeignKey("dbo.Libro", "Ventaid", "dbo.Venta");
            DropForeignKey("dbo.Libro", "Carritoid", "dbo.Carrito");
            DropForeignKey("dbo.Venta", "Cliente_Clienteid", "dbo.Cliente");
            DropForeignKey("dbo.Comprobante", "Cliente_Clienteid", "dbo.Cliente");
            DropForeignKey("dbo.Comprobante", "Comprobanteid", "dbo.Cliente");
            DropForeignKey("dbo.Pago", "Pagoid", "dbo.Venta");
            DropForeignKey("dbo.Venta", "LocalLibreriaId", "dbo.LocalxLibreria");
            DropForeignKey("dbo.LocalxLibreria", "Venta_Ventaid", "dbo.Venta");
            DropForeignKey("dbo.LocalxLibreria", "Libreria_Libreriaid", "dbo.Libreria");
            DropForeignKey("dbo.Libreria", "LocalLibreriaId", "dbo.LocalxLibreria");
            DropForeignKey("dbo.Empleado", "Empleadoid", "dbo.LocalxLibreria");
            DropForeignKey("dbo.Libro", "Empleadoid", "dbo.Empleado");
            DropForeignKey("dbo.Empleado", "Libro_Libroid", "dbo.Libro");
            DropForeignKey("dbo.Comprobante", "Comprobanteid", "dbo.Venta");
            DropForeignKey("dbo.Carrito", "Carritoid", "dbo.Venta");
            DropForeignKey("dbo.Carrito", "Carritoid", "dbo.Cliente");
            DropForeignKey("dbo.Autor", "Libro_Libroid", "dbo.Libro");
            DropIndex("dbo.Pago", new[] { "Pagoid" });
            DropIndex("dbo.Libreria", new[] { "LocalLibreriaId" });
            DropIndex("dbo.Empleado", new[] { "Libro_Libroid" });
            DropIndex("dbo.Empleado", new[] { "Empleadoid" });
            DropIndex("dbo.LocalxLibreria", new[] { "Venta_Ventaid" });
            DropIndex("dbo.LocalxLibreria", new[] { "Libreria_Libreriaid" });
            DropIndex("dbo.Venta", new[] { "Cliente_Clienteid" });
            DropIndex("dbo.Venta", new[] { "LocalLibreriaId" });
            DropIndex("dbo.Comprobante", new[] { "Cliente_Clienteid" });
            DropIndex("dbo.Comprobante", new[] { "Comprobanteid" });
            DropIndex("dbo.Carrito", new[] { "Carritoid" });
            DropIndex("dbo.Libro", new[] { "Empleadoid" });
            DropIndex("dbo.Libro", new[] { "Ventaid" });
            DropIndex("dbo.Libro", new[] { "Carritoid" });
            DropIndex("dbo.Libro", new[] { "Autorid" });
            DropIndex("dbo.Autor", new[] { "Libro_Libroid" });
            DropIndex("dbo.Autor", new[] { "Nacionalidadid" });
            DropTable("dbo.Nacionalidad");
            DropTable("dbo.Pago");
            DropTable("dbo.Libreria");
            DropTable("dbo.Empleado");
            DropTable("dbo.LocalxLibreria");
            DropTable("dbo.Venta");
            DropTable("dbo.Comprobante");
            DropTable("dbo.Cliente");
            DropTable("dbo.Carrito");
            DropTable("dbo.Libro");
            DropTable("dbo.Autor");
        }
    }
}
