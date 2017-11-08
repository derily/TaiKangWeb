namespace TaiKang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_CompanyIntroduce_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Tk.CompanyIntroduce",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        BrandStory = c.String(),
                        Qualification = c.String(),
                        Introduce = c.String(),
                        Image = c.String(),
                        Address = c.String(),
                        Contact = c.String(),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Tk.CompanyIntroduce");
        }
    }
}
