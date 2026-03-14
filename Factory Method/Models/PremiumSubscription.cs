using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Method.Models.Abstractions;

namespace Factory_Method.Models
{
    public class PremiumSubscription : ISubscription
    {
        public double Price { get; set; }
        public string Period { get; set; }
        public string[] Channels { get; set; }
        public PremiumSubscription(double price, string period, string[] channels)
        {
            Price = price;
            Period = period;
            Channels = channels;
        } 
    }
}
