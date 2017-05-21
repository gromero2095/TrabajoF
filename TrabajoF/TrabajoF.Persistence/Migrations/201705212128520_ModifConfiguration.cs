namespace TrabajoF.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Libroes", "Autor_Autorid1", "dbo.Autors");
            DropForeignKey("dbo.Comprobantes", "Venta_Ventaid", "dbo.Ventas");
            DropForeignKey("dbo.Librerias", "EmpleadoId_Empleadoid", "dbo.Empleadoes");
            DropForeignKey("dbo.Empleadoes", "Libreria_Libreriaid", "dbo.Librerias");
            DropForeignKey("dbo.Librerias", "LocalLibreriaId_LocalLibreriaid", "dbo.LocalLibrerias");
            DropForeignKey("dbo.Libroes", "Autor_Autorid", "dbo.Autors");
            DropForeignKey("dbo.Libroes", "Carrito_Carritoid", "dbo.Carritoes");
            DropForeignKey("dbo.Comprobantes", "Cliente_Clienteid", "dbo.Clientes");
            DropForeignKey("dbo.Ventas", "Cliente_Clienteid", "dbo.Clientes");
            DropForeignKey("dbo.LocalLibrerias", "Libreria_Libreriaid", "dbo.Librerias");
            DropForeignKey("dbo.LocalLibrerias", "Empleado_Empleadoid", "dbo.Empleadoes");
            DropForeignKey("dbo.Libroes", "Venta_Ventaid", "dbo.Ventas");
            DropIndex("dbo.Libroes", new[] { "Autor_Autorid" });
            DropIndex("dbo.Libroes", new[] { "Carrito_Carritoid" });
            DropIndex("dbo.Libroes", new[] { "Autor_Autorid1" });
            DropIndex("dbo.Libroes", new[] { "Venta_Ventaid" });
            DropIndex("dbo.Comprobantes", new[] { "Cliente_Clienteid" });
            DropIndex("dbo.Comprobantes", new[] { "Venta_Ventaid" });
            DropIndex("dbo.Ventas", new[] { "Cliente_Clienteid" });
            DropIndex("dbo.Empleadoes", new[] { "Libreria_Libreriaid" });
            DropIndex("dbo.Librerias", new[] { "EmpleadoId_Empleadoid" });
            DropIndex("dbo.Librerias", new[] { "LocalLibreriaId_LocalLibreriaid" });
            DropIndex("dbo.LocalLibrerias", new[] { "Empleado_Empleadoid" });
            DropIndex("dbo.LocalLibrerias", new[] { "Libreria_Libreriaid" });
            DropColumn("dbo.Libroes", "Autorid");
            RenameColumn(table: "dbo.Libroes", name: "Autor_Autorid", newName: "Autorid");
            RenameColumn(table: "dbo.Libroes", name: "Carrito_Carritoid", newName: "Carritoid");
            RenameColumn(table: "dbo.Comprobantes", name: "Cliente_Clienteid", newName: "Clienteid");
            RenameColumn(table: "dbo.Ventas", name: "Cliente_Clienteid", newName: "Clienteid");
            RenameColumn(table: "dbo.LocalLibrerias", name: "Libreria_Libreriaid", newName: "Libreriaid");
            RenameColumn(table: "dbo.LocalLibrerias", name: "Empleado_Empleadoid", newName: "Empleadoid");
            RenameColumn(table: "dbo.Libroes", name: "Venta_Ventaid", newName: "Ventaid");
            CreateTable(
                "dbo.LocalLibreria",
                c => new
                    {
                        Libreriaid = c.Int(nullable: false),
                        Empleadoid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Libreriaid, t.Empleadoid })
                .ForeignKey("dbo.Librerias", t => t.Libreriaid, cascadeDelete: true)
                .ForeignKey("dbo.Empleadoes", t => t.Empleadoid, cascadeDelete: true)
                .Index(t => t.Libreriaid)
                .Index(t => t.Empleadoid);
            
            AddColumn("dbo.Autors", "Nacionalidadid", c => c.Int(nullable: false));
            AddColumn("dbo.Comprobantes", "Descripcion", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Comprobantes", "Envio", c => c.Int(nullable: false));
            AddColumn("dbo.Ventas", "Libro", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Ventas", "Carritoid", c => c.Int(nullable: false));
            AddColumn("dbo.Ventas", "Comprobanteid", c => c.Int(nullable: false));
            AddColumn("dbo.Pagoes", "TipoPago", c => c.Int(nullable: false));
            AlterColumn("dbo.Libroes", "Estado", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Libroes", "Valoracion", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Libroes", "Autorid", c => c.Int(nullable: false));
            AlterColumn("dbo.Libroes", "Carritoid", c => c.Int(nullable: false));
            AlterColumn("dbo.Libroes", "Ventaid", c => c.Int(nullable: false));
            AlterColumn("dbo.Carritoes", "EnviarNom", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Carritoes", "EnviarApe", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Carritoes", "EnviarDireccion", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Carritoes", "EnviarDistrito", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Clientes", "Nombres", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Clientes", "ApePaterno", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Clientes", "ApeMaterno", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Clientes", "Direccion", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Clientes", "Sexo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clientes", "Correo", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Comprobantes", "Clienteid", c => c.Int(nullable: false));
            AlterColumn("dbo.Ventas", "Estado", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Ventas", "Clienteid", c => c.Int(nullable: false));
            AlterColumn("dbo.Empleadoes", "Sexo", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Empleadoes", "Estado", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Empleadoes", "Direccion", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Empleadoes", "Correo", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.LocalLibrerias", "Empleadoid", c => c.Int(nullable: false));
            AlterColumn("dbo.LocalLibrerias", "Libreriaid", c => c.Int(nullable: false));
            CreateIndex("dbo.Autors", "Nacionalidadid");
            CreateIndex("dbo.Libroes", "Autorid");
            CreateIndex("dbo.Libroes", "Carritoid");
            CreateIndex("dbo.Libroes", "Ventaid");
            CreateIndex("dbo.Ventas", "Carritoid");
            CreateIndex("dbo.Ventas", "Clienteid");
            CreateIndex("dbo.Ventas", "Comprobanteid");
            CreateIndex("dbo.Comprobantes", "Clienteid");
            CreateIndex("dbo.LocalLibrerias", "Empleadoid");
            CreateIndex("dbo.LocalLibrerias", "Libreriaid");
            AddForeignKey("dbo.Ventas", "Carritoid", "dbo.Carritoes", "Carritoid", cascadeDelete: true);
            AddForeignKey("dbo.Ventas", "Comprobanteid", "dbo.Comprobantes", "Comprobanteid", cascadeDelete: true);
            AddForeignKey("dbo.Autors", "Nacionalidadid", "dbo.Nacionalidads", "Nacionalidadid", cascadeDelete: true);
            AddForeignKey("dbo.Libroes", "Autorid", "dbo.Autors", "Autorid", cascadeDelete: true);
            AddForeignKey("dbo.Libroes", "Carritoid", "dbo.Carritoes", "Carritoid", cascadeDelete: true);
            AddForeignKey("dbo.Comprobantes", "Clienteid", "dbo.Clientes", "Clienteid", cascadeDelete: true);
            AddForeignKey("dbo.Ventas", "Clienteid", "dbo.Clientes", "Clienteid", cascadeDelete: true);
            AddForeignKey("dbo.LocalLibrerias", "Libreriaid", "dbo.Librerias", "Libreriaid", cascadeDelete: true);
            AddForeignKey("dbo.LocalLibrerias", "Empleadoid", "dbo.Empleadoes", "Empleadoid", cascadeDelete: true);
            AddForeignKey("dbo.Libroes", "Ventaid", "dbo.Ventas", "Ventaid", cascadeDelete: true);
            DropColumn("dbo.Libroes", "Autor_Autorid1");
            DropColumn("dbo.Comprobantes", "Venta_Ventaid");
            DropColumn("dbo.Ventas", "Libros");
            DropColumn("dbo.Ventas", "ModalidadRecogo");
            DropColumn("dbo.Empleadoes", "Libreria_Libreriaid");
            DropColumn("dbo.Librerias", "EmpleadoId_Empleadoid");
            DropColumn("dbo.Librerias", "LocalLibreriaId_LocalLibreriaid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Librerias", "LocalLibreriaId_LocalLibreriaid", c => c.Int());
            AddColumn("dbo.Librerias", "EmpleadoId_Empleadoid", c => c.Int());
            AddColumn("dbo.Empleadoes", "Libreria_Libreriaid", c => c.Int());
            AddColumn("dbo.Ventas", "ModalidadRecogo", c => c.String());
            AddColumn("dbo.Ventas", "Libros", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Comprobantes", "Venta_Ventaid", c => c.Int());
            AddColumn("dbo.Libroes", "Autor_Autorid1", c => c.Int());
            DropForeignKey("dbo.Libroes", "Ventaid", "dbo.Ventas");
            DropForeignKey("dbo.LocalLibrerias", "Empleadoid", "dbo.Empleadoes");
            DropForeignKey("dbo.LocalLibrerias", "Libreriaid", "dbo.Librerias");
            DropForeignKey("dbo.Ventas", "Clienteid", "dbo.Clientes");
            DropForeignKey("dbo.Comprobantes", "Clienteid", "dbo.Clientes");
            DropForeignKey("dbo.Libroes", "Carritoid", "dbo.Carritoes");
            DropForeignKey("dbo.Libroes", "Autorid", "dbo.Autors");
            DropForeignKey("dbo.LocalLibreria", "Empleadoid", "dbo.Empleadoes");
            DropForeignKey("dbo.LocalLibreria", "Libreriaid", "dbo.Librerias");
            DropForeignKey("dbo.Autors", "Nacionalidadid", "dbo.Nacionalidads");
            DropForeignKey("dbo.Ventas", "Comprobanteid", "dbo.Comprobantes");
            DropForeignKey("dbo.Ventas", "Carritoid", "dbo.Carritoes");
            DropIndex("dbo.LocalLibreria", new[] { "Empleadoid" });
            DropIndex("dbo.LocalLibreria", new[] { "Libreriaid" });
            DropIndex("dbo.LocalLibrerias", new[] { "Libreriaid" });
            DropIndex("dbo.LocalLibrerias", new[] { "Empleadoid" });
            DropIndex("dbo.Comprobantes", new[] { "Clienteid" });
            DropIndex("dbo.Ventas", new[] { "Comprobanteid" });
            DropIndex("dbo.Ventas", new[] { "Clienteid" });
            DropIndex("dbo.Ventas", new[] { "Carritoid" });
            DropIndex("dbo.Libroes", new[] { "Ventaid" });
            DropIndex("dbo.Libroes", new[] { "Carritoid" });
            DropIndex("dbo.Libroes", new[] { "Autorid" });
            DropIndex("dbo.Autors", new[] { "Nacionalidadid" });
            AlterColumn("dbo.LocalLibrerias", "Libreriaid", c => c.Int());
            AlterColumn("dbo.LocalLibrerias", "Empleadoid", c => c.Int());
            AlterColumn("dbo.Empleadoes", "Correo", c => c.String());
            AlterColumn("dbo.Empleadoes", "Direccion", c => c.String());
            AlterColumn("dbo.Empleadoes", "Estado", c => c.String());
            AlterColumn("dbo.Empleadoes", "Sexo", c => c.String());
            AlterColumn("dbo.Ventas", "Clienteid", c => c.Int());
            AlterColumn("dbo.Ventas", "Estado", c => c.String());
            AlterColumn("dbo.Comprobantes", "Clienteid", c => c.Int());
            AlterColumn("dbo.Clientes", "Correo", c => c.String());
            AlterColumn("dbo.Clientes", "Sexo", c => c.String());
            AlterColumn("dbo.Clientes", "Direccion", c => c.String());
            AlterColumn("dbo.Clientes", "ApeMaterno", c => c.String());
            AlterColumn("dbo.Clientes", "ApePaterno", c => c.String());
            AlterColumn("dbo.Clientes", "Nombres", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Carritoes", "EnviarDistrito", c => c.String());
            AlterColumn("dbo.Carritoes", "EnviarDireccion", c => c.String());
            AlterColumn("dbo.Carritoes", "EnviarApe", c => c.String());
            AlterColumn("dbo.Carritoes", "EnviarNom", c => c.String());
            AlterColumn("dbo.Libroes", "Ventaid", c => c.Int());
            AlterColumn("dbo.Libroes", "Carritoid", c => c.Int());
            AlterColumn("dbo.Libroes", "Autorid", c => c.Int());
            AlterColumn("dbo.Libroes", "Valoracion", c => c.String());
            AlterColumn("dbo.Libroes", "Estado", c => c.String());
            DropColumn("dbo.Pagoes", "TipoPago");
            DropColumn("dbo.Ventas", "Comprobanteid");
            DropColumn("dbo.Ventas", "Carritoid");
            DropColumn("dbo.Ventas", "Libro");
            DropColumn("dbo.Comprobantes", "Envio");
            DropColumn("dbo.Comprobantes", "Descripcion");
            DropColumn("dbo.Autors", "Nacionalidadid");
            DropTable("dbo.LocalLibreria");
            RenameColumn(table: "dbo.Libroes", name: "Ventaid", newName: "Venta_Ventaid");
            RenameColumn(table: "dbo.LocalLibrerias", name: "Empleadoid", newName: "Empleado_Empleadoid");
            RenameColumn(table: "dbo.LocalLibrerias", name: "Libreriaid", newName: "Libreria_Libreriaid");
            RenameColumn(table: "dbo.Ventas", name: "Clienteid", newName: "Cliente_Clienteid");
            RenameColumn(table: "dbo.Comprobantes", name: "Clienteid", newName: "Cliente_Clienteid");
            RenameColumn(table: "dbo.Libroes", name: "Carritoid", newName: "Carrito_Carritoid");
            RenameColumn(table: "dbo.Libroes", name: "Autorid", newName: "Autor_Autorid");
            AddColumn("dbo.Libroes", "Autorid", c => c.Int(nullable: false));
            CreateIndex("dbo.LocalLibrerias", "Libreria_Libreriaid");
            CreateIndex("dbo.LocalLibrerias", "Empleado_Empleadoid");
            CreateIndex("dbo.Librerias", "LocalLibreriaId_LocalLibreriaid");
            CreateIndex("dbo.Librerias", "EmpleadoId_Empleadoid");
            CreateIndex("dbo.Empleadoes", "Libreria_Libreriaid");
            CreateIndex("dbo.Ventas", "Cliente_Clienteid");
            CreateIndex("dbo.Comprobantes", "Venta_Ventaid");
            CreateIndex("dbo.Comprobantes", "Cliente_Clienteid");
            CreateIndex("dbo.Libroes", "Venta_Ventaid");
            CreateIndex("dbo.Libroes", "Autor_Autorid1");
            CreateIndex("dbo.Libroes", "Carrito_Carritoid");
            CreateIndex("dbo.Libroes", "Autor_Autorid");
            AddForeignKey("dbo.Libroes", "Venta_Ventaid", "dbo.Ventas", "Ventaid");
            AddForeignKey("dbo.LocalLibrerias", "Empleado_Empleadoid", "dbo.Empleadoes", "Empleadoid");
            AddForeignKey("dbo.LocalLibrerias", "Libreria_Libreriaid", "dbo.Librerias", "Libreriaid");
            AddForeignKey("dbo.Ventas", "Cliente_Clienteid", "dbo.Clientes", "Clienteid");
            AddForeignKey("dbo.Comprobantes", "Cliente_Clienteid", "dbo.Clientes", "Clienteid");
            AddForeignKey("dbo.Libroes", "Carrito_Carritoid", "dbo.Carritoes", "Carritoid");
            AddForeignKey("dbo.Libroes", "Autor_Autorid", "dbo.Autors", "Autorid");
            AddForeignKey("dbo.Librerias", "LocalLibreriaId_LocalLibreriaid", "dbo.LocalLibrerias", "LocalLibreriaid");
            AddForeignKey("dbo.Empleadoes", "Libreria_Libreriaid", "dbo.Librerias", "Libreriaid");
            AddForeignKey("dbo.Librerias", "EmpleadoId_Empleadoid", "dbo.Empleadoes", "Empleadoid");
            AddForeignKey("dbo.Comprobantes", "Venta_Ventaid", "dbo.Ventas", "Ventaid");
            AddForeignKey("dbo.Libroes", "Autor_Autorid1", "dbo.Autors", "Autorid");
        }
    }
}
