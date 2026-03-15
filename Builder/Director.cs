using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public void ConstructPaladin(ICharacterBuilder builder)
        {
            builder.SetName("Світлозар")
                   .SetPhysical(195, "Мускулистий")
                   .SetLook("Блонд", "Блакитні")
                   .AddItem("Святий щит")
                   .AddItem("Меч правосуддя");
        }

        public void ConstructDarkLord(ICharacterBuilder builder)
        {
            builder.SetName("Моргот")
                   .SetPhysical(210, "Худорлявий, але могутній")
                   .SetLook("Чорне", "Червоні")
                   .AddItem("Посох темряви");
        }
    }
}
