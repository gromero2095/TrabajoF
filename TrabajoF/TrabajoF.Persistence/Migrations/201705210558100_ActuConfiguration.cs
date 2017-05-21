namespace TrabajoF.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActuConfiguration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Autor", newName: "Autors");
            RenameTable(name: "dbo.Libro", newName: "Libroes");
            RenameTable(name: "dbo.Carrito", newName: "Carritoes");
            RenameTable(name: "dbo.Cliente", newName: "Clientes");
            RenameTable(name: "dbo.Comprobante", newName: "Comprobantes");
            RenameTable(name: "dbo.Venta", newName: "Ventas");
            RenameTable(name: "dbo.Pago", newName: "Pagoes");
            RenameTable(name: "dbo.Empleado", newName: "Empleadoes");
            RenameTable(name: "dbo.Libreria", newName: "Librerias");
            RenameTable(name: "dbo.LocalLibreria", newName: "LocalLibrerias");
            RenameTable(name: "dbo.Nacionalidad", newName: "Nacionalidads");
            AlterColumn("dbo.Autors", "FechadeNacimiento", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Libroes", "Editorial", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Carritoes", "Correo", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Clientes", "Nombres", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Ventas", "Libros", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Pagoes", "Descripcion", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Empleadoes", "Nombres", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Empleadoes", "ApePaterno", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Empleadoes", "ApeMaterno", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Librerias", "Nombre", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.LocalLibrerias", "Direccion", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Nacionalidads", "Nombre", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Nacionalidads", "Nombre", c => c.String());
            AlterColumn("dbo.LocalLibrerias", "Direccion", c => c.String());
            AlterColumn("dbo.Librerias", "Nombre", c => c.String());
            AlterColumn("dbo.Empleadoes", "ApeMaterno", c => c.String());
            AlterColumn("dbo.Empleadoes", "ApePaterno", c => c.String());
            AlterColumn("dbo.Empleadoes", "Nombres", c => c.String());
            AlterColumn("dbo.Pagoes", "Descripcion", c => c.String());
            AlterColumn("dbo.Ventas", "Libros", c => c.String());
            AlterColumn("dbo.Clientes", "Nombres", c => c.String());
            AlterColumn("dbo.Carritoes", "Correo", c => c.String());
            AlterColumn("dbo.Libroes", "Editorial", c => c.String());
            AlterColumn("dbo.Autors", "FechadeNacimiento", c => c.String(nullable: false, maxLength: 80));
            RenameTable(name: "dbo.Nacionalidads", newName: "Nacionalidad");
            RenameTable(name: "dbo.LocalLibrerias", newName: "LocalLibreria");
            RenameTable(name: "dbo.Librerias", newName: "Libreria");
            RenameTable(name: "dbo.Empleadoes", newName: "Empleado");
            RenameTable(name: "dbo.Pagoes", newName: "Pago");
            RenameTable(name: "dbo.Ventas", newName: "Venta");
            RenameTable(name: "dbo.Comprobantes", newName: "Comprobante");
            RenameTable(name: "dbo.Clientes", newName: "Cliente");
            RenameTable(name: "dbo.Carritoes", newName: "Carrito");
            RenameTable(name: "dbo.Libroes", newName: "Libro");
            RenameTable(name: "dbo.Autors", newName: "Autor");
        }
    }
}
