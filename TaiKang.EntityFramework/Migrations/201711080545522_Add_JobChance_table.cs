namespace TaiKang.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Add_JobChance_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Tk.JobChance",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobName = c.String(),
                        JobDescription = c.String(),
                        Requirements = c.String(),
                        Responsibilities = c.String(),
                        IsActive = c.Boolean(nullable: false),
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
                    { "DynamicFilter_JobChance_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Tk.JobChance",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_JobChance_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
