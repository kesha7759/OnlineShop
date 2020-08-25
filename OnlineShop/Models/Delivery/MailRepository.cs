using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class MailRepository
    {
        private static List<MailDelivery> mailFeedbacks = new List<MailDelivery>();
        public static IEnumerable<MailDelivery> MailFeedback
        {
            get { return mailFeedbacks; }
        }
        public static void AddFeedback(MailDelivery mailFeedback)
        {
            mailFeedbacks.Add(mailFeedback);
        }
    }
}
