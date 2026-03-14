using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Method.Models.Abstractions;

namespace Factory_Method.Factories
{
    public interface ISubscriptionFactory
    {
        ISubscription CreateSubscription(EnumSubscription type);
    }
}
