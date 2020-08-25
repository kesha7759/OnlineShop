using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class DeliveryController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpGet]
        public ViewResult Mail()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Mail(MailDelivery mailDelivery)
        {
            if (ModelState.IsValid)
            {
                MailRepository.AddFeedback(mailDelivery);
                return View("MailThanks", mailDelivery);
            } else
            {
                return View();
            }
        }

        public ViewResult Warehouse()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Home()
        {
            return View();
        }
        [HttpPost]
        [HttpPost]
        public ViewResult Home(HomeDelivery homeDelivery)
        {
            if (ModelState.IsValid)
            {
                HomeRepository.AddFeedback(homeDelivery);
                return View("HomeThanks", homeDelivery);
            }
            else
            {
                return View();
            }
        }
    }
}
