using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class EFGoodRepository : IGoodRepository
    {
        private ApplicationDbContext context;
        public EFGoodRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Good> Goods => context.Goods;
    }
}
