using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class HomeRepository
    {
        private static List<HomeDelivery> homeFeedbacks = new List<HomeDelivery>();
        public static IEnumerable<HomeDelivery> HomeFeedback
        {
            get { return homeFeedbacks; }
        }
        public static void AddFeedback(HomeDelivery homeFeedback)
        {
            homeFeedbacks.Add(homeFeedback);
        }
    }
}
