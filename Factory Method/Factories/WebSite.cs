using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Method.Models;
using Factory_Method.Models.Abstractions;

namespace Factory_Method.Factories
{
    public class WebSite : ISubscriptionFactory
    {
        public ISubscription CreateSubscription(EnumSubscription type)
        {
            switch (type)
            {
                case EnumSubscription.Domestic:
                    return new DomesticSubscription(100, "1 місяць", new[] { "Новини", "Мультфільми" });

                case EnumSubscription.Educational:
                    return new EducationalSubscription(150, "3 місяці", new[] { "Історія", "Наука", "Відкриття" });

                case EnumSubscription.Premium:
                    return new PremiumSubscription(300, "12 місяців", new[] { "Всі канали", "4к Контент", "Без реклами" });

                default:
                    throw new ArgumentException("Неправильний тип підписки");
            }
        }
    }
}
