using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using OnlineShop.Infrastructure;

namespace OnlineShop.Models
{
    //кеширование данных в браузер????
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart")
                ?? new SessionCart();
            cart.Session = session;
            return cart;
        }
        [JsonIgnore]
        public ISession Session { get; set; }
        public override void AddItem(Good good, int quantity)
        {
            base.AddItem(good, quantity);
            Session.SetJson("Cart", this);
        }
        public override void RemoveLine(Good good)
        {
            base.RemoveLine(good);
            Session.SetJson("Cart", this);
        }
        public override void DecreaseQuantity(Good good, int quantity)
        {
            base.DecreaseQuantity(good, quantity);
            Session.SetJson("Cart", this);
        }
        public override void IncreaseQuantity(Good good, int quantity)
        {
            base.IncreaseQuantity(good, quantity);
            Session.SetJson("Cart", this);
        }
        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
