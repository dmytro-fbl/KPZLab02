using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Models.Abstractions
{
    public  interface ISubscription
    {
        public double Price { get; set; }
        public string Period { get; set; }
        public string[] Channels { get; set; }

    }
}
