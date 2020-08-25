using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Models;

namespace OnlineShop.Models
{
    public class DBInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if(context.Goods.Any())
            {
                return;
            }
            var goods = new Good[]
            {
                new Good { Name = "Утюг", Value = 203.21M, Articul = "1238SA" }
            };
            foreach (Good g in goods)
            {
                context.Goods.Add(g);
            }
            context.SaveChanges();
        }
    }
}
