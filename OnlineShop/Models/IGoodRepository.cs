using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    //способ получения объектов из базы
    public interface IGoodRepository
    {
        IQueryable<Good> Goods { get; }
    }
}
