using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKang.EntityFramework;

namespace TaiKang.Migrations.Seed.Management
{
    public class DefaultBannerCreator
    {
        private readonly TaiKangDbContext _context;
        public DefaultBannerCreator(TaiKangDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.Banners.Add(new Tk.Banner
            {
                BannerImage = "\\Images\\1bc.jpg",
                BannerTitle="1",
                Enabled=true,
                OrderNo=1
            });
            _context.SaveChanges();
        }
    }
}
