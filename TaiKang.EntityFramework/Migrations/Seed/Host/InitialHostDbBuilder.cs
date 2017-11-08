using TaiKang.EntityFramework;

namespace TaiKang.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly TaiKangDbContext _context;

        public InitialHostDbBuilder(TaiKangDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
