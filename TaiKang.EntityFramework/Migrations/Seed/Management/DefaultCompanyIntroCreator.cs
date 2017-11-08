using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKang.EntityFramework;

namespace TaiKang.Migrations.Seed.Management
{
    public class DefaultCompanyIntroCreator
    {
        private readonly TaiKangDbContext _context;
        public DefaultCompanyIntroCreator(TaiKangDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.CompanyIntroduces.Add(new Tk.CompanyIntroduce
            {
                CompanyName="泰康生物",
                BrandStory="吧啦啦啦啦啦",
                Address= "吧啦啦啦啦啦地址",
                Introduce= "吧啦啦啦啦啦介绍",
                Qualification= "吧啦啦啦啦啦资质",
            });
            _context.SaveChanges();
        }
    }
}
