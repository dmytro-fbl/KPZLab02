using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Method.Models;
using Factory_Method.Models.Abstractions;

namespace Factory_Method.Factories
{
    public class MobileApp : ISubscriptionFactory
    {
        public ISubscription CreateSubscription(EnumSubscription type)
        {
            switch (type)
            {
                case EnumSubscription.Domestic:
                    return new DomesticSubscription(150, "1 місяць", new[] { "Новини", "Мультфільми" });

                case EnumSubscription.Educational:
                    return new EducationalSubscription(200, "3 місяці", new[] { "Історія", "Наука", "Відкриття" });

                case EnumSubscription.Premium:
                    return new PremiumSubscription(350, "12 місяців", new[] { "Всі канали", "4к Контент", "Без реклами" });

                default:
                    throw new ArgumentException("Неправильний тип підписки");
            }
        }

    }
}
