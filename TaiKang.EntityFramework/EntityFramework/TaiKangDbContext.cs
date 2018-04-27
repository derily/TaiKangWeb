using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using MySql.Data.Entity;
using TaiKang.Authorization.Roles;
using TaiKang.Authorization.Users;
using TaiKang.Chat;
using TaiKang.Friendships;
using TaiKang.MultiTenancy;
using TaiKang.Storage;
using TaiKang.Tk;

namespace TaiKang.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class TaiKangDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<CompanyIntroduce> CompanyIntroduces { get; set; }

        public virtual IDbSet<Banner> Banners { get; set; }

        public virtual IDbSet<JobChance> Jobs { get; set; }

        public virtual IDbSet<ClassifiedContent> ClassifiedContents { get; set; }

        public virtual IDbSet<Product> Products { get; set; }

        public virtual IDbSet<Material> Materials { get; set; }

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        public TaiKangDbContext()
            : base("Default")
        {
            
        }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasMany<Material>(s => s.Materials)
                .WithMany(c => c.Products).Map(cs =>
                {
                    cs.MapLeftKey("ProductId");
                    cs.MapRightKey("MaterialId");
                    cs.ToTable("ProductMaterial","Tk");
                });
            //modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("")
        }

        public TaiKangDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public TaiKangDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public TaiKangDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }

        
    }
}
