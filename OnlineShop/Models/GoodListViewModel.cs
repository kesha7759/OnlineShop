using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Models;

namespace OnlineShop.Models
{
    public class GoodListViewModel
    {
        public IEnumerable<Good> Goods { get; set; }
    }
}
