using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public virtual void AddItem(Good good, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g.Good.GoodID == good.GoodID)
                .FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Good = good,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void IncreaseQuantity(Good good, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g.Good.GoodID == good.GoodID)
                .FirstOrDefault();
            line.Quantity += quantity;
        }
        public virtual void DecreaseQuantity(Good good, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g.Good.GoodID == good.GoodID)
                .FirstOrDefault();
            if(line.Quantity == 1)
            {
                RemoveLine(good);
            } else
            {
                line.Quantity -= quantity;
            }
        }
        public virtual void RemoveLine(Good good) =>
            lineCollection.RemoveAll(l => l.Good.GoodID == good.GoodID);
        public virtual decimal ComputeTotalValue() =>
            lineCollection.Sum(e => e.Good.Value * e.Quantity);
        public virtual void Clear() => lineCollection.Clear();
        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Good Good { get; set; }
        public int Quantity { get; set; }
    }
}
