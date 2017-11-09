namespace TaiKang.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Product_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Tk.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Desc = c.String(),
                        Functions = c.String(),
                        BuyLink = c.String(),
                        Domestic = c.Boolean(nullable: false),
                        Exportable = c.Boolean(nullable: false),
                        CarouselImg = c.String(),
                        DetailImg1 = c.String(),
                        DetailImg2 = c.String(),
                        DetailImg3 = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Product_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Tk.Product",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Product_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
