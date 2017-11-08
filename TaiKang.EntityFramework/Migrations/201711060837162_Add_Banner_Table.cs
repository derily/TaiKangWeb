namespace TaiKang.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Banner_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Tk.Banner",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BannerImage = c.String(),
                        BannerTitle = c.String(),
                        Enabled = c.Boolean(nullable: false),
                        OrderNo = c.Int(nullable: false),
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
                    { "DynamicFilter_Banner_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Tk.Banner",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Banner_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
