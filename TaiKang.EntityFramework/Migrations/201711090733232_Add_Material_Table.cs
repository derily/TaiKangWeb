namespace TaiKang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Material_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Tk.Material",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Function = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductMaterial",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        MaterialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.MaterialId })
                .ForeignKey("Tk.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("Tk.Material", t => t.MaterialId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.MaterialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductMaterial", "MaterialId", "Tk.Material");
            DropForeignKey("dbo.ProductMaterial", "ProductId", "Tk.Product");
            DropIndex("dbo.ProductMaterial", new[] { "MaterialId" });
            DropIndex("dbo.ProductMaterial", new[] { "ProductId" });
            DropTable("dbo.ProductMaterial");
            DropTable("Tk.Material");
        }
    }
}
