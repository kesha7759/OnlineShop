using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using OnlineShop.Infrastructure;

namespace OnlineShop.Controllers
{
    public class CartController : Controller
    {
        private IGoodRepository repository;
        private Cart cart;
        public CartController(IGoodRepository repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }
        public RedirectToActionResult AddToCart (int goodId, string returnUrl)
        {
            Good good = repository.Goods
                .FirstOrDefault(g => g.GoodID == goodId);
            if(good != null)
            {
                cart.AddItem(good, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromCart (int goodId, string returnUrl)
        {
            Good good = repository.Goods
                .FirstOrDefault(g => g.GoodID == goodId);
            if (good != null)
            {
                cart.RemoveLine(good);
            }
            return RedirectToAction("Index", new { returnUrl });
        }


    }
}
