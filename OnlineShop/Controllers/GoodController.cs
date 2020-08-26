using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class GoodController : Controller
    {
        private IGoodRepository repository;
        public GoodController(IGoodRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() 
            => View(new GoodListViewModel { Goods = repository.Goods.OrderBy(g => g.GoodID)});

        public ViewResult Index()
        {
            return View(repository.Goods);
        }
    }
}
