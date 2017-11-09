namespace TaiKang.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Add_ClassifiedContent_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Tk.ClassifiedContent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassifyName = c.Int(nullable: false),
                        Content = c.String(),
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
                    { "DynamicFilter_ClassifiedContent_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Tk.ClassifiedContent",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_ClassifiedContent_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
