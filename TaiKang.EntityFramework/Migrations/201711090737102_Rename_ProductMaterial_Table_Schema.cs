namespace TaiKang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rename_ProductMaterial_Table_Schema : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.ProductMaterial", newSchema: "Tk");
        }
        
        public override void Down()
        {
            MoveTable(name: "Tk.ProductMaterial", newSchema: "dbo");
        }
    }
}
